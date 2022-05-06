using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED
{
    class Usuarios
    {
        int id_usuario, id_tipousuario;
        string usuario, password, conPassword, correo;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_tipousuario { get => id_tipousuario; set => id_tipousuario = value; }
    }
}
