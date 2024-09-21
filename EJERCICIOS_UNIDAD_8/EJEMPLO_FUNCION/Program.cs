using System;

namespace EJEMPLO_FUNCION
{
    class Program
    {
        static void Main(string[] args)
        {
            //FUNCIONES
            //PARTES DE LA FUNCION
            //CABECERA 
            //1. TIPO DE DATO (INT,FLOAT, BOOL, CHAR, VOID)
            //2. NOMBRE(MISMAS REGLAS QUE LAS VARIABLES)
            //3. PARAMETROS(OPCIONAL) - DATOS QUE LE DOY A LA FUNCION PARA QUE TRABAJE
            //CUERPO
            //DEFINICION/LOGICA
            //RETORNO(OPCIONAL): RETORNO DEL VALOR/RESULTADO
            int n;
            n = devovlerUno();
            Console.WriteLine(n);


            Console.WriteLine("Fin del programa...");


        }

        static int devovlerUno(){
            int nro = 1;
            return nro;
        }



    }
}
