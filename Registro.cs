using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class frmRegistro : Form
    {

        List<TipoUsuario> listatipoUsuario = new List<TipoUsuario>();
        Control control = new Control();

        public frmRegistro()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Id_tipousuario = int.Parse(cmbTipoUsuario.SelectedValue.ToString());
            usuario.Usuario = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            usuario.ConPassword = txtConPasword.Text;
            usuario.Correo = txtCorreo.Text;

            try
            {
                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if(respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin IrALogin = new frmLogin();
            this.Visible = false;
            IrALogin.Visible = true;
        }


        private void frmRegistro_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            dataTable = control.ctrlTipoUsuario();

            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show(null, "No se encontraron tipos de usuarios", "informacion", MessageBoxButtons.OK);
            }
            else
            {
                cmbTipoUsuario.DataSource = dataTable;
                cmbTipoUsuario.DisplayMember = "nombre";
                cmbTipoUsuario.ValueMember = "id_tipousuario";
            }
        }

        private void btn_cerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
