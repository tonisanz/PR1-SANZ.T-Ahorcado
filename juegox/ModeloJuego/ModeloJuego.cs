using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SanzA.Programacion.Eval1.Juego.Logica
{
    //CLASE ESTATICA QUE INCLUYE LOS MÉTODOS ESTÁTICOS QUE 
    //DEBEN USARSE EN LA CLASE PROGRAM
    public static class ModeloJuego
    {


        //METODO ESTATICO DÓNDE EL USUARIO ADIVINA LA PALABRA ESCOGIDA Y SE DIBUJA
        //EN PANTALLA EL DIBUJO DEL AHORCADO SEGÚN LOS INTENTOS QUE LLEVE EL USUARIO
        public static void AdivinarPalabraSecreta(ref int i, int teclaLeida, String palabraSecreta, ref String palabraJugador, ref String letraEntrada, ref String letraPulsada)
        {
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            int intento = 0;
            Console.WriteLine("\nLA PALABRA TIENE " + palabraSecreta.Length + " LETRAS");
            
            Console.WriteLine("_________ ");
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine("| /|\\ ");
            Console.WriteLine("| / \\ ");
            Console.WriteLine("**************************");
            Console.WriteLine("PALABRA = " + palabraJugador);
            Console.WriteLine("**************************");
            


            do
            {
                //BOOLEANO PARA SABER SI HEMOS ACERTADO O NO
                Boolean exito = false;
                //SACAMOS POR PANTALLA LAS LINEAS SIGUIENTES
                
                Console.WriteLine("*********************");
                Console.Write("PULSA UNA TECLA");
                
                Console.Write("\nLETRA PULSADA = ");
                

                //ALMACENAMOS LA LETRA PULSADA EN LP
                letraPulsada = Console.ReadLine();
                //CONVERTIMOS LP A MAYÚSCULA POR SI EL USUARIO PULSA LA LETRA EN MINÚSCULA
                letraPulsada=letraPulsada.ToUpper();
                //INICIAMOS UN BUCLE FOR PARA INSERTAR LA LETRA EN PALABRA3
                for (i = 0; i <= teclaLeida - 1; i++)
                {

                    letraEntrada = palabraSecreta.Substring(i, 1);
                    if (letraEntrada.Equals(letraPulsada))
                    {

                        palabraJugador = palabraJugador.Remove(i, 1);
                        palabraJugador = palabraJugador.Insert(i, letraPulsada);
                        exito = true;
                        

                    }

                   

                    
                }
                //SI ACERTAMOS LA LETRA, SACAMOS LAS LINEAS SIGUIENTES EN PANTALLA
                if (exito) 
                {
                    Console.WriteLine("\nLA PALABRA TIENE " + palabraSecreta.Length + " LETRAS");
                    
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabraJugador);
                    Console.WriteLine("**************************");
                    Console.WriteLine();
                    
                    
                   

                }
                //SI NO ACERTAMOS, INCREMENTAMOS EN 1 UNIDAD LOS INTENTOS Y SACAMOS EN PANTALLA LO SIGUIENTE
                else
                {
                    intento++;
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine("La letra introducida no corresponde a la palabra, llevas " + intento + " intento");
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine();
                    

                }
                
                //SI INTENTO ES IGUAL A 5
                if (intento == 5)
                {

                    //BORRAMOS LA CONSOLA
                    Console.Clear();
                    //PINTAMOS EL HEADER DEL JUEGO
                    DrawHeader();
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    DrawNumber5();
                    //CAMBIAMOS EL COLOR DE LA CONSOLA A PARTIR DEL HEADER
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    //SACAMOS EN PANTALLA LO SIGUIENTE
                    
                    Console.WriteLine("\nLA PALABRA TIENE " + palabraSecreta.Length + " LETRAS");
                    
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  X ");
                    Console.WriteLine("| /|\\");
                    Console.WriteLine("  / \\ ");
                    
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabraJugador);
                    Console.WriteLine("**************************");
                    Console.WriteLine();

                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Has agotado todos tus intentos, ¡PIERDES!");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("LA PALABRA CORRECTA ERA ----->{0}", palabraSecreta);
                    Console.WriteLine();
                    
                    
                }
                if (intento == 0)
                {
                    Console.Clear();
                    DrawHeader();
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nLA PALABRA TIENE " + palabraSecreta.Length + " LETRAS");
                    
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("| /|\\ ");
                    Console.WriteLine("| / \\ ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabraJugador);
                    Console.WriteLine("**************************");
                    Console.WriteLine();
                   



                }
                if (intento == 1)
                {

                    Console.Clear();
                    DrawHeader();
                    DrawNumber1();
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nLA PALABRA TIENE " + palabraSecreta.Length + " LETRAS");
                    
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("| /|\\ ");
                    Console.WriteLine("| /  ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabraJugador);
                    Console.WriteLine("**************************");

                    

                }
                if (intento == 2)
                {
                    Console.Clear();
                    DrawHeader();
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    DrawNumber2();
                    Console.WriteLine("\nLA PALABRA TIENE " + palabraSecreta.Length + " LETRAS");
                    
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("| /|\\ ");
                    Console.WriteLine("|  ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabraJugador);
                    Console.WriteLine("**************************");
                    Console.WriteLine();
                    

                }
                if (intento == 3)
                {
                    Console.Clear();
                    DrawHeader();
                    DrawNumber3();
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nLA PALABRA TIENE " + palabraSecreta.Length + " LETRAS");
                    
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("| /| ");
                    Console.WriteLine("|  ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabraJugador);
                    Console.WriteLine("**************************");
                    Console.WriteLine();
                    


                }
                if (intento == 4)
                {

                    Console.Clear();
                    DrawHeader();
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    DrawNumber4();
                    Console.WriteLine("\nLA PALABRA TIENE " + palabraSecreta.Length + " LETRAS");
                    Console.WriteLine("_________ ");
                    Console.WriteLine("|  | ");
                    Console.WriteLine("|  0 ");
                    Console.WriteLine("|  ");
                    Console.WriteLine("|  ");
                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + palabraJugador);
                    Console.WriteLine("**************************");
                    Console.WriteLine();
                    



                }

                //SI PALABRA2 ES IGUAL A PALABRA3, GANA EL USUARIO
                if (palabraSecreta == palabraJugador)
                {
                    Console.WriteLine("ENHORABUENA! ¡GANASTE!");
                    DrawHandOk();
                    break;
                }


                
                
               
                

            }
            //TODO LO ANTERIOR SE REALIZARÁ MIENTRAS QUE EL INTENTO SEA MENOR QUE 5
            while (intento < 5);
        }
        //METODO ESTATICO QUE RELLENA UN STRING CON INTERROGRACIONES O ESPACIOS
        //PARA OCULTAR LA PALABRAS ESCOGIDA ALEATORIAMENTE
        public static void InsertarInterrogacionOEspacioEnPalabraSecreta(ref int i, int teclaLeida, String palabraSecreta, ref String palabraJugador)
        {
            for (i = 1; i <= teclaLeida; i++)
            {
                if (palabraSecreta.Substring(i, 0) != " ")
                    palabraJugador = palabraJugador + "?";
                else
                    palabraJugador = palabraJugador + " ";

            }


            
        }
        //METODO ESTATICO QUE DEVUELVE UN STRING, EL CUAL EXTRAE UNA PALABRA ALEATORIA DE UN ARCHIVO DE TEXTO .TXT
        public static string extraerPalabraAleatoria(ref string palabraSecreta)
        {




            //CREAMOS UN OBJETO ALEATORIO

            Random alea = new Random();


            //CREAMOS UN STREAMREADER PARA LEER EL ARCHIVO DE TEXTO DÓNDE ESTÁN LAS PALABRAS
            StreamReader leerPalabra = new StreamReader("C:\\Users\\ToniSanz\\Source\\Repos\\ahorcado\\juegox\\palabras.txt");
            //CREAMOS UN STRING, DONDE LEEMOS EL TXT ENTERO
            string texto = File.ReadAllText("C:\\Users\\ToniSanz\\Source\\Repos\\ahorcado\\juegox\\palabras.txt");
            //AVERIGUAMOS CUANTAS LINEAS TIENE EL TXT
            //CREAMOS UN INT CORRESPONDIENTE AL NUMERO DE LINEAS, INICIALIZADO A CERO
            int numLineas = 0;
            //CREAMOS UN INT CORRESPONDIENTE A UN CONTADOR PARA CONTAR LAS LINEAS QUE TINE EL TXT
            int i = 0;
            //CREAMOS UN STRING LLAMADO PALABRALEIDA PARA SABER LA PALABRA QUE HEMOS LEIDO EN EL TXT DESPUES DEL BUCLE
            string palabraLeida;
            //CREAMOS OTRO STRING DE 100 ELEMENTOS, CORRESPONDIENTES A LAS PALABRAS DEL TXT
            String[] txt = new String[100];
            //MIENTRAS QUE LA POSICION DE LEERPALABRA SE DISTINTO DE -1, ES DECIR A PARTIR DE CERO
            while (leerPalabra.Peek() != -1)
            {
                //EL STRING PALABRALEIDA SERA IGUAL A LA LINEA QUE LEE EN EL TXT
                palabraLeida=leerPalabra.ReadLine();
                //ASIGNAMOS LA PALABRA LEIDA A LA POSICION DEL ARRAY
                txt[i] = palabraLeida;
                //INCREMENTAMOS LA VARIABLE DE TIPO INT "I" EN UNA UNIDAD
                i++;
                //INCREMENTAMOS EL NUMERO DE LINEAS EN UNA UNIDAD
                numLineas++;
                
                
                

            }
            //MIENTRAS QUE LO ANTERIOR SE CUMPLA:
            //LA VARIABLE NUMALETORIO SERA IGUAL A UN NUMERO ALEATORIO ENTRE 0 Y EL NUMERO DE LINEAS
            int numAleatorio = alea.Next(0, numLineas);
            //PALABRA2 SERA IGUAL A LA LINEA QUE OCUPA LA POSICION EN EL TXT DEL NUMERO ALEATORIO
            palabraSecreta = txt[numAleatorio];
            //DEVOLVEMOS EL STRING PALABRA2
            return palabraSecreta;
        }
        //METODO ESTATICO QUE DIBUJA EL HEADER DEL JUEGO
        public static void DrawHeader()
        {
            //DAMOS COLOR A LA CONSOLA
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            //ESCRIBIMOS EN CONSOLA EL HEADER DEL JUEGO
            Console.WriteLine("███████╗██╗          █████╗ ██╗  ██╗ ██████╗ ██████╗  ██████╗ █████╗ ██████╗  ██████╗ ");
            Console.WriteLine("██╔════╝██║         ██╔══██╗██║  ██║██╔═══██╗██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔═══██╗");
            Console.WriteLine("█████╗  ██║         ███████║███████║██║   ██║██████╔╝██║     ███████║██║  ██║██║   ██║");
            Console.WriteLine("██╔══╝  ██║         ██╔══██║██╔══██║██║   ██║██╔══██╗██║     ██╔══██║██║  ██║██║   ██║");
            Console.WriteLine("███████╗███████╗    ██║  ██║██║  ██║╚██████╔╝██║  ██║╚██████╗██║  ██║██████╔╝╚██████╔╝");
            Console.WriteLine("╚══════╝╚══════╝    ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚═════╝  ╚═════╝ ");
            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(".............................");
            Console.WriteLine();
            Console.WriteLine("JUEGO DEL AHORCADO");
            Console.WriteLine("Versión 1.0");
            Console.WriteLine("Autor : Antonio Sanz Llacer");
            Console.WriteLine(".............................");
            Console.WriteLine();
            

        }
        //METODO ESTATICO QUE DIBUJA UNA MANO(OK)
        public static void DrawHandOk()
        {
            
        Console.WriteLine("░░░░░░░░░░░░▄▄");
        Console.WriteLine("░░░░░░░░░░░█░░█");
        Console.WriteLine("░░░░░░░░░░░█░░█");
        Console.WriteLine("░░░░░░░░░░█░░░█");
        Console.WriteLine("░░░░░░░░░█░░░░█");
        Console.WriteLine("███████▄▄█░░░░░██████▄");
        Console.WriteLine("▓▓▓▓▓▓█░░░░░░░░░░░░░░█");
        Console.WriteLine("▓▓▓▓▓▓█░░░░░░░░░░░░░░█");
        Console.WriteLine("▓▓▓▓▓▓█░░░░░░░░░░░░░░█");
        Console.WriteLine("▓▓▓▓▓▓█░░░░░░░░░░░░░░█");
        Console.WriteLine("▓▓▓▓▓▓█░░░░░░░░░░░░░░█");
        Console.WriteLine("▓▓▓▓▓▓█████░░░░░░░░░█");
        Console.WriteLine("██████▀░░░░▀▀██████▀");

        }
        public static void DrawNumber1()
        {
            

        Console.WriteLine(" ██╗    ██╗███╗   ██╗████████╗███████╗███╗   ██╗████████╗ ██████╗ ");
        Console.WriteLine("███║    ██║████╗  ██║╚══██╔══╝██╔════╝████╗  ██║╚══██╔══╝██╔═══██╗");
        Console.WriteLine("╚██║    ██║██╔██╗ ██║   ██║   █████╗  ██╔██╗ ██║   ██║   ██║   ██║");
        Console.WriteLine(" ██║    ██║██║╚██╗██║   ██║   ██╔══╝  ██║╚██╗██║   ██║   ██║   ██║");
        Console.WriteLine(" ██║    ██║██║ ╚████║   ██║   ███████╗██║ ╚████║   ██║   ╚██████╔╝");
        Console.WriteLine(" ╚═╝    ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ");
                                                                  


        }
        public static void DrawNumber2()
        {
            Console.WriteLine("██████╗     ██╗███╗   ██╗████████╗███████╗███╗   ██╗████████╗ ██████╗ ███████╗");
            Console.WriteLine("╚════██╗    ██║████╗  ██║╚══██╔══╝██╔════╝████╗  ██║╚══██╔══╝██╔═══██╗██╔════╝");
            Console.WriteLine(" █████╔╝    ██║██╔██╗ ██║   ██║   █████╗  ██╔██╗ ██║   ██║   ██║   ██║███████╗");
            Console.WriteLine("██╔═══╝     ██║██║╚██╗██║   ██║   ██╔══╝  ██║╚██╗██║   ██║   ██║   ██║╚════██║");
            Console.WriteLine("███████╗    ██║██║ ╚████║   ██║   ███████╗██║ ╚████║   ██║   ╚██████╔╝███████║");
            Console.WriteLine("╚══════╝    ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚══════╝");


        }
        public static void DrawNumber3()
        {
            Console.WriteLine("██████╗     ██╗███╗   ██╗████████╗███████╗███╗   ██╗████████╗ ██████╗ ███████╗");
            Console.WriteLine("╚════██╗    ██║████╗  ██║╚══██╔══╝██╔════╝████╗  ██║╚══██╔══╝██╔═══██╗██╔════╝");
            Console.WriteLine(" █████╔╝    ██║██╔██╗ ██║   ██║   █████╗  ██╔██╗ ██║   ██║   ██║   ██║███████╗");
            Console.WriteLine(" ╚═══██╗    ██║██║╚██╗██║   ██║   ██╔══╝  ██║╚██╗██║   ██║   ██║   ██║╚════██║");
            Console.WriteLine("███████╗    ██║██║ ╚████║   ██║   ███████╗██║ ╚████║   ██║   ╚██████╔╝███████║");
            Console.WriteLine("╚══════╝    ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚══════╝");
            
                                                                              
        }
        public static void DrawNumber4()
        {
            Console.WriteLine("██╗  ██╗    ██╗███╗   ██╗████████╗███████╗███╗   ██╗████████╗ ██████╗ ███████╗");
            Console.WriteLine("██║  ██║    ██║████╗  ██║╚══██╔══╝██╔════╝████╗  ██║╚══██╔══╝██╔═══██╗██╔════╝");
            Console.WriteLine("███████║    ██║██╔██╗ ██║   ██║   █████╗  ██╔██╗ ██║   ██║   ██║   ██║███████╗");
            Console.WriteLine("╚════██║    ██║██║╚██╗██║   ██║   ██╔══╝  ██║╚██╗██║   ██║   ██║   ██║╚════██║");
            Console.WriteLine("     ██║    ██║██║ ╚████║   ██║   ███████╗██║ ╚████║   ██║   ╚██████╔╝███████║");
            Console.WriteLine("     ╚═╝    ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚══════╝");


        }
        public static void DrawNumber5()
        {
            Console.WriteLine("███████╗    ██╗███╗   ██╗████████╗███████╗███╗   ██╗████████╗ ██████╗ ███████╗");
            Console.WriteLine("██╔════╝    ██║████╗  ██║╚══██╔══╝██╔════╝████╗  ██║╚══██╔══╝██╔═══██╗██╔════╝");
            Console.WriteLine("███████╗    ██║██╔██╗ ██║   ██║   █████╗  ██╔██╗ ██║   ██║   ██║   ██║███████╗");
            Console.WriteLine("╚════██║    ██║██║╚██╗██║   ██║   ██╔══╝  ██║╚██╗██║   ██║   ██║   ██║╚════██║");
            Console.WriteLine("███████╗    ██║██║ ╚████║   ██║   ███████╗██║ ╚████║   ██║   ╚██████╔╝███████║");
            Console.WriteLine("╚══════╝    ╚═╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═══╝   ╚═╝    ╚═════╝ ╚══════╝");

        }
        public static void DrawEndProgram()
        {
            Console.WriteLine("███████╗██╗███╗   ██╗    ██████╗ ███████╗██╗              ██╗██╗   ██╗███████╗ ██████╗  ██████╗ ");
            Console.WriteLine("██╔════╝██║████╗  ██║    ██╔══██╗██╔════╝██║              ██║██║   ██║██╔════╝██╔════╝ ██╔═══██╗");
            Console.WriteLine("█████╗  ██║██╔██╗ ██║    ██║  ██║█████╗  ██║              ██║██║   ██║█████╗  ██║  ███╗██║   ██║");
            Console.WriteLine("██╔══╝  ██║██║╚██╗██║    ██║  ██║██╔══╝  ██║         ██   ██║██║   ██║██╔══╝  ██║   ██║██║   ██║");
            Console.WriteLine("██║     ██║██║ ╚████║    ██████╔╝███████╗███████╗    ╚█████╔╝╚██████╔╝███████╗╚██████╔╝╚██████╔╝");
            Console.WriteLine("╚═╝     ╚═╝╚═╝  ╚═══╝    ╚═════╝ ╚══════╝╚══════╝     ╚════╝  ╚═════╝ ╚══════╝ ╚═════╝  ╚═════╝ ");

        }





                                                                                                


        


                                                                              


        

    }
}

                
                
               
                
            
            
            
           
            
            
            
           
            
            
        
        
    

