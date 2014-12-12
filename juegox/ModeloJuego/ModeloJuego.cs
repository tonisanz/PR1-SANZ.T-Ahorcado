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

        //METODO QUE INICIALIZA EL JUEGO
        public static void InitializeHangmanGame()
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
            String secretWord = "", GamerWord = "", EntranceLetter = "", DownLetter = ""; ;

            //LLAMAMOS A LOS MÉTODOS ESTÁTICOS DE LA CLASE MODELOJUEGO
            //Extraemos la palabra aleatoria llamando a el proyecto ModeloJuego
            ModeloJuego.RemoveRandomWord(ref secretWord);


            //Escribimos el header del juego en consola
            ModeloJuego.DrawHeader();

            //UNA VARIABLE QUE CONTARÁ EL TIEMPO QUE TARDAMOS EN 
            //GANAR O PERDER LA PARTIDA
            //CONTADOR DE TIEMPO
            DateTime tiempoInicio = DateTime.Now;

            //Llamamos InterrogacionOespacio para poner el simbolo ? o un espacio
            ModeloJuego.InsertInterrogationOrSpaceInSecretWord(ref i, secretWord.Length, secretWord, ref GamerWord);

            //Llamamos al método AdivinarPalabra para empezar a jugar
            ModeloJuego.DrawHangmanAndGuessSecretWord(ref i, secretWord.Length, secretWord, ref GamerWord, ref EntranceLetter, ref DownLetter);

            //SEGUNDA PARTE DEL CONTADOR DE TIEMPO
            DateTime tiempoFinal = DateTime.Now;
            double total = (tiempoFinal - tiempoInicio).TotalSeconds;
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


        }

        //METODO ESTATICO DÓNDE EL USUARIO ADIVINA LA PALABRA ESCOGIDA Y SE DIBUJA
        //EN PANTALLA EL DIBUJO DEL AHORCADO SEGÚN LOS INTENTOS QUE LLEVE EL USUARIO
        public static void DrawHangmanAndGuessSecretWord(ref int i, int ReadedLetter, String SecretWord, ref String GamerWord, ref String EntranceLetter, ref String DownLetter)
        {
          
            
            
            
            
            
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            int Attempt = 0;
            Console.WriteLine("\nLA PALABRA TIENE " + SecretWord.Length + " LETRAS");

            DrawInitialHangman();

            Console.WriteLine("**************************");
            Console.WriteLine("PALABRA = " + GamerWord);
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
                DownLetter = Console.ReadLine();
                //CONVERTIMOS LP A MAYÚSCULA POR SI EL USUARIO PULSA LA LETRA EN MINÚSCULA
                DownLetter = DownLetter.ToUpper();
                //INICIAMOS UN BUCLE FOR PARA INSERTAR LA LETRA EN PALABRA3
                for (i = 0; i <= ReadedLetter - 1; i++)
                {

                    EntranceLetter = SecretWord.Substring(i, 1);
                    if (EntranceLetter.Equals(DownLetter))
                    {

                        GamerWord = GamerWord.Remove(i, 1);
                        GamerWord = GamerWord.Insert(i, DownLetter);
                        exito = true;


                    }




                }

                //SI ACERTAMOS LA LETRA, SACAMOS LAS LINEAS SIGUIENTES EN PANTALLA
                if (exito)
                {
                    Console.WriteLine("\nLA PALABRA TIENE " + SecretWord.Length + " LETRAS");

                    Console.WriteLine("**************************");
                    Console.WriteLine("PALABRA = " + GamerWord);
                    Console.WriteLine("**************************");
                    Console.WriteLine();




                }
                //SI NO ACERTAMOS, INCREMENTAMOS EN 1 UNIDAD LOS INTENTOS Y SACAMOS EN PANTALLA LO SIGUIENTE
                else
                {
                    Attempt++;
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine("La letra introducida no corresponde a la palabra, llevas " + Attempt + " intento");
                    Console.WriteLine("************************************************************************");
                    Console.WriteLine();


                }


                DrawHangmanAttempts(SecretWord, GamerWord, Attempt);


                //SI PALABRA2 ES IGUAL A PALABRA3, GANA EL USUARIO
                if (SecretWord == GamerWord)
                {
                    Console.WriteLine("ENHORABUENA! ¡GANASTE!");
                    DrawHandOk();
                    break;
                }

            }
            //TODO LO ANTERIOR SE REALIZARÁ MIENTRAS QUE EL INTENTO SEA MENOR QUE 5
            while (Attempt < 5);
        }


        //METODO QUE DIBUJA EL AHORCADO SEGUN SUS INTENTOS
        private static void DrawHangmanAttempts(String SecretWord, String GamerWord, int Attempt)
        {
            switch (Attempt)
            {
                case 0:
                    if (Attempt == 0)
                    {
                        Console.Clear();
                        DrawHeader();
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nLA PALABRA TIENE " + SecretWord.Length + " LETRAS");

                        DrawInitialHangman();
                        Console.WriteLine("**************************");
                        Console.WriteLine("PALABRA = " + GamerWord);
                        Console.WriteLine("**************************");
                        Console.WriteLine();

                    }
                    break;

                case 1:
                    if (Attempt == 1)
                    {

                        Console.Clear();
                        DrawHeader();
                        DrawNumber1();
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nLA PALABRA TIENE " + SecretWord.Length + " LETRAS");

                        DrawHangmanAttempt1();
                        Console.WriteLine("**************************");
                        Console.WriteLine("PALABRA = " + GamerWord);
                        Console.WriteLine("**************************");



                    }
                    break;

                case 2:
                    if (Attempt == 2)
                    {
                        Console.Clear();
                        DrawHeader();
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        DrawNumber2();
                        Console.WriteLine("\nLA PALABRA TIENE " + SecretWord.Length + " LETRAS");

                        DrawHangmanAttemp2();
                        Console.WriteLine("**************************");
                        Console.WriteLine("PALABRA = " + GamerWord);
                        Console.WriteLine("**************************");
                        Console.WriteLine();


                    }
                    break;
                case 3:
                    if (Attempt == 3)
                    {
                        Console.Clear();
                        DrawHeader();
                        DrawNumber3();
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nLA PALABRA TIENE " + SecretWord.Length + " LETRAS");

                        DrawHangmanAttempt3();
                        Console.WriteLine("**************************");
                        Console.WriteLine("PALABRA = " + GamerWord);
                        Console.WriteLine("**************************");
                        Console.WriteLine();



                    }
                    break;

                case 4:
                    if (Attempt == 4)
                    {

                        Console.Clear();
                        DrawHeader();
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        DrawNumber4();
                        Console.WriteLine("\nLA PALABRA TIENE " + SecretWord.Length + " LETRAS");
                        DrawHangmanAttempt4();
                        Console.WriteLine("**************************");
                        Console.WriteLine("PALABRA = " + GamerWord);
                        Console.WriteLine("**************************");
                        Console.WriteLine();

                    }
                    break;

                case 5:
                    //SI INTENTO ES IGUAL A 5
                    if (Attempt == 5)
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

                        Console.WriteLine("\nLA PALABRA TIENE " + SecretWord.Length + " LETRAS");

                        DrawEndHangman();

                        Console.WriteLine("**************************");
                        Console.WriteLine("PALABRA = " + GamerWord);
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
                        Console.WriteLine("LA PALABRA CORRECTA ERA ----->{0}", SecretWord);
                        Console.WriteLine();


                    }

                    break;

            }
        }


        //METODOS PARA DIBUJAR LOS AHORCADOS
        private static void DrawInitialHangman()
        {
            Console.WriteLine("_________ ");
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine("| /|\\ ");
            Console.WriteLine("| / \\ ");

        }

        private static void DrawHangmanAttempt1()
        {
            Console.WriteLine("_________ ");
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine("| /|\\ ");
            Console.WriteLine("| /  ");
        }

        private static void DrawHangmanAttemp2()
        {
            Console.WriteLine("_________ ");
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine("| /|\\ ");
            Console.WriteLine("|  ");
        }

        private static void DrawHangmanAttempt3()
        {
            Console.WriteLine("_________ ");
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine("| /| ");
            Console.WriteLine("|  ");
        }

        private static void DrawHangmanAttempt4()
        {
            Console.WriteLine("_________ ");
            Console.WriteLine("|  | ");
            Console.WriteLine("|  0 ");
            Console.WriteLine("|  ");
            Console.WriteLine("|  ");
        }

        private static void DrawEndHangman()
        {
            Console.WriteLine("_________ ");
            Console.WriteLine("|  | ");
            Console.WriteLine("|  X ");
            Console.WriteLine("| /|\\");
            Console.WriteLine("  / \\ ");
        }

        //METODO ESTATICO QUE RELLENA UN STRING CON INTERROGRACIONES O ESPACIOS
        //PARA OCULTAR LA PALABRAS ESCOGIDA ALEATORIAMENTE
        public static void InsertInterrogationOrSpaceInSecretWord(ref int i, int ReadedLetter, String SecretWord, ref String GamerWord)
        {
            for (i = 1; i <= ReadedLetter; i++)
            {
                if (SecretWord.Substring(i, 0) != " ")
                    GamerWord = GamerWord + "?";
                else
                    GamerWord = GamerWord + " ";

            }



        }
        //METODO ESTATICO QUE DEVUELVE UN STRING, EL CUAL EXTRAE UNA PALABRA ALEATORIA DE UN ARCHIVO DE TEXTO .TXT
        public static string RemoveRandomWord(ref string SecretWord)
        {


           

            //CREAMOS UN OBJETO ALEATORIO

            Random alea = new Random();

            try
            {
                //CREAMOS UN STREAMREADER PARA LEER EL ARCHIVO DE TEXTO DÓNDE ESTÁN LAS PALABRAS
                
                StreamReader leerPalabra = new StreamReader(@".\palabras.txt");
                //CREAMOS UN STRING, DONDE LEEMOS EL TXT ENTERO
                string texto = File.ReadAllText(@".\palabras.txt");
            
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
                palabraLeida = leerPalabra.ReadLine();
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
            SecretWord = txt[numAleatorio];
           
            }
            catch (FileNotFoundException dirEx) {
                Console.WriteLine("\n\nEL ARCHIVO PALABRAS.TXT NO EXISTE\n" + dirEx.Message);
                //SI NO EXISTE EL ARCHIVO, EL JUEGO
                //SE INICIARÁ CON PALABRAS PREDEFINIDAS
                String[] AuxiliarWords = new String[10];
                AuxiliarWords[0] = "COCHE";
                AuxiliarWords[1] = "MOTO";
                AuxiliarWords[2] = "BICICLETA";
                AuxiliarWords[3] = "MONITOR";
                AuxiliarWords[4] = "ORDENADOR";
                AuxiliarWords[5] = "CALLE";
                AuxiliarWords[6] = "TECLADO";
                AuxiliarWords[7] = "MANZANA";
                AuxiliarWords[8] = "MUSICA";
                AuxiliarWords[9] = "CODIGO";
                int numAlea = alea.Next(0, 10);
                SecretWord = AuxiliarWords[numAlea];
            }
            
            //DEVOLVEMOS EL STRING PALABRA2
            return SecretWord;
            
            


        }
        //METODO ESTATICO QUE DIBUJA EL HEADER DEL JUEGO
        public static void DrawHeader()
        {
            //DAMOS COLOR A LA CONSOLA
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            //ESCRIBIMOS EN CONSOLA EL HEADER DEL JUEGO
            Console.WriteLine();
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.WriteLine("███████╗██╗          █████╗ ██╗  ██╗ ██████╗ ██████╗  ██████╗ █████╗ ██████╗  ██████╗ ");
            Console.WriteLine("██╔════╝██║         ██╔══██╗██║  ██║██╔═══██╗██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔═══██╗");
            Console.WriteLine("█████╗  ██║         ███████║███████║██║   ██║██████╔╝██║     ███████║██║  ██║██║   ██║");
            Console.WriteLine("██╔══╝  ██║         ██╔══██║██╔══██║██║   ██║██╔══██╗██║     ██╔══██║██║  ██║██║   ██║");
            Console.WriteLine("███████╗███████╗    ██║  ██║██║  ██║╚██████╔╝██║  ██║╚██████╗██║  ██║██████╔╝╚██████╔╝");
            Console.WriteLine("╚══════╝╚══════╝    ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚═════╝  ╚═════╝ ");
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

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
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;

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

