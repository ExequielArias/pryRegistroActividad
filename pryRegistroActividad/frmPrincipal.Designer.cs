namespace pryRegistroActividad
{
    partial class frmPrincipal
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
            this.cmdRegistrarTareas = new System.Windows.Forms.Button();
            this.cmdListadoDeTareas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRegistrarTareas
            // 
            this.cmdRegistrarTareas.Location = new System.Drawing.Point(12, 12);
            this.cmdRegistrarTareas.Name = "cmdRegistrarTareas";
            this.cmdRegistrarTareas.Size = new System.Drawing.Size(189, 74);
            this.cmdRegistrarTareas.TabIndex = 0;
            this.cmdRegistrarTareas.Text = "Registrar Tareas";
            this.cmdRegistrarTareas.UseVisualStyleBackColor = true;
            this.cmdRegistrarTareas.Click += new System.EventHandler(this.cmdRegistrarTareas_Click);
            // 
            // cmdListadoDeTareas
            // 
            this.cmdListadoDeTareas.Location = new System.Drawing.Point(12, 92);
            this.cmdListadoDeTareas.Name = "cmdListadoDeTareas";
            this.cmdListadoDeTareas.Size = new System.Drawing.Size(189, 74);
            this.cmdListadoDeTareas.TabIndex = 1;
            this.cmdListadoDeTareas.Text = "Listado de Tareas";
            this.cmdListadoDeTareas.UseVisualStyleBackColor = true;
            this.cmdListadoDeTareas.Click += new System.EventHandler(this.cmdListadoDeTareas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 187);
            this.Controls.Add(this.cmdListadoDeTareas);
            this.Controls.Add(this.cmdRegistrarTareas);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrarTareas;
        private System.Windows.Forms.Button cmdListadoDeTareas;
    }
}