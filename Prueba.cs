using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba{
    public class Prueba{
        private string nombre = "";
        private int edad;
        public string Nombre {get => nombre; set => nombre = value;}
        public int Edad {get => edad; set => edad = value;}
        public static void Saludo(){
            Console.WriteLine($"Hola..");
        }
        public bool Existe(Prueba persona){
            if(persona.Nombre == "Juan") return true;
            else return false;
        }
        private string EXISTE(Prueba persona){
            if(persona.Nombre == "Juan") return "";
            else return "";
        }
        // public string PRUEBA{
        //     get => this.nombre;
        //     set => this.nombre = EXISTE(value);
        // }
    } // class;
} // name;