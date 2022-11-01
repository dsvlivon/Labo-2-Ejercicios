using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ManejadorDB
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader reader;

        static ManejadorDB()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection("Data Source=.; Initial Catalog=Pokedex; Integrated Security=True;");
            comando.Connection = ManejadorDB.conexion;
        }
        public static SqlConnection Conexion {get { return ManejadorDB.conexion; }}
        public static SqlCommand Comando { get { return ManejadorDB.comando; }}
        public static void SetComandoText(string c) { ManejadorDB.comando.CommandText = c; }
        public static SqlDataReader Reader{ get { return ManejadorDB.reader; }  set { reader = value; } }

        public static bool Ejecutar()
        {
            bool ret = false;
            try
            {
                ManejadorDB.Conexion.Open();
                ret = ManejadorDB.Comando.ExecuteNonQuery() >= 0 ? true : false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error en la base de datos.", ex);//
            }
            finally
            {
                if (ManejadorDB.Conexion.State == System.Data.ConnectionState.Open)
                {
                    ManejadorDB.Conexion.Close();
                }
            }
            return ret;
        }
    }
}
