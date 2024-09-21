using System;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva 
            //el producto de ambos. Luego hacer un programa que pida el precio de un artículo y 
            //la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            float articulo, resultado;
            int cantidad;

            Console.WriteLine("Ingrese el precio del articulo: ");
            articulo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            resultado = producto(articulo, cantidad);

            Console.WriteLine("El total a pagar es de: " + resultado);




        }

        static float producto(float articulo, int cantidad){
            float resultado = articulo * cantidad;
            return resultado;
        }
    }
}
