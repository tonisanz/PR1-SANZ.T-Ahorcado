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
            String palabraSecreta = "", palabraJugador = "", letraEntrada = "", letraPulsada = ""; ;
            
            //LLAMAMOS A LOS MÉTODOS ESTÁTICOS DE LA CLASE MODELOJUEGO
            //Extraemos la palabra aleatoria llamando a el proyecto ModeloJuego
            ModeloJuego.extraerPalabraAleatoria(ref palabraSecreta);
            

            //Escribimos el header del juego en consola
            ModeloJuego.DrawHeader();
            
            //UNA VARIABLE QUE CONTARÁ EL TIEMPO QUE TARDAMOS EN 
            //GANAR O PERDER LA PARTIDA
            //CONTADOR DE TIEMPO
            DateTime tiempoInicio = DateTime.Now;
            
            //Llamamos InterrogacionOespacio para poner el simbolo ? o un espacio
            ModeloJuego.InsertarInterrogacionOEspacioEnPalabraSecreta(ref i, palabraSecreta.Length, palabraSecreta, ref palabraJugador);

            //Llamamos al método AdivinarPalabra para empezar a jugar
            ModeloJuego.AdivinarPalabraSecreta(ref i, palabraSecreta.Length, palabraSecreta, ref palabraJugador, ref letraEntrada, ref letraPulsada);

            //SEGUNDA PARTE DEL CONTADOR DE TIEMPO
            DateTime tiempoFinal = DateTime.Now;
            double total =(tiempoFinal - tiempoInicio).TotalSeconds;
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("###################################");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TIEMPO: " + total.ToString() + "  SEGUNDOS");
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
