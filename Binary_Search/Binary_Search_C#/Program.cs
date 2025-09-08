using System;

namespace Binary_Search
{
    class Program
    {
        static int Binary_Search(int[] vet, int item)
        {
            int inicio = 0;
            int fim = vet.Length - 1;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                int key = vet[meio];

                if (key == item)
                    return meio;

                if (key >= item)
                    fim = meio - 1;
                else
                    inicio = meio + 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] vet = [1, 3, 5, 7, 11, 13, 17, 19, 23];
            Console.WriteLine(Binary_Search(vet, 11));
            Console.WriteLine(Binary_Search(vet, 19));
            Console.WriteLine(Binary_Search(vet, 2));
        }
    }
}