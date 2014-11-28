using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanzA.Programacion.Eval1.Juego.Logica;
using System.IO;
using System.Runtime;

namespace SanzA.Programacion.Eval1.Juego.CUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //DAMOS COLOR A LA CONSOLA Y AL TEXTO
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            //LIMPIAMOS LA CONSOLA
            Console.Clear();
            
            //CREACION DE VARIABLES
            //Contador de letras de la palabra a adivinar
            int i = 0;
            //Creamos y damos valores vacios a las variables de tipo string
            //Palabra2 => palabraSecreta
            //Palabra2 => palabraJugador
            String palabra2 = "", palabra3 = "", le = "", lp = ""; ;
            
            //LLAMAMOS A LOS MÉTODOS ESTÁTICOS DE LA CLASE MODELOJUEGO
            //Extraemos la palabra aleatoria llamando a el proyecto ModeloJuego
            ModeloJuego.extraerPalabraAleatoria(ref palabra2);
            

            //Escribimos el header del juego en consola
            ModeloJuego.DrawHeader();
            
            //UNA VARIABLE QUE CONTARÁ EL TIEMPO QUE TARDAMOS EN 
            //GANAR O PERDER LA PARTIDA
            //CONTADOR DE TIEMPO
            DateTime tiempo1 = DateTime.Now;
            
            //Llamamos InterrogacionOespacio para poner el simbolo ? o un espacio
            ModeloJuego.InterrogacionOEspacio(ref i, palabra2.Length, palabra2, ref palabra3);

            //Llamamos al método AdivinarPalabra para empezar a jugar
            ModeloJuego.AdivinarPalabra(ref i, palabra2.Length, palabra2, ref palabra3, ref le, ref lp);

            //SEGUNDA PARTE DEL CONTADOR DE TIEMPO
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("###################################");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TIEMPO: " + total.ToString() + "  HORAS");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("###################################");
            Console.WriteLine();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            //ESCRIBIMOS EN CONSOLA LA FINALIZACIÓN DE LA PARTIDA
            ModeloJuego.DrawEndProgram();
            Console.ReadLine();
            Console.Clear();
            
            
            
            
           
        }


        
    }
}
