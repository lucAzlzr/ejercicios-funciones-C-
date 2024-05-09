using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros 
            //y que devuelva el producto de ambos. Luego hacer un programa 
            //que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
            int precio, cantidadVendida, resultado;
            Console.WriteLine("Ingrese el precio: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidadVendida = int.Parse(Console.ReadLine());

            resultado = producto(precio, cantidadVendida);
            Console.WriteLine("El total a pagar es: " + resultado);
        }

        static int producto(int a, int b){
        int r = a * b;
        return r;
        } 

    }
}
