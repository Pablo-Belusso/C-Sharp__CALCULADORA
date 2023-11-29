using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação você deseja fazer: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            Console.ReadLine();

            int operação = int.Parse(Console.ReadLine()); // Converter o número digitado para inteiro
            
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = num1 + num2;
                        break;
                    }
            }
        }

        public static int Adicao (int numero1, int numero2) {

            int result = numero1 + numero2;
            return result;
        }

    }
}
