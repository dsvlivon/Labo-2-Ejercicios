using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class PokemonDAO:ManejadorDB
    {
        public bool Guardar(Pokemon p)
        {
            string comando = "INSERT INTO dbo.Pokemon " +
            "(id, nombre, tipo, entrenador, urlImagen) VALUES (@id, @nombre, @tipo, @entrenador, @urlImagen);";
            //Reader.Close();
            this.Comando.CommandText = comando;

            Comando.Parameters.Clear();//ok
            int id = p.Id;
            int type = p.Tipo;
            string nombre = p.Nombre;
            string trianer = p.Entrenador;
            string url = p.UrlImagen;

            Comando.Parameters.AddWithValue("@id", id);//ok
            Comando.Parameters.AddWithValue("@nombre", nombre);//ok
            Comando.Parameters.AddWithValue("@tipo", type);
            Comando.Parameters.AddWithValue("@entrenador", trianer);
            Comando.Parameters.AddWithValue("@urlImagen", url);

            return Ejecutar();
        }
        //public static List<Persona> Leer()
        //{
        //    List<Persona> l = new List<Persona>();
        //    ManejadorDB.Comando.CommandText = "SELECT * FROM dbo.Persona";
        //    try
        //    {
        //        ManejadorDB.Conexion.Open();
        //        ManejadorDB.Reader = ManejadorDB.Comando.ExecuteReader();
        //        if (ManejadorDB.Reader.HasRows)
        //        {
        //            while (ManejadorDB.Reader.Read())
        //            {
        //                Persona x = new Persona(
        //                    ManejadorDB.Reader["nombre"].ToString(),
        //                    ManejadorDB.Reader["apellido"].ToString(),
        //                    Convert.ToInt32(ManejadorDB.Reader["ID"].ToString()));
        //                l.Add(x);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw new ArchivosException($"ERROR EN  ObtenerProductos() - {e.Message} - {e.GetBaseException()}");
        //    }
        //    finally
        //    {
        //        if (ManejadorDB.Conexion.State == System.Data.ConnectionState.Open) { ManejadorDB.Conexion.Close(); }
        //        ManejadorDB.Reader.Close();
        //    }
        //    return l;
        //}
        public Pokemon LeerPorID(int id)
        {
            Pokemon item = null;
            Comando.CommandText = $"SELECT * FROM dbo.Pokemon WHERE ID = {id}";
            try
            {
                Conexion.Open();
                Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        item = new Pokemon(
                            Convert.ToInt32(Reader["id"]),
                            Reader["nombre"].ToString(),
                            Convert.ToInt32(Reader["tipo"]),
                            Reader["entrenador"].ToString(),
                            Reader["urlImagen"].ToString()
                        );
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException($"ERROR EN  ObtenerProductos() - {e.Message} - {e.GetBaseException()}");
            }
            finally
            {
                if (Conexion.State == System.Data.ConnectionState.Open) { Conexion.Close(); }
                Reader.Close();
            }
            return item;
        }
        
        public Pokemon Leer(string? nombre, int? id)
        {
            Pokemon item = null;
            if (nombre != null && id is null) {
                Comando.CommandText = $"SELECT * FROM dbo.Pokemon WHERE nombre = '{nombre}'";
            }
            else { Comando.CommandText = $"SELECT * FROM dbo.Pokemon WHERE id = {id}"; }
            try
            {
                Conexion.Open();
                Reader = Comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        item = new Pokemon(
                            Convert.ToInt32(Reader["id"]),
                            Reader["nombre"].ToString(),
                            Convert.ToInt32(Reader["tipo"]),
                            Reader["entrenador"].ToString(),
                            Reader["urlImagen"].ToString()
                        );
                    }
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException($"ERROR EN  ObtenerProductos() - {e.Message} - {e.GetBaseException()}");
            }
            finally
            {
                if (Conexion.State == System.Data.ConnectionState.Open) { Conexion.Close(); }
                Reader.Close();
            }
            return item;
        }
        //public static bool Modifcar(Persona p)
        //{
        //    ManejadorDB.Comando.CommandText = "UPDATE dbo.Persona " +
        //       $"SET nombre = @nombre, apellido= @apellido WHERE ID = {p.ID}";

        //    ManejadorDB.Comando.Parameters.Clear();
        //    ManejadorDB.Comando.Parameters.AddWithValue("@nombre", p.Nombre);
        //    ManejadorDB.Comando.Parameters.AddWithValue("@apellido", p.Apellido);

        //    return ManejadorDB.Ejecutar();
        //}
        //public static bool Borrar(int id)
        //{
        //    ManejadorDB.Comando.CommandText = "DELETE FROM dbo.Persona WHERE ID = @id";
        //    try
        //    {
        //        ManejadorDB.Comando.Parameters.Clear();
        //        ManejadorDB.Comando.Parameters.AddWithValue("@id", id);
        //        return ManejadorDB.Ejecutar();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new ArchivosException($"ERROR EN  ObtenerProductos() - {e.Message} - {e.GetBaseException()}");
        //    }
        //    finally
        //    {
        //        if (ManejadorDB.Conexion.State == System.Data.ConnectionState.Open) { ManejadorDB.Conexion.Close(); }
        //    }
        //}
    }
}
