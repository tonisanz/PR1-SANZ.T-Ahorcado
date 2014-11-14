using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanzA.Programacion.Eval1.Juego.Logica;

namespace SanzA.Programacion.Eval1.Juego.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int secreto = ModeloJuego.SecretoDeLaVida();
            Console.WriteLine("El secreto de la vida es " + secreto);
            Console.ReadLine();
        }
    }
}
