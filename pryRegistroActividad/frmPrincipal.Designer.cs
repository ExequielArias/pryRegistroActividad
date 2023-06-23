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
            this.cmdVolver = new System.Windows.Forms.Button();
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
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(12, 92);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(189, 74);
            this.cmdVolver.TabIndex = 1;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 179);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdRegistrarTareas);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrarTareas;
        private System.Windows.Forms.Button cmdVolver;
    }
}