using System;

namespace EJEMPLO_FUNCION2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, resultado;
            Console.WriteLine("Ingrese un nro");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro");
            n2 = int.Parse(Console.ReadLine());

            //Logica
            //resultado = n1+n2;
            resultado = sumar(n1,n2);
            //Fin logica

            Console.WriteLine("El resultado es: " + resultado);
        }
        
        static int sumar(int a, int b){
            int r;
            r = a + b;
            return r;
        }

    }
}
