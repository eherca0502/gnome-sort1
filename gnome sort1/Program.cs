using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnome_sort1
{
     class Program
    {
        static void GnomeSort(int[] array)
        {
            int index = 0;
            while (index < array.Length)
            {
                if (index == 0 || array[index] >= array[index - 1])
                {
                    index++;
                }
                else
                {
                    // Intercambia los elementos si están en el orden incorrecto
                    int temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    index--;
                }
            }
        }

        static void PrintArray(int[] array)
        {
            foreach (var number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            // Genera una matriz de 10 números aleatorios
            int[] randomNumbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, 12);
            }

            Console.WriteLine("Matriz original:");
            PrintArray(randomNumbers);

            // Aplica Gnome Sort a la matriz
            GnomeSort(randomNumbers);

            Console.WriteLine("Matriz ordenada:");
            PrintArray(randomNumbers);

            Console.ReadKey();
        }
    }
}

