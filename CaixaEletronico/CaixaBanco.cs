using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaBanco
{
    class Caixa
    {
        public string Nome { get; private set; }
        public double _Saldo { get; private set; }

        private double _sacar;

        private double _depositar;

        public double Saldo
        {
            get
            {
                return _Saldo;
            }
        }

        public void Saque(double vlrSaque)
        {
            if (_Saldo < vlrSaque || _Saldo == 0)
            {
                Console.WriteLine("Valor de saldo indisponível!");
            }
            else if (vlrSaque <= 0)
            {
                Console.WriteLine("Sem valor de saque, a operação será encerrada!");
            }
            else
            {
                _Saldo -= vlrSaque;
                Console.Write("Valor sacado: R$" + vlrSaque);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Saldo em conta: R$" + _Saldo);
                Console.WriteLine();
                Console.Write("----------------------------------");
            }
        }

        public void Deposito(double vlrDeposito)
        {
            if (vlrDeposito <= 0)
            {
                Console.WriteLine("Sem valor de depósito, a operação será encerrada!");
            }
            else
            {
                _Saldo += vlrDeposito;
                Console.Write("Valor Depositado: R$ " + vlrDeposito);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Saldo em conta: R$ " + _Saldo);
                Console.WriteLine();
                Console.Write("----------------------------------");
            }
        }
    }
}