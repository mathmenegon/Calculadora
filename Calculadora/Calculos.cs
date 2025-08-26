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
            while (true) 
            { 
                Console.Clear();
                Console.WriteLine("Menu de opções:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("\nDigite o numero da operação desejada:");

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
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Pressiona Enter para continuar"); break;
                }
                Console.WriteLine("\nPressione Enter para Voltar");
                Console.ReadKey();
            }
        }

        static (double v1, double v2) ObterDados()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            double v1 = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o segundo valor:");
            double v2 = double.Parse(Console.ReadLine()!);
            return (v1, v2);
        }
        

        static double Soma()
        {
            var dados = ObterDados();

            var resultadoSoma = dados.v1 + dados.v2;
            Console.WriteLine($"O resultado da soma é: {resultadoSoma}");
            return resultadoSoma;
        }

        static double Subtracao()
        {
            var dados = ObterDados();

            var resultadoSubtracao = dados.v1 - dados.v2;
            Console.WriteLine($"O resultado da subtração é: {resultadoSubtracao}");
            return resultadoSubtracao;
        }

        static double Multiplicacao()
        {
            var dados = ObterDados();

            var resultadoMultiplicacao = dados.v1 * dados.v2;
            Console.WriteLine($"O resultado da subtração é: {resultadoMultiplicacao}");
            return resultadoMultiplicacao;
        }

        static double Divisao()
        {
            var dados = ObterDados();

            var resultadoDivisao = dados.v1 / dados.v2;
            Console.WriteLine($"O resultado da subtração é: {resultadoDivisao}");
            return resultadoDivisao;
        }
    }
}
