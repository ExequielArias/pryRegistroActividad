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
        string varReunion;
        string varTareas;

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

            if (cboTipoActividad.SelectedIndex != -1)
            {
                if (txtDetalleActividad.Text != "")
                {
                    if (optSI.Checked == true)
                    {
                        varReunion = "SI";
                    }
                    else
                    {
                        varReunion = "NO";
                    }
                    if (chkDebate.Checked == true) 
                    {
                       varTareas = "Debate, ";
                    }
                    if (chkInvestigacion.Checked == true)
                    {
                        varTareas = varTareas + "Investigacion, ";
                    }
                    if (chkNotasReunion.Checked == true)
                    {
                        varTareas = varTareas + "Notas Reunion, ";
                    }
                    if (chkRepositorio.Checked == true)
                    {
                        varTareas = varTareas + "Repositorio.";
                    }

                    int n = dgbMuestra.Rows.Add();
                    dgbMuestra.Rows[n].Cells[0].Value = dtpFecha.Text;
                    dgbMuestra.Rows[n].Cells[1].Value = cboTipoActividad.Text;
                    dgbMuestra.Rows[n].Cells[2].Value = txtDetalleActividad.Text;
                    dgbMuestra.Rows[n].Cells[3].Value = varReunion;
                    dgbMuestra.Rows[n].Cells[4].Value = varTareas;
                }
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
