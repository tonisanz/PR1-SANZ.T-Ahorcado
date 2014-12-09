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
            ModeloJuego.DrawHeader();
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            ModeloJuego.InicializarJuego();
            

            Boolean jugarOtra;

            do
            {
                
                Console.WriteLine("QUIERES JUGAR OTRA PARTIDA? S/N");
                string respuestaJugador = Console.ReadLine();
                respuestaJugador.ToUpper();
                jugarOtra = false;
                if (respuestaJugador == "s" || respuestaJugador == "S") { ModeloJuego.InicializarJuego(); jugarOtra = true; }
                else Console.WriteLine("HASTA LUEGO!");
            } while (jugarOtra == true);

            Console.Read();

            
            
            
            
           
        }

       





        
    }
}
