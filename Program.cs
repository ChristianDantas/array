using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Insira o total de compras que você gostaria de fazer: ");
            int tamanho = int.Parse(Console.ReadLine());

            string[] compras = new string[tamanho];

            // Console.WriteLine(nomes.Length);

            for( int i = 0; i < compras.Length; i++)
            {
                Console.Write("Nome do aluno:");
                compras[i] = Console.ReadLine();
            }

            Console.WriteLine("");

            for( int i = 0; i < compras.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" - ");
                Console.Write(compras[i]);
                Console.Write(" - ");
            }

        }
    }
}
