using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public AccesoDatos()
        {
            conn = new SqlConnection("server=.\\SQLEXPRESS; database=DISCOS_DB; Integrated security=true");
            cmd = new SqlCommand();

        }

        public void setQuery(string query)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
        }

        public void ejecutarLectura()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConn()
        {
            if (reader != null)
                reader.Close();

            conn.Close();
        }

        public void setParameters(string nombre, object valor)
        {
            cmd.Parameters.AddWithValue(nombre, valor);
        }
    }
}
