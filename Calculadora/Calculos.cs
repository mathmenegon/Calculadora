using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
                Console.WriteLine("5 - Potência");
                Console.WriteLine("6 - Sair");
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
                        Potencia(); break ;
                    case 6:
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
        

        static void Soma()
        {
            var dados = ObterDados();

            var resultadoSoma = dados.v1 + dados.v2;
            Console.WriteLine($"O resultado da soma é: {resultadoSoma}");
        }

        static void Subtracao()
        {
            var dados = ObterDados();

            var resultadoSubtracao = dados.v1 - dados.v2;
            Console.WriteLine($"O resultado da subtração é: {resultadoSubtracao}");
        }

        static void Multiplicacao()
        {
            var dados = ObterDados();

            var resultadoMultiplicacao = dados.v1 * dados.v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultadoMultiplicacao}");
        }

        static void Divisao()
        {
            var dados = ObterDados();
            if (dados.v2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
                return;
            }
            
            var resultadoDivisao = dados.v1 / dados.v2;
            Console.WriteLine($"O resultado da divisão é: {resultadoDivisao}");
        }

        static void Potencia()
        {
            var dados = ObterDados();

            var resultadoPotencia = Math.Pow(dados.v1, dados.v2);
            Console.WriteLine($"O resultado do calculode de potencia é: {resultadoPotencia}"); 
        }
    }
}
