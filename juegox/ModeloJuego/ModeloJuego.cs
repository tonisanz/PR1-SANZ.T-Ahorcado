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
            Console.WriteLine("_________ ");
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine("| /|\\ ");
            Console.WriteLine("| / \\ ");
            


            do
            {
                //String lp = "", le = "";
                Boolean exito = false;
                Console.WriteLine("*********************");
                Console.Write("PULSA UNA TECLA");
                Console.Write("\nLETRA PULSADA = ");
                


                lp = Console.ReadLine();
                lp=lp.ToUpper();
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
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabra3);
                    Console.WriteLine("**************************");
                    Console.WriteLine();
                   

                }
                else
                {
                    intento++;
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine("La letra introducida no corresponde a la palabra, llevas " + intento + " intento");
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine();
                    

                }

                if (intento == 5)
                {
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  X ");
                    Console.WriteLine("| /|\\");
                    Console.WriteLine("  / \\ ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabra3);
                    Console.WriteLine("**************************");
                    Console.WriteLine();
                    

                    Console.WriteLine("************************************************************************");
                    Console.WriteLine("Has agotado todos tus intentos, ¡PIERDES!");
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine();
                    Console.WriteLine("LA PALABRA CORRECTA ERA {0}", palabra2);
                    Console.WriteLine("************************************************************************");
                    
                }
                if (intento == 0)
                {
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("| /|\\ ");
                    Console.WriteLine("| / \\ ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabra3);
                    Console.WriteLine("**************************");
                    Console.WriteLine();
                   



                }
                if (intento == 1)
                {
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("| /|\\ ");
                    Console.WriteLine("| /  ");
                   


                }
                if (intento == 2)
                {
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("| /|\\ ");
                    Console.WriteLine("|  ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabra3);
                    Console.WriteLine("**************************");
                    Console.WriteLine();

                }
                if (intento == 3)
                {
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("| /| ");
                    Console.WriteLine("|  ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabra3);
                    Console.WriteLine("**************************");
                    Console.WriteLine();


                }
                if (intento == 4)
                {
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("|  ");
                    Console.WriteLine("|  ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabra3);
                    Console.WriteLine("**************************");
                    Console.WriteLine();



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
        public static string extraerPalabraAleatoria(ref string palabra2)
        {




            //Creamos un objeto aleatorio

            Random alea = new Random();



            StreamReader leerPalabra = new StreamReader("C:\\Users\\ToniSanz\\Source\\Repos\\ahorcado\\juegox\\palabras.txt");
            string texto = File.ReadAllText("C:\\Users\\ToniSanz\\Source\\Repos\\ahorcado\\juegox\\palabras.txt");
            //AVERIGUAMOS CUANTAS LINEAS TIENE EL TXT
            int numLineas = 0;
            int i = 0;
            
            string palabraLeida;
            String[] txt = new String[100];

            while (leerPalabra.Peek() != -1)
            {

                palabraLeida=leerPalabra.ReadLine();
                //ASIGNAMOS LA PALABRA LEIDA A LA POSICION DEL ARRAY
                txt[i] = palabraLeida;
                i++;
                numLineas++;
                
                
                

            }
            int numAleatorio = alea.Next(0, numLineas);
            
            palabra2 = txt[numAleatorio];
            return palabra2;
        }
        

    }
}

                
                
               
                
            
            
            
           
            
            
            
           
            
            
        
        
    

