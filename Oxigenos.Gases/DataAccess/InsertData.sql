        INSERT INTO ControlEnvases 
    SELECT                MAX(CodProducto) CodProducto, MAX(CONVERT(FLOAT,CAPACIDAD)/1000) CAPACIDAD, max(Pertenencia) pertenencia, 
                                CASE WHEN (MAX(Secuencial) = '') then 0 else 1 end as SalidaLlenos, 
                                CASE WHEN (MAX(Secuencial) = '') then 1 else 0 end as SalidaVacios, 
                                0 VENTAS, 0 ASIGNACIONES, 0 RECOLECCIONES, 0 VaciosEntregados 
        FROM                CARGA 
        GROUP BY        CASE WHEN (SECUENCIAL = '') THEN SECUENCIALAJENO ELSE SECUENCIAL END 
        union all 
        SELECT                CODPRODUCTO CodProducto, CONVERT(FLOAT,CAPACIDAD)/1000 CAPACIDAD, pertenencia, 0 SalidaLlenos, 0 SalidaVacios, COUNT(*) VENTAS, 0 ASIGNACIONES, 0 RECOLECCIONES, 0 VaciosEntregados 
        FROM                DETALLEGUIAFACTURASREMISIONES 
        WHERE                SECUENCIAL <> '' 
        GROUP BY        CODPRODUCTO, CAPACIDAD, pertenencia 
        union all 
        SELECT                CODPRODUCTO CodProducto, CONVERT(FLOAT,CAPACIDAD)/1000 CAPACIDAD, pertenencia, 0 SalidaLlenos, 0 SalidaVacios, 0 VENTAS, SUM(CANTIDAD) ASIGNACIONES, 0 RECOLECCIONES , 0 VaciosEntregados 
        FROM                DetalleGuiaAsignacionesRecolecciones 
        WHERE                TIPOMOVIMIENTO = 101 
        GROUP BY        CODPRODUCTO, CAPACIDAD, pertenencia 
        union all 
        SELECT                CODPRODUCTO CodProducto, CONVERT(FLOAT,CAPACIDAD)/1000 CAPACIDAD, pertenencia, 0 SalidaLlenos, 0 SalidaVacios, 0 VENTAS, 0 ASIGNACIONES, SUM(CANTIDAD) RECOLECCIONES, 0 VaciosEntregados 
        FROM                DetalleGuiaAsignacionesRecolecciones 
        WHERE                TIPOMOVIMIENTO = 102 
        GROUP BY        CODPRODUCTO, CAPACIDAD, pertenencia 
        union all 
        SELECT                codproducto CodProducto, CONVERT(FLOAT,CAPACIDAD)/1000 as CAPACIDAD, '2' pertenencia, 0 SalidaLlenos, 0 SalidaVacios, 0 VENTAS, 0 ASIGNACIONES, 0 RECOLECCIONES, count(*) VaciosEntregados 
        FROM                DetalleGuiaFacturasRemisiones 
        WHERE                secuencial = '' and serialajeno <> '' 
        GROUP BY        codproducto, CAPACIDAD 
        union all 
        select                codproducto CodProducto, convert(float,capacidad)/1000 as CAPACIDAD, pertenencia, 0 SalidaLlenos, 0 SalidaVacios, count(*) VENTAS, 0 ASIGNACIONES, 0 RECOLECCIONES, 0 VaciosEntregados 
        from                facturasmanuales 
        where                tipodocumento = 'F' or tipodocumento =  'B' 
    group by        codproducto, capacidad, pertenencia 
        UNION ALL 
        select                codproducto CodProducto, convert(float,capacidad)/1000 as CAPACIDAD, pertenencia, 0 SalidaLlenos, 0 SalidaVacios, 0 VENTAS, 0 ASIGNACIONES, COUNT(*) RECOLECCIONES, 0 VaciosEntregados 
        from                facturasmanuales 
        where                tipodocumento = 'R' 
    group by        codproducto, capacidad, pertenencia 
        ORDER BY        CODPRODUCTO, CAPACIDAD 
