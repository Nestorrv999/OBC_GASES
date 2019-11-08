SELECT     ControlEnvases.CodProducto, SUBSTRING(Productos.Descripcion, 1, 19) AS Descripcion, ControlEnvases.Capacidad, CASE WHEN (pertenencia = 1) 
                      THEN 'PX' ELSE 'AJ' END AS PERTENENCIA, SUM(ControlEnvases.SalidaLlenos) AS SalidaLlenos, SUM(ControlEnvases.SalidaVacios) 
                      AS SalidaVacios, SUM(ControlEnvases.Ventas) AS Ventas, SUM(ControlEnvases.Asignaciones) AS Asignaciones, SUM(ControlEnvases.Recolecciones) 
                      AS Recolecciones, SUM(ControlEnvases.VaciosEntregados) AS VaciosEntregados, SUM(ControlEnvases.SalidaLlenos) - SUM(ControlEnvases.Ventas) 
                      AS RetornoLlenos, SUM(ControlEnvases.SalidaVacios) + SUM(ControlEnvases.Recolecciones) + SUM(ControlEnvases.Ventas) 
                      - SUM(ControlEnvases.Asignaciones) - SUM(ControlEnvases.VaciosEntregados) AS RetornoVacios
FROM         ControlEnvases INNER JOIN
                      Productos ON ControlEnvases.CodProducto = Productos.Codigo
GROUP BY ControlEnvases.CodProducto, Productos.Descripcion, ControlEnvases.Capacidad, ControlEnvases.Pertenencia