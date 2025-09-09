using System;

namespace Selection_Sort
{
    class Program
    {
        static int SearchMinorMajor(int[] arr, int start, bool reverse)
        {
            int aux = arr[start];
            int aux_index = start;

            for (int i = start; i <= arr.Length - 1; i++)
            {
                if (reverse == false)
                {
                    if (arr[i] < aux)
                    {
                        aux = arr[i];
                        aux_index = i;
                    }
                } else
                {
                    if (arr[i] > aux)
                    {
                        aux = arr[i];
                        aux_index = i;
                    }
                }
            }

            return aux_index;
        }

        static int[] SelectionSort(int[] arr, bool reverse = false)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                int index = SearchMinorMajor(arr, i, reverse);

                int aux = arr[i];
                arr[i] = arr[index];
                arr[index] = aux;
            }

            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = [5, 6, 2, 10, 3];

            Console.WriteLine(string.Join(",", SelectionSort(arr)));
            Console.WriteLine(string.Join(",", SelectionSort(arr, true)));
        }
    }
}