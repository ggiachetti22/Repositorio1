using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Prueba{
    class Program{
        static async Task Main(string[] args){
            try{
                //TODO : Saludo;
                Console.WriteLine($"Hola 👋 ≧◉ᴥ◉≦  ..!");
                await Task.Delay(1000);
                //TODO : Saludo end;
                //TODO : Variables;
                List<Prueba> gente = new List<Prueba>();

                Prueba prueba = new Prueba();
                Prueba P1 = new Prueba();
                P1.Nombre = "Natalia";
                P1.Edad = 25;

                Prueba P2 = new Prueba();
                P2.Nombre = "Juan";
                P2.Edad = 29;

                Prueba P3 = new Prueba();
                P3.Nombre = "Ana";
                P3.Edad = 27;

                Prueba P4 = new Prueba();
                P4.Nombre = "Ricardo";
                P4.Edad = 31;

                Prueba P5 = new Prueba();
                P5.Nombre = "Juana";
                P5.Edad = 34;

                gente.AddRange(new Prueba[] {P1, P2, P3, P4, P5});

                foreach(Prueba V in gente){
                    Console.WriteLine($"Nombre: {V.Nombre}, Edad: {V.Edad} años.");
                }

                Random azar = new Random();
                Predicate<Prueba> Predicado = new Predicate<Prueba>(ExisteUser);
                bool existe = gente.Exists(Predicado);

                Console.WriteLine($"Existe Juan? {existe};");
                for(int k = 0; k < gente.Count; k ++) Console.WriteLine($"prueba.Existe(gente[k]) Clásica: {prueba.Existe(gente[k])}");

                // for(LinkedListNode<Prueba> nodo = gente.First; nodo != null; nodo = nodo.Next){
                //     Console.WriteLine($"nodo.Value: {nodo.Value}");
                // }

                String url1 = "C:\\Users\\guillermo.giachetti\\Desktop\\Array de números.txt";
                String url2 = "C:\\Users\\guillermo.giachetti\\Desktop\\txt";
                StreamWriter? ArchivoEditado = null;
                StreamReader? ArchivoLectura = null;
                String LineaEditada,LineaLectura;
                int Contador = 0;
                String frase = "Hola este es un mensaje para identificar Palabras Cláve Hay y filtrarlas...!";
                String codigo = "[C]";
                //TODO : Variables end;
                //TODO : Instacias;

                Regex regex = new Regex(codigo);
                MatchCollection Coleccion = regex.Matches(frase); //TODO se crea una Colleccion/Array de lo buscado;
                
                Console.WriteLine($"\nNº Random: \"{azar.Next(3,999)}\".\n");
                Console.WriteLine($"\nColeccion.Count: {Coleccion.Count}\nVista de la Colección: {string.Join(",",Coleccion)}\nregex: {regex}\nColección: {Coleccion}\n");
                if(Coleccion.Count > 0) Console.WriteLine($"Se encontro una coincidencia");
                else Console.WriteLine($"No se ha encontrado coincidencias");

                regex = new Regex("[H]");
                MatchCollection NuevaColeccion = regex.Matches(frase);
                if(NuevaColeccion.Count > 0) Console.WriteLine($"Resultado {NuevaColeccion.Count} (H)");
                else Console.WriteLine($"No se encontro nada..");


                //TODO: Instacias end;
                // Console.WriteLine($"");
                // await Task.Delay(1000);
                // Console.WriteLine($"");
                // await Task.Delay(1000);

                await Task.Delay(2000);
                Console.WriteLine($"El programa se está ejecuntando con éxito");
                await Task.Delay(1000);
                // Console.WriteLine($"");
                // await Task.Delay(1000);
                // Thread.Sleep(1000);
            }
            catch (Exception e){
                Console.WriteLine($"Se ha producido un error ..!");
                await Task.Delay(1000);
                Console.WriteLine(e.ToString());
                await Task.Delay(1000);
                Console.WriteLine($"\nPresiona cualquier tecla para salir..\n");
                Console.WriteLine($"Presionaste {Console.ReadKey()}  👋");
                // Console.WriteLine($"👋≧◉ᴥ◉≦");
                // TODO
            }
        } // Main;
        static bool ExisteUser(Prueba persona){
            if(persona.Nombre == "Juan") return true;
            else return false;
        }
        delegate void ElDelegado(); //TODO : Delegate;
    } // Prog;
} // name;