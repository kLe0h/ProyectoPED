using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPED
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            frmLogin IrAInicio = new frmLogin();
            this.Visible = false;
            IrAInicio.Visible = true;
        }

        private void btn_Login(object sender, EventArgs e)
        {
            frmLogin IrALogin = new frmLogin();
            this.Visible = false;
            IrALogin.Visible = true;
        }

        private void btn_cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
