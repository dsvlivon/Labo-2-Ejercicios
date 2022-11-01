using System;

namespace Entidades
{
    public class Pokemon
    {
        private int id;
        private string nombre;
        private string tipo;
        private string entrenador;
        private string urlImagen;

        public Pokemon(int id, string nombre, string tipo, string entrenador, string urlImagen)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipo = tipo;
            this.entrenador = entrenador;
            this.urlImagen = formatearUrlImagen(urlImagen);
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Entrenador { get => entrenador; set => entrenador = value; }
        public string UrlImagen { get => urlImagen; set => urlImagen = value; }
        public int Tipo { get {
                int cont = 1;
                TipoDAO t = new TipoDAO();
                foreach (var item in t.Leer())
                {
                    if (this.tipo == item) { return cont; }
                    cont++;
                }
                return 0;
            } 
        }

        private string formatearUrlImagen(string pic) {
            //public string initialDirectory = "C:\\Users\\L54556\\OneDrive - Kimberly-Clark\\Desktop\\DANIEL\\UTN\\labo-2-Ejercicios\\Clase Sql\\C02 - La Pokedex\\Media";
            string[] buf = pic.Split("x");
            return buf[1];
        }
    }
}
