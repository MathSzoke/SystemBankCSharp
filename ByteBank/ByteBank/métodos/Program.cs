using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(7480, 874150);

            Console.WriteLine(ContaCorrente.TaxaOperacao);

            Console.ReadLine();
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
            TestaDivisao(0);
        }

        private static int TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            if(resultado == -2)
            {
                return -2;
            }

            if (resultado == -1)
            {
                Console.WriteLine("Não é possivel fazer divisão por 0");
            }
            else
            {
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

            }
            return 0;
        }

        private static int Dividir(int numero, int divisor)
        {
            if (divisor == 0)
            {
                return -1;
            }

            return numero / divisor;
        }
    }
}
