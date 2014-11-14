using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cui
{
    class Program
    {
        static void Main(string[] args)
        {
            int secreto = ModeloJuego.ModeloJuego.SecretoDeLaVida();
            Console.WriteLine("El secreto de la vida es " + secreto);
            Console.ReadLine();
        }
    }
}
