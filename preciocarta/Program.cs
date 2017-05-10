using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace preciocarta
{
    class Program
    {
        static void Main(string[] args)
        {

         /* Ejercicio 8
        El costo de enviar por correo una carta es de $0.22 para cartas que pesan hasta 100 gramos (inclusive) y $0.22 más $0.17 por
        cada 100 gramos adicionales o fracción para cartas que pesan más de 100 gramos.
        Crear un programa para leer desde teclado el peso de una carta como un número real de gramos, exhiba el costo de enviar la
        carta en la forma que se muestra en el ejemplo.
        Peso de la carta: 300
        Costo: $0.56 
         */

            Console.WriteLine("LCS System");
            Console.WriteLine("Ingrese los gramos de la carta");
            double preciocomun = 0.22;
            double impuesto = 0.17;
            int peso;
            Console.WriteLine("Ingrese los gramos de la carta");
            peso = Convert.ToInt32(Console.ReadLine());

            if (peso <= 100)
            {

                Console.WriteLine("El precio por enviar su carta es de: " + preciocomun);
            }


            else
            {
                int pesoadicional = peso - 100;
                double impuestoextra = (pesoadicional / 100) * impuesto;
                double costoTotal = 0.22 + impuestoextra;
                Console.WriteLine("El envío sale $" + costoTotal);
                Console.ReadKey();
            }
           

            


            

                
                
            




        }
    }
}
