using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arreglo();
        }

        private static void Arreglo()
        {
            int[,] matriz = new int[3, 3];
            matriz[0, 0] = 1;
            matriz[0, 0] = 65;
            Random rand = new Random();
            int suma = 0;
            int promedio = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = rand.Next(1, 100);
                    suma += matriz[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("El promedio es : " + suma / 9);
            Console.ReadLine();
        }
    }
}
