using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();

            Console.Title = "### Caixa Eletrônico ###";

        Inicio:
            Console.WriteLine("Escolha a opção na tela");

            Console.WriteLine();

            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Saldo em conta");

            Console.WriteLine();

            int Opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            bool Sair = true;

            while (Sair)
            {

                switch (Opcao)
                {
                    case 1:
                        Console.Write("Digite o valor do depósito: ");
                        double vlrDeposito = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        caixa.Deposito(vlrDeposito);
                        Console.WriteLine();
                        Console.WriteLine("Deseja finalizar a operação? (S/N)");
                        string strSair = Console.ReadLine();
                        Console.Clear();
                        if (string.Equals(strSair, "S", StringComparison.OrdinalIgnoreCase))
                        {
                            Sair = false;
                        }
                        else
                        {
                            goto Inicio;
                        }
                        break;
                    case 2:
                        Console.Write("Digite o valor do saque: ");
                        double vlrSaque = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        caixa.Saque(vlrSaque);
                        Console.WriteLine();
                        Console.WriteLine("Deseja finalizar a operação? (S/N)");
                        strSair = Console.ReadLine();
                        Console.Clear();
                        if (string.Equals(strSair, "S", StringComparison.OrdinalIgnoreCase))
                        {
                            Sair = false;
                        }
                        else
                        {
                            goto Inicio;
                        }
                        break;
                    case 3:
                        Console.Write("Saldo em conta: " + caixa.Saldo);
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Deseja finalizar a operação? (S/N)");
                        strSair = Console.ReadLine();
                        Console.Clear();
                        if (string.Equals(strSair, "S", StringComparison.OrdinalIgnoreCase))
                        {
                            Sair = false;
                        }
                        else
                        {
                            goto Inicio;
                        }
                        break;

                    default: goto Inicio;
                }
            }
            Console.ReadKey();
        }
    }
}