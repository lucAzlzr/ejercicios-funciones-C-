using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            int n, conPar = 0;
            bool resultado;
            
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                resultado = par(n);
                if(par(n))
                    conPar++;
                
                Console.WriteLine(resultado);
            }
            Console.WriteLine("El total de números pares ingresados son: " + conPar);
            
        }
        static bool par(int a){
            if(a % 2 == 0){
                return true;
            }else
                return false;
        }
    }
}
