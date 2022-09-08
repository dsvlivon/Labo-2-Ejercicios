using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public int Dni { get; set; }
        public DateTime Fecha{ get; set; }
        public string Nombre{ get; set; }

        //CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento
        private int CalcularEdad() {
            float dias = (DateTime.Now - this.Fecha).Days;
            return (int)Math.Round(dias/ 365);
        }
        //Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
        public string Mostrar()
        {
            return "Nombre: " + this.Nombre + "\nDni: " + this.Dni + "\nFecha de Nacimiento: " + this.Fecha.ToString() + "\n"+this.EsMayorDeEdad();
        }
        //EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
        public string EsMayorDeEdad()
        {
            if (this.CalcularEdad() > 18) { return "Es mayor de edad"; }
            else { return "es menor"; }
        }
    }
}
