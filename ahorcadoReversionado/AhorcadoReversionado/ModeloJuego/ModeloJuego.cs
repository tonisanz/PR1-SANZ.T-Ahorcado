using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModeloJuego
{
    class ModeloJuego
    {
        public static void AdivinarPalabra()
{
            String palabra;

            int letrasPalabra = palabra.Length;
            int cantidadPalabras;
        
        int intentos;
        Boolean exito=false;
        String palabraAuxiliar;
        String letraPulsada=Console.ReadLine();

        for(int i=0; i<palabra.lenght;i++){
        if(letraPulsada.equals(letrasPalabra)){
        palabraAuxiliar=palabraAuxiliar.remove(i,1);
        palabraAuxiliar=palabraAuxiliar.insert(i,letraPulsada);
        exito=true;
        }
       if(exito){
        Console.WriteLine("PALABRA = "+ palabraAuxiliar);
        }else{
            intentos++;
            Console.WriteLine("LETRA ERRÓNEA, LLEVAS " + intentos + "INTENTOS");
        }

        }
}

        
    }
}
