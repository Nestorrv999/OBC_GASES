namespace PraxairComunicaciones.Comunicacion
{
    partial class CargaDatosForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.UiHandler1 = new DatascanCF.Windows.Forms.UIHandler();
            this.pnlAvance = new System.Windows.Forms.Panel();
            this.btnCancelar = new OpenNETCF.Windows.Forms.Button2();
            this.lblFase = new System.Windows.Forms.Label();
            this.pnlObtenerDatos = new System.Windows.Forms.Panel();
            this.AnimateCtl1 = new OpenNETCF.Windows.Forms.AnimateCtl();
            this.pnlInfoTablas = new System.Windows.Forms.Panel();
            this.lblTabla = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.pbAvanceTabla = new System.Windows.Forms.ProgressBar();
            this.Label3 = new System.Windows.Forms.Label();
            this.pbAvanceTotal = new OpenNETCF.Windows.Forms.ProgressBar2();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.lblProceso = new System.Windows.Forms.Label();
            this.pnlError = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarByError = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlTerminado = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.lblMensajeFinal = new System.Windows.Forms.Label();
            this.timerResetIdleState = new System.Windows.Forms.Timer();
            this.pnlAvance.SuspendLayout();
            this.pnlObtenerDatos.SuspendLayout();
            this.pnlInfoTablas.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.pnlError.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.pnlTerminado.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            this.UiHandler1.HelpControl = null;
            this.UiHandler1.Parent = null;
            // 
            // pnlAvance
            // 
            this.pnlAvance.Controls.Add(this.btnCancelar);
            this.pnlAvance.Controls.Add(this.lblFase);
            this.pnlAvance.Controls.Add(this.pnlObtenerDatos);
            this.pnlAvance.Controls.Add(this.pnlInfoTablas);
            this.pnlAvance.Location = new System.Drawing.Point(0, 23);
            this.pnlAvance.Name = "pnlAvance";
            this.pnlAvance.Size = new System.Drawing.Size(240, 245);
            // 
            // btnCancelar
            // 
            //this.btnCancelar.ForeColor = SystemColors.ControlText;
            this.btnCancelar.ImageIndex = -1;
            this.btnCancelar.ImageList = null;
            this.btnCancelar.Location = new System.Drawing.Point(78, 195);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(72, 21);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblFase
            // 
            this.lblFase.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblFase.Location = new System.Drawing.Point(8, 18);
            this.lblFase.Name = "lblFase";
            this.lblFase.Size = new System.Drawing.Size(217, 20);
            this.lblFase.Text = "Fase";
            // 
            // pnlObtenerDatos
            // 
            this.pnlObtenerDatos.Controls.Add(this.AnimateCtl1);
            this.pnlObtenerDatos.Location = new System.Drawing.Point(0, 45);
            this.pnlObtenerDatos.Name = "pnlObtenerDatos";
            this.pnlObtenerDatos.Size = new System.Drawing.Size(240, 131);
            // 
            // AnimateCtl1
            // 
            this.AnimateCtl1.DelayInterval = 300;
            //this.AnimateCtl1.DrawDirection = DrawDirection.Vertical;
            this.AnimateCtl1.FrameHeight = 60;
            this.AnimateCtl1.FrameWidth = 218;
            this.AnimateCtl1.Height = 60;
            this.AnimateCtl1.Location = new System.Drawing.Point(10, 19);
            this.AnimateCtl1.LoopCount = 0;
            this.AnimateCtl1.Name = "AnimateCtl1";
            this.AnimateCtl1.Size = new System.Drawing.Size(218, 60);
            this.AnimateCtl1.TabIndex = 1;
            this.AnimateCtl1.Width = 218;
            // 
            // pnlInfoTablas
            // 
            this.pnlInfoTablas.Controls.Add(this.lblTabla);
            this.pnlInfoTablas.Controls.Add(this.Label2);
            this.pnlInfoTablas.Controls.Add(this.pbAvanceTabla);
            this.pnlInfoTablas.Controls.Add(this.Label3);
            this.pnlInfoTablas.Controls.Add(this.pbAvanceTotal);
            this.pnlInfoTablas.Location = new System.Drawing.Point(0, 45);
            this.pnlInfoTablas.Name = "pnlInfoTablas";
            this.pnlInfoTablas.Size = new System.Drawing.Size(239, 132);
            this.pnlInfoTablas.Visible = false;
            // 
            // lblTabla
            // 
            this.lblTabla.Location = new System.Drawing.Point(6, 4);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(219, 36);
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(192)))));
            this.Label2.Location = new System.Drawing.Point(10, 82);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(217, 20);
            this.Label2.Text = "Progreso Total:";
            // 
            // pbAvanceTabla
            // 
            this.pbAvanceTabla.Location = new System.Drawing.Point(101, 48);
            this.pbAvanceTabla.Name = "pbAvanceTabla";
            this.pbAvanceTabla.Size = new System.Drawing.Size(124, 12);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(8, 45);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 19);
            this.Label3.Text = "Progreso Tabla:";
            // 
            // pbAvanceTotal
            // 
            this.pbAvanceTotal.BarColor = System.Drawing.SystemColors.Highlight;
            this.pbAvanceTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvanceTotal.Location = new System.Drawing.Point(10, 105);
            this.pbAvanceTotal.Maximum = 100;
            this.pbAvanceTotal.Name = "pbAvanceTotal";
            this.pbAvanceTotal.ShowPercentValueText = true;
            this.pbAvanceTotal.Size = new System.Drawing.Size(217, 17);
            this.pbAvanceTotal.Step = 0;
            this.pbAvanceTotal.TabIndex = 13;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.Panel3.Controls.Add(this.lblProceso);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(240, 26);
            // 
            // lblProceso
            // 
            this.lblProceso.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblProceso.ForeColor = System.Drawing.Color.White;
            this.lblProceso.Location = new System.Drawing.Point(3, 2);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(232, 20);
            this.lblProceso.Text = "Carga Datos";
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.Color.Firebrick;
            this.pnlError.Controls.Add(this.Label1);
            this.pnlError.Controls.Add(this.Panel1);
            this.pnlError.Location = new System.Drawing.Point(0, 90);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(240, 178);
            this.pnlError.Visible = false;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(10, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(191, 17);
            this.Label1.Text = "Error realizando carga";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Panel1.Controls.Add(this.btnCerrarByError);
            this.Panel1.Controls.Add(this.lblError);
            this.Panel1.Location = new System.Drawing.Point(0, 23);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(240, 155);
            // 
            // btnCerrarByError
            // 
            this.btnCerrarByError.Location = new System.Drawing.Point(78, 132);
            this.btnCerrarByError.Name = "btnCerrarByError";
            this.btnCerrarByError.Size = new System.Drawing.Size(72, 20);
            this.btnCerrarByError.TabIndex = 1;
            this.btnCerrarByError.Text = "Cerrar";
            this.btnCerrarByError.Click += new System.EventHandler(this.btnCerrarByError_Click);
            // 
            // lblError
            // 
            this.lblError.Location = new System.Drawing.Point(10, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(215, 117);
            // 
            // pnlTerminado
            // 
            this.pnlTerminado.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTerminado.Controls.Add(this.Label4);
            this.pnlTerminado.Controls.Add(this.Panel4);
            this.pnlTerminado.Location = new System.Drawing.Point(0, 90);
            this.pnlTerminado.Name = "pnlTerminado";
            this.pnlTerminado.Size = new System.Drawing.Size(240, 178);
            this.pnlTerminado.Visible = false;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(10, 3);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(191, 21);
            this.Label4.Text = "Terminado!";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Panel4.Controls.Add(this.btnTerminar);
            this.Panel4.Controls.Add(this.lblMensajeFinal);
            this.Panel4.Location = new System.Drawing.Point(0, 23);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(240, 155);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(78, 132);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(72, 20);
            this.btnTerminar.TabIndex = 1;
            this.btnTerminar.Text = "Cerrar";
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // lblMensajeFinal
            // 
            this.lblMensajeFinal.Location = new System.Drawing.Point(10, 9);
            this.lblMensajeFinal.Name = "lblMensajeFinal";
            this.lblMensajeFinal.Size = new System.Drawing.Size(215, 120);
            this.lblMensajeFinal.Text = "Proceso terminado";
            // 
            // timerResetIdleState
            // 
            this.timerResetIdleState.Interval = 5000;
            this.timerResetIdleState.Tick += new System.EventHandler(this.timerResetIdleState_Tick);
            // 
            // CargaDatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.pnlAvance);
            this.Controls.Add(this.pnlTerminado);
            this.Controls.Add(this.pnlError);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "CargaDatosForm";
            this.Text = "Comunicaciones";
            this.Load += new System.EventHandler(this.CargaDatosForm_Load);
            this.pnlAvance.ResumeLayout(false);
            this.pnlObtenerDatos.ResumeLayout(false);
            this.pnlInfoTablas.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.pnlError.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.pnlTerminado.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal DatascanCF.Windows.Forms.UIHandler UiHandler1;
        internal System.Windows.Forms.Panel pnlAvance;
        internal OpenNETCF.Windows.Forms.Button2 btnCancelar;
        internal System.Windows.Forms.Label lblTabla;
        internal System.Windows.Forms.Label lblFase;
        internal OpenNETCF.Windows.Forms.ProgressBar2 pbAvanceTotal;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label lblProceso;
        internal System.Windows.Forms.Panel pnlError;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnCerrarByError;
        internal System.Windows.Forms.Label lblError;
        internal System.Windows.Forms.ProgressBar pbAvanceTabla;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel pnlInfoTablas;
        internal System.Windows.Forms.Panel pnlTerminado;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Button btnTerminar;
        internal System.Windows.Forms.Label lblMensajeFinal;
        internal System.Windows.Forms.Timer timerResetIdleState;
        internal System.Windows.Forms.Panel pnlObtenerDatos;
        #endregion
        internal OpenNETCF.Windows.Forms.AnimateCtl AnimateCtl1;
    }
}