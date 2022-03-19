using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Acceso;
using Datos.Entidades;

namespace Datos.Acceso
{
   public class UsuarioDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=Tarea3; Uid=root; Pwd=Killer111:$;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string codigo, string clave)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuarios WHERE Codigo = @Codigo AND Clave= @Clave;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.ClaveDeIngreso = reader[2].ToString();
                    user.Estado = Convert.ToBoolean(reader[3]);

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user;
        }

        public DataTable ListarUsuarios()
        {
            DataTable listaUsuariosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuarios;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaUsuariosDT.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return listaUsuariosDT;
        }
    }
}