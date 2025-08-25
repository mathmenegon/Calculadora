using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculos
    {
        public void MenuSelecao()
        {

                Console.Clear();
                Console.WriteLine("Selecione a operação desejada:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                double operacao = double.Parse(Console.ReadLine()!);

                switch (operacao)
                {
                    case 1:
                        Soma(); break;
                    case 2:
                        Subtracao(); break;
                    case 3:
                        Multiplicacao(); break;
                    case 4:
                        Divisao(); break;
                    case 5:
                        break;
                }
        }


        static double Soma()
        {
            Console.WriteLine("Digite o primeiro valor:");
            double v1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o segundo valor:");
            double v2 = double.Parse(Console.ReadLine()!);

            var resultadoSoma = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultadoSoma}");
            return resultadoSoma;
        }

        static double Subtracao()
        {
            Console.WriteLine("Digite o primeiro valor:");
            double v1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o segundo valor:");
            double v2 = double.Parse(Console.ReadLine()!);

            var resultadoSubtracao = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultadoSubtracao}");
            return resultadoSubtracao;
        }

        static double Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro valor:");
            double v1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o segundo valor:");
            double v2 = double.Parse(Console.ReadLine()!);

            var resultadoMultiplicacao = v1 * v2;
            Console.WriteLine($"O resultado da subtração é: {resultadoMultiplicacao}");
            return resultadoMultiplicacao;
        }

        static double Divisao()
        {
            Console.WriteLine("Digite o primeiro valor:");
            double v1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o segundo valor:");
            double v2 = double.Parse(Console.ReadLine()!);

            var resultadoDivisao = v1 / v2;
            Console.WriteLine($"O resultado da subtração é: {resultadoDivisao}");
            return resultadoDivisao;
        }
    }
}
