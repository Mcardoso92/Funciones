using System;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int nro = 0, cont = 0;
            Console.WriteLine("Ingrese 20 numeros...");
            for (int i = 0; i < 5; i++)
            {
                nro = int.Parse(Console.ReadLine());
                if(par(nro)){
                    cont++;
                }
            }

            Console.WriteLine("Se ingresaron " + cont + " numeros pares");


        }

        static bool par(int nro){
            if(nro%2 == 0)
                return true;
            else
                return false;
        }
    }
}
