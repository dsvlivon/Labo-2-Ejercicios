using System;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar unDolar = new Dolar(1);
            Euro unEuro = new Euro(1);
            Peso unPeso = new Peso(1);
            Telefono t = new Telefono("54", "9", "15 6997-0592");
            MiObj o = new MiObj("555 555 555");

            Euro auxEuro = unEuro - unPeso;
            Peso auxPeso = unPeso + unDolar;
            Dolar auxDolar = unDolar + unPeso + unEuro;

            Console.WriteLine(auxEuro.getCantidad());
            Console.WriteLine(auxPeso.getCantidad());
            Console.WriteLine(auxDolar.getCantidad());

            Dolar x = (Dolar)unPeso;
            Console.WriteLine("un peso son : "+x.getCantidad() +" dolares");
            Euro z = (Euro)unPeso;
            Console.WriteLine("un peso son : " + z.getCantidad()+" euros");

            Dolar w = (Dolar)unEuro;
            Console.WriteLine("un euro son : " + w.getCantidad() + " dolares");
            Peso p = (Peso)unEuro;
            Console.WriteLine("un euro son : " + p.getCantidad() + " pesos");

            Euro u = (Euro)unDolar;
            Console.WriteLine("un dolar son : " + u.getCantidad() + " euros");
            Peso r = (Peso)unDolar;
            Console.WriteLine("un dolar son : " + r.getCantidad() + " pesos");

            //unEuro = unPeso;
            //unPeso = unDolar;
            //unDolar = unEuro;

            //Console.WriteLine("Intento d explicita: " +unEuro); 

            var phone = "55 11 987765544";
            t = phone;//#1 implicita  dsd Telefono
            Console.WriteLine(t);
            
            Console.WriteLine((Telefono)o);//#2 explicita dsd MiObj
            
            o = t;//#3 implicita dsd MiObj
            Console.WriteLine(o.ToString());
            Console.ReadKey();
        }
    }

    class Telefono
    {
        string numero { get; set; }
        string area { get; set; }
        string codigo { get; set; }
        public Telefono(string c, string a, string n)
        {
            this.area = a; this.numero = n; this.codigo = c;
        }
        
        public static implicit operator Telefono(string phone) //#1 implicita dsd Telefono
        {
            var data = phone.Split(" ");
            return new Telefono(data[0], data[1], data[2]);
        }

        public static explicit operator MiObj(Telefono t)
        {
            MiObj o = new MiObj("+"+t.codigo +" "+ t.area+" - " + t.numero + "...");
            return o;
        }

        public string XXX()
        {
            return "xxx xxx xxx ";
        }
        public override string ToString()
        {
            return $"+{codigo} ({area}) {numero}";
        }
    }

    class MiObj
    {
        string texto { get; set; }
        public MiObj( string s)
        { this.texto = s; }

        public override string ToString()
        {
            return this.texto;
        }

        public static explicit operator Telefono(MiObj o)//#2 explicita dsd MiObj
        {
            Telefono t = new Telefono("--", "--", "...");
            return t.XXX();
        }

        public static implicit operator MiObj(Telefono t)//#3 implicita dsd MiObj
        {
            return new MiObj("<MiObj> " + t.ToString());
        }
    }
}
 