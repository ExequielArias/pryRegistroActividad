using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRegistroActividad
{

    public partial class frmRegistrarTarea : Form
    {
        public frmRegistrarTarea()
        {
            InitializeComponent();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Value >= DateTime.Today)
            {

            }
            else
            {
                MessageBox.Show("Seleccione una fecha actual o posterior a la de hoy","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFecha .Value = DateTime.Today;
                dtpFecha.Focus(); 
            }

        }
        private void frmRegistrarTarea_Load(object sender, EventArgs e)
        {
            cboTipoActividad.Items.Add("Relevamiento");
            cboTipoActividad.Items.Add("Propuesta");
            cboTipoActividad.Items.Add("Diagnostico");
            cboTipoActividad.Items.Add("Analisis");
            cboTipoActividad.Items.Add("Diagrama de base de datos");
            cboTipoActividad.Items.Add("Programacion");
        }

        private void cboTipoActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}
