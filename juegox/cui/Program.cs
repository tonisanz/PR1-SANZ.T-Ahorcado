using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanzA.Programacion.Eval1.Juego.Logica;
using System.IO;

namespace SanzA.Programacion.Eval1.Juego.CUI
{
    class Program
    {
        static void Main(string[] args)
        {




            
            //Damos color a la consola y al texto
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            //Creamos un objeto aleatorio
            
            
            //Creamos y Damos valores nulos a las variables de tipo int
            int i = 0, longitudPalabra = 0;
            //Inicializamos la variable numeroAleatorio
            

            //Creamos y damos valores vacios a las variables de tipo string
            String palabra2 = "", palabra3 = "", le = "", lp = ""; ;

            
            //Extraemos la palabra aleatoria llamando a el proyecto ModeloJuego

            ModeloJuego.extraerPalabraAleatoria(ref palabra2);
            //Inicializamos la variable longitudPalabra, asignándole la longitud de la palabra escogida aleatoriamente
            longitudPalabra = palabra2.Length;

            //Escribimos el titulo del juego en consola
            Console.WriteLine(".............................");
            Console.WriteLine();
            Console.WriteLine("JUEGO DEL AHORCADO");
            Console.WriteLine("Versión 1.0");
            Console.WriteLine("Autor : Antonio Sanz Llacer");
            Console.WriteLine(".............................");

            Console.WriteLine("\nLa palabra tiene " + longitudPalabra + " letras");


            //Llamamos al bucle for, InterrogacionOespacio para poner el simbolo ? o un espacio
            ModeloJuego.InterrogacionOEspacio(ref i, longitudPalabra, palabra2, ref palabra3);


            //Llamamos al método AdivinarPalabra para empezar a jugar
            ModeloJuego.AdivinarPalabra(ref i, longitudPalabra, palabra2, ref palabra3, ref le, ref lp);

            Console.ReadKey();
        }

    }
}
