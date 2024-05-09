using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número 
            //por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:
            //a. 1 si el número es positivo.
            //b. -1 si el número es negativo.
            //c. 0 si el número es cero.
            int n, status = 9;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            positivoNegativoCero(n, ref status);
            Console.WriteLine("El estado del valor: " + n + " es: " + status);
        }
        static void positivoNegativoCero(int a, ref int estado){
        if(a > 0)
            estado = 1;
        else if(a < 0)
            estado = -1;
        else
            estado = 0;
        }
    }
}
