namespace pryRegistroActividad
{
    partial class frmRegistrarTarea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoActividad = new System.Windows.Forms.Label();
            this.lblDetalleActividad = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipoActividad = new System.Windows.Forms.ComboBox();
            this.txtDetalleActividad = new System.Windows.Forms.TextBox();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.optNO = new System.Windows.Forms.RadioButton();
            this.optSI = new System.Windows.Forms.RadioButton();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkInvestigacion = new System.Windows.Forms.CheckBox();
            this.chkNotasReunion = new System.Windows.Forms.CheckBox();
            this.chkRepositorio = new System.Windows.Forms.CheckBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTipoActividad
            // 
            this.lblTipoActividad.AutoSize = true;
            this.lblTipoActividad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoActividad.Location = new System.Drawing.Point(9, 67);
            this.lblTipoActividad.Name = "lblTipoActividad";
            this.lblTipoActividad.Size = new System.Drawing.Size(85, 15);
            this.lblTipoActividad.TabIndex = 1;
            this.lblTipoActividad.Text = "Tipo Actividad";
            // 
            // lblDetalleActividad
            // 
            this.lblDetalleActividad.AutoSize = true;
            this.lblDetalleActividad.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleActividad.Location = new System.Drawing.Point(12, 125);
            this.lblDetalleActividad.Name = "lblDetalleActividad";
            this.lblDetalleActividad.Size = new System.Drawing.Size(100, 15);
            this.lblDetalleActividad.TabIndex = 2;
            this.lblDetalleActividad.Text = "Detalle Actividad";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(12, 31);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // cboTipoActividad
            // 
            this.cboTipoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoActividad.FormattingEnabled = true;
            this.cboTipoActividad.Location = new System.Drawing.Point(12, 85);
            this.cboTipoActividad.Name = "cboTipoActividad";
            this.cboTipoActividad.Size = new System.Drawing.Size(200, 21);
            this.cboTipoActividad.TabIndex = 4;
            this.cboTipoActividad.SelectedIndexChanged += new System.EventHandler(this.cboTipoActividad_SelectedIndexChanged);
            // 
            // txtDetalleActividad
            // 
            this.txtDetalleActividad.Location = new System.Drawing.Point(12, 143);
            this.txtDetalleActividad.Multiline = true;
            this.txtDetalleActividad.Name = "txtDetalleActividad";
            this.txtDetalleActividad.Size = new System.Drawing.Size(200, 107);
            this.txtDetalleActividad.TabIndex = 5;
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optNO);
            this.mrcReunion.Controls.Add(this.optSI);
            this.mrcReunion.Location = new System.Drawing.Point(12, 266);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(200, 66);
            this.mrcReunion.TabIndex = 6;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // optNO
            // 
            this.optNO.AutoSize = true;
            this.optNO.Location = new System.Drawing.Point(113, 31);
            this.optNO.Name = "optNO";
            this.optNO.Size = new System.Drawing.Size(41, 17);
            this.optNO.TabIndex = 1;
            this.optNO.TabStop = true;
            this.optNO.Text = "NO";
            this.optNO.UseVisualStyleBackColor = true;
            // 
            // optSI
            // 
            this.optSI.AutoSize = true;
            this.optSI.Location = new System.Drawing.Point(38, 31);
            this.optSI.Name = "optSI";
            this.optSI.Size = new System.Drawing.Size(35, 17);
            this.optSI.TabIndex = 0;
            this.optSI.TabStop = true;
            this.optSI.Text = "SI";
            this.optSI.UseVisualStyleBackColor = true;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkInvestigacion);
            this.mrcTareas.Controls.Add(this.chkNotasReunion);
            this.mrcTareas.Controls.Add(this.chkRepositorio);
            this.mrcTareas.Location = new System.Drawing.Point(15, 338);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(200, 88);
            this.mrcTareas.TabIndex = 7;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(110, 54);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(61, 17);
            this.chkDebate.TabIndex = 3;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkInvestigacion
            // 
            this.chkInvestigacion.AutoSize = true;
            this.chkInvestigacion.Location = new System.Drawing.Point(110, 31);
            this.chkInvestigacion.Name = "chkInvestigacion";
            this.chkInvestigacion.Size = new System.Drawing.Size(89, 17);
            this.chkInvestigacion.TabIndex = 2;
            this.chkInvestigacion.Text = "Investigacion";
            this.chkInvestigacion.UseVisualStyleBackColor = true;
            // 
            // chkNotasReunion
            // 
            this.chkNotasReunion.AutoSize = true;
            this.chkNotasReunion.Location = new System.Drawing.Point(17, 54);
            this.chkNotasReunion.Name = "chkNotasReunion";
            this.chkNotasReunion.Size = new System.Drawing.Size(97, 17);
            this.chkNotasReunion.TabIndex = 1;
            this.chkNotasReunion.Text = "Notas Reunion";
            this.chkNotasReunion.UseVisualStyleBackColor = true;
            // 
            // chkRepositorio
            // 
            this.chkRepositorio.AutoSize = true;
            this.chkRepositorio.Location = new System.Drawing.Point(17, 31);
            this.chkRepositorio.Name = "chkRepositorio";
            this.chkRepositorio.Size = new System.Drawing.Size(79, 17);
            this.chkRepositorio.TabIndex = 0;
            this.chkRepositorio.Text = "Repositorio";
            this.chkRepositorio.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(54, 432);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 8;
            this.cmdRegistrar.Text = "Resgistrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(137, 432);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 9;
            this.cmdBorrar.Text = "Borar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 466);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.txtDetalleActividad);
            this.Controls.Add(this.cboTipoActividad);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblDetalleActividad);
            this.Controls.Add(this.lblTipoActividad);
            this.Controls.Add(this.lblFecha);
            this.MaximizeBox = false;
            this.Name = "frmRegistrarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Tarea";
            this.Load += new System.EventHandler(this.frmRegistrarTarea_Load);
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoActividad;
        private System.Windows.Forms.Label lblDetalleActividad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipoActividad;
        private System.Windows.Forms.TextBox txtDetalleActividad;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.RadioButton optNO;
        private System.Windows.Forms.RadioButton optSI;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkInvestigacion;
        private System.Windows.Forms.CheckBox chkNotasReunion;
        private System.Windows.Forms.CheckBox chkRepositorio;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdBorrar;
    }
}