using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED
{
    public class TipoUsuario
    {
        private int idTipoUsuario;
        private String nombre;

        public int IdTipoUsuario { get => idTipoUsuario; set => idTipoUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
