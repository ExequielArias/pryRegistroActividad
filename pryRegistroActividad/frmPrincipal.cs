using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRegistroActividad
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void cmdRegistrarTareas_Click(object sender, EventArgs e)
        {
            frmRegistrarTarea registrarTareas = new frmRegistrarTarea();    
            registrarTareas.ShowDialog();
        }
        this.Hide();

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            
        }
    }

}


