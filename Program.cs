using System;

namespace DesafioNumerico
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem-vindo ao Desafio Numerico!");


            // Gera um numero aleatório

            Random random = new Random();

            int numeroSecreto = random.Next(1, 101);
            int tentativas = 0;
            bool acertou = false;




            while (!acertou)
            {
                Console.WriteLine("Escolha um número entre 1 e 100:");
                string? entrada = Console.ReadLine();

                if (string.IsNullOrEmpty(entrada))
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    continue;
                }

                int palpite;
                if (!int.TryParse(entrada, out palpite) || palpite < 1 || palpite > 100)
                {
                    Console.WriteLine("Por favor, insira um número válido entre 1 e 100.");
                    continue;
                }

                tentativas++;

                if (palpite == numeroSecreto)
                {
                    acertou = true;
                    Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
                    Console.WriteLine("Pressione uma tecla para sair.");
                    Console.ReadLine();
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior! Tente novamente.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor! Tente novamente.");
                }
            }












        }
    }
}
