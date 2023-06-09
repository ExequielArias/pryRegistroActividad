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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "exe" )
            {
                if (txtContraseña.Text == "123456")
                {
                    this.Hide();
                    frmPrincipal frmPrincipal = new frmPrincipal();     
                    frmPrincipal.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
