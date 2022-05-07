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
    public partial class FrmCatalogo : Form
    {
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void btn_regresar(object sender, EventArgs e)
        {
            FrmMenuPrincipal IrAMenu = new FrmMenuPrincipal();
            this.Visible = false;
            IrAMenu.Visible = true;
        }

        private void btn_cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
