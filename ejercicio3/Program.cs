using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
            //Informar el promedio teniendo en cuenta sólo los números primos.
            int n, con = 0, acu = 0, promedio;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                if(primo(n)){
                    con++;
                    acu += n;
                }
                Console.WriteLine("Ingrese otro número: ");
                n = int.Parse(Console.ReadLine());
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de los números primos es: " + promedio);
        }

        static bool primo(int a){
            int conPrimo = 0;
            for (int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                conPrimo++;
            }
            if(conPrimo == 2)
                return true;
            else
                return false;
        }
    }
}
