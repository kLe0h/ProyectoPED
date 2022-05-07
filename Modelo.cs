using MySql.Data.MySqlClient;  
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPED
{
    class Modelo
    {
      public int registro(Usuarios usuario)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            string sql = "INSERT INTO usuarios (usuario, password, correo, id_tipousuario) VALUES(@usuario, @password, @correo, @id_tipousuario)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@correo", usuario.Correo);
            comando.Parameters.AddWithValue("@id_tipousuario", usuario.Id_tipousuario);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
            
        }


        
        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id_usuario FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Usuarios PorUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id_usuario, password, usuario, id_tipousuario FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id_usuario = int.Parse(reader["Id_usuario"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Usuario = reader["Usuario"].ToString();
                usr.Id_tipousuario = int.Parse(reader["Id_tipousuario"].ToString());
            }
            return usr;
        }


        public DataTable getTipoUsuario()
        {
            DataTable dataTable = new DataTable();
            MySqlConnection conexion = Conexion.getConexion();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from tipo_usuarios", conexion);

            conexion.Open();

            mySqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
