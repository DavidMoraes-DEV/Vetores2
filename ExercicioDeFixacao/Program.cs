using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos Quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Aluguel[] Quartos = new Aluguel[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + (i+1) + ": ");
                Console.WriteLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Quartos[quarto] = new Aluguel(nome, email);
                
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 9; i++)
            {
                if (Quartos[i] != null)
                {
                    Console.Write(i + ": " + Quartos[i]);
                }
            }
        }
    }
}
