using System;using Entidades;

namespace ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            //Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            //Mostrar los datos de todos los alumnos.

            Estudiante uno = new Estudiante("lopez", "121a", "juan");
            uno.SetNotaPrimerParcial(6);
            uno.SetNotaSegundoParcial(9);
            Estudiante dos = new Estudiante("lopez", "121b", "javier");
            dos.SetNotaPrimerParcial(4);
            dos.SetNotaSegundoParcial(3);
            Estudiante tres = new Estudiante("lopez", "121c", "julio");
            tres.SetNotaPrimerParcial(3);
            tres.SetNotaSegundoParcial(9);


            Console.WriteLine(uno.Mostar());
            Console.WriteLine(dos.Mostar());
            Console.WriteLine(tres.Mostar());

            Console.ReadLine();
        }
    }
}
