using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class TipoDAO
    {
        public static List<String> Leer()
        {
            List<String> l = new List<String>();
            ManejadorDB.Comando.CommandText = "SELECT * FROM dbo.Tipos";
            try
            {
                ManejadorDB.Conexion.Open();
                ManejadorDB.Reader = ManejadorDB.Comando.ExecuteReader();
                if (ManejadorDB.Reader.HasRows)
                {
                    while (ManejadorDB.Reader.Read())
                    {
                        l.Add(ManejadorDB.Reader["nombre"].ToString());
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException($"ERROR EN  ObtenerProductos() - {e.Message} - {e.GetBaseException()}");
            }
            finally
            {
                if (ManejadorDB.Conexion.State == System.Data.ConnectionState.Open) { ManejadorDB.Conexion.Close(); }
                ManejadorDB.Reader.Close();
                ManejadorDB.Comando.CommandText = "caca";
            }
            return l;
        }
        
    }
}
