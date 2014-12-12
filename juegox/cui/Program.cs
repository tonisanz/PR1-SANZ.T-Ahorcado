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
            
            ModeloJuego.InitializeHangmanGame();
            

            Boolean PlayAgain;

            do
            {
                
                Console.WriteLine("QUIERES JUGAR OTRA PARTIDA? S/N");
                string GamerReply = Console.ReadLine();
                GamerReply.ToUpper();
                PlayAgain = false;
                if (GamerReply == "s" || GamerReply == "S") { ModeloJuego.InitializeHangmanGame(); PlayAgain = true; }
                else Console.WriteLine("HASTA LUEGO!");
            } while (PlayAgain == true);

            Console.Read();

            
            
            
            
           
        }

       





        
    }
}
