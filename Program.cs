using System;
using Terciario.Models;

namespace Terciario
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5] { 1, 2, 3, 4, 5 };
            int numero1 = numeros[0];

            Console.WriteLine(numero1); //imprimimos lo q nosotros queremos.
            Console.WriteLine(numeros.Length);//length es el tamaño del vector.

            for (int i = 0; i < numeros.Length; i++) //un for de toda la vida   
            {
                Console.WriteLine("Iteracion: " + i + "-" + numeros[i]);// EL I ES EL NUMERO EN EL Q ESTA
            }
            Console.WriteLine("--------------------------");
            foreach (var numero in numeros) // otra forma de usar for
            {
                Console.WriteLine(numero);
            }


            Vino vinoUno = new Vino(50, "tinto"); //creamos a vino o lo tremos de Vino.cs

            Bebida bebida = new Bebida();
            Bebida bebida2 = new Bebida("fanta", 600);

            bebida.Nombre = "Coquita";
            bebida.Cantidad = 500;

            bebida.Tomarse(100);
            bebida2.Tomarse(200);

            Console.WriteLine("Le quedan " + bebida.Cantidad + " a la bebida: " + bebida.Nombre);
            Console.WriteLine(bebida2.Cantidad);
            Console.ReadKey();

           
            mostrarRecomendacion(vinoUno);
            Cerveza cerveza = new Cerveza();
            mostrarRecomendacion(cerveza);
        }
    }

    static void mostrarRecomendacion(IBebidaAlcoholica bebidaAlcoholica)
    {
        bebidaAlcoholica.maxRecomendando();
    }


}
