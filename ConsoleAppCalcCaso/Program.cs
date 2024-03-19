using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalcCaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma operação[*,-,/,+]:");
            string oper= Console.ReadLine();

            Console.Write("Escolha um número:");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Escolha outro número: ");
            double n2 = double.Parse(Console.ReadLine());

            switch (oper)
            {
                case "*" :
                    double result = n1 * n2;
                    Console.Write("O resultado é: " + result); 
                    break;
                case "+":
                    result = n1 + n2;
                    Console.Write("O resultado é: " + result);
                    break;
                case "-":
                    result = n1 - n2;
                    Console.Write("O resultado é: " + result);
                    break;
                case "/":
                    result = n1 / n2;
                    Console.Write("O resultado é: " + result);
                    break;
                default:
                    Console.Write("Opção inválida");
                    break;
            }
                Console.ReadKey();
            }

        }
    }

