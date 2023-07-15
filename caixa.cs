using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Caixa Eletrônico!");

            double saldo = 1000.0;
            bool executar = true;

            while (executar)
            {
                Console.WriteLine("\nOpções disponíveis:");
                Console.WriteLine("1 - Ver saldo");
                Console.WriteLine("2 - Realizar saque");
                Console.WriteLine("3 - Sair");
                Console.Write("Digite o número da opção desejada: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Seu saldo é: R$ {saldo:F2}");
                        break;
                    case 2:
                        Console.Write("Digite o valor do saque: ");
                        double saque = double.Parse(Console.ReadLine());

                        if (saque <= saldo)
                        {
                            saldo -= saque;
                            Console.WriteLine("Saque realizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente. Saque não realizado.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Obrigado por utilizar o Caixa Eletrônico. Volte sempre!");
                        executar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

            // Aguarda a tecla Enter para fechar a aplicação
            Console.ReadLine();
        }
    }
}
