using System;
using System.Net.Http.Headers;

namespace QuickSort
{
    class Program
    {
        static void QuickSort(int[] arr, int begin, int end)
        {
            // Array position
            if (begin < end)
            {
                int pivo = Partition(arr, begin, end);
                
                // Recursive call
                QuickSort(arr, begin, pivo - 1); // smaller than the pivo
                QuickSort(arr, pivo + 1, end); // bigger than the pivo
            }
        }

        private static int Partition(int[] arr, int begin, int end)
        {
            int pivo = arr[end]; // Array value
            int i = begin - 1; // Array position
            
            for (int j = begin; j < end; j++)
            {
                // Move the element smaller than the pivo to beginning
                if (arr[j] <= pivo)
                {
                    i++;
                    Swap(arr, i, j); 
                }
            }

            Swap(arr, i + 1, end); // After moving the smaller ones to the beginning, place the pivot after them.
            return i + 1; // Position for pivot has been moved
        }

        private static void Swap(int[] arr, int a, int b)
        {
            int aux = arr[a];
            arr[a] = arr[b];
            arr[b] = aux;
        }

        static void Main(string[] args)
        {
            int[] numeros = { 37, 56, 48, 2, 10, 5, 25 };
            QuickSort(numeros, 0, numeros.Length - 1);

            Console.WriteLine($"Array ordenado: {string.Join(", ", numeros)}");
        }
    }
}