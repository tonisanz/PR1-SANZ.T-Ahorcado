using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SanzA.Programacion.Eval1.Juego.Logica
{
    public static class ModeloJuego
    {
        
        public static void AdivinarPalabra(ref int i, int tl, String palabra2, ref String palabra3, ref String le, ref String lp)
        {
            int intento = 0;



            do
            {
                //String lp = "", le = "";
                Boolean exito = false;
                Console.Write("PULSA UNA TECLA");
                Console.ReadLine();
                lp = Console.ReadLine();
                for (i = 0; i <= tl - 1; i++)
                {

                    le = palabra2.Substring(i, 1);
                    if (le.Equals(lp))
                    {

                        palabra3 = palabra3.Remove(i, 1);
                        palabra3 = palabra3.Insert(i, lp);
                        exito = true;

                    }

                }

                if (exito)
                {
                    Console.WriteLine("PALABRA = " + palabra3);
                    Console.WriteLine();

                }
                else
                {
                    intento++;
                    Console.WriteLine("La letra introducida no corresponde a la palabra, llevas " + intento + " intento");
                    Console.WriteLine();

                }

                if (intento == 5)
                {
                    Console.WriteLine(" X");
                    Console.WriteLine(" |");
                    Console.WriteLine("\\  /");
                    Console.WriteLine("/  \\");
                    Console.ReadKey();
                    Console.WriteLine("Has agotado todos tus intentos, ¡PIERDES!");
                    Console.WriteLine();
                    Console.WriteLine("LA PALABRA CORRECTA ERA {0}", palabra2);
                }
                if (intento == 0)
                {
                    Console.WriteLine(" O");
                    Console.WriteLine(" -|-");
                    Console.WriteLine("/  \\");


                    Console.ReadLine();
                }
                if (intento == 1)
                {
                    Console.WriteLine(" -----");
                    Console.WriteLine("    ||");
                    Console.WriteLine("    |O");
                    Console.WriteLine("   |/|\\");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");

                    Console.ReadLine();
                }
                if (intento == 2)
                {
                    Console.WriteLine(" -----");
                    Console.WriteLine(" ||");
                    Console.WriteLine(" |O");

                    Console.WriteLine(" |");
                    Console.WriteLine(" |");

                }
                if (intento == 3)
                {
                    Console.WriteLine(" -----");
                    Console.WriteLine(" ||");
                    Console.WriteLine(" |O");
                    Console.WriteLine("|/|\\");

                    Console.WriteLine(" |");
                    Console.WriteLine(" |");


                }
                if (intento == 4)
                {
                    Console.WriteLine(" O");
                    Console.WriteLine(" |");
                    Console.ReadLine();



                }


                if (palabra2 == palabra3)
                {
                    Console.WriteLine("ENHORABUENA! ¡GANASTE!");
                    break;
                }




            }
            while (intento < 5);
        }
        public static void InterrogacionOEspacio(ref int i, int tl, String palabra2, ref String palabra3)
        {
            for (i = 1; i <= tl; i++)
            {
                if (palabra2.Substring(i, 0) != " ")
                    palabra3 = palabra3 + "?";
                else
                    palabra3 = palabra3 + " ";

            }


            Console.WriteLine(palabra3);
        }
        public static void extraerPalabraAleatoria()
        {
            
            
                 
            //Variable para la cantidad de palabras aleatorias a mostrar
            int cantidad_de_palabras_aleatorias = 1;
            //Creamos un objeto aleatorio
            Random alea = new Random();
            //String donde guardaremos la palabra aleatoria
            String[]palabra = new String[alea.Next(1,100)];
            
            //Bucle principal hasta que se llegue a esa cantidad
            for (int i = 0; i < cantidad_de_palabras_aleatorias; i++)
            {
                StreamReader objReader = new StreamReader("C:\\Users\\ToniSanz\\Source\\Repos\\ahorcado\\juegox\\palabras.txt");
                string aleatorio = objReader.ReadLine();

           
            }

}
    }
}
