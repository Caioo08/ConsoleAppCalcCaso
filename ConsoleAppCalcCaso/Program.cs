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
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Escolha outro número: ");
            int n2 = int.Parse(Console.ReadLine());

            switch (oper)
            {
                case "*" :
                    int result = n1 * n2;
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

