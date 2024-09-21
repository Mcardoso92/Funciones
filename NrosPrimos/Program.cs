using System;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el 
            //número es primo o cero si no lo es. Hacer un programa para ingresar números. 
            //El lote corta cuando se ingresa un número cero. 
            //Informar el promedio teniendo en cuenta sólo los números primos.

            int nro, acum = 0, cont = 0;
            float prom;
            Console.WriteLine("Ingrese un nro...");
            nro = int.Parse(Console.ReadLine());
            while(nro != 0){
                if(primo(nro)){
                    acum += nro;
                    cont++;
                }
                Console.WriteLine("Ingrese un nro...");
                nro = int.Parse(Console.ReadLine());

            }

            prom = (float)acum/cont;
            Console.WriteLine("El promedio es: " + prom);


        }

        static bool primo(int nro){
            int cont = 0;
            for (int i = 1; i <= nro; i++)
            {
                if(nro % i == 0 && nro != 2){
                    cont++;
                }
            }
            if(cont == 2)
                return true;
            else
                return false;
        }

    }
}
