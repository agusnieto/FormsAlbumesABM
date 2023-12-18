using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumesFinal.Datos
{
    public class AccesoDatos
    {
        private readonly string stringConexion = @"Data Source=NEHO-PC\SQLEXPRESS;Initial Catalog=Albumes;Integrated Security=True";
        private readonly SqlConnection conexion;
        private SqlCommand comando;

        public AccesoDatos()
        {
            conexion = new SqlConnection(stringConexion);
        }

        public DataTable SelectTabla(string nombre)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + nombre; // + " ORDER BY 2";
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
        public bool Ejecutar(string sql, List<Parametro> parametros)
        {
            int filasAfectadas = 0;
            Conectar();
            comando.CommandText = sql;
            foreach (Parametro param in parametros)
            {
                comando.Parameters.AddWithValue(param.Clave, param.Valor);
            }
            filasAfectadas = comando.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas == 1;
        }
        public void Desconectar()
        {
            conexion.Close();
        }
        private void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
    }
}
