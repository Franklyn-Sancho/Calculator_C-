using System;

namespace Aula{
    class program{
        static void Main(string[] args)
        {
            double num1, num2;

            string tmp;

            Console.WriteLine("Digite um número: ");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite mais um número: ");
            Console.ReadLine();
            num2 = int.Parse(tmp);

            double resultado;

            //realiza a soma e imprime no console
            resultado = num1 + num2;
            Console.WriteLine("SOma: " + resultado);

            //realiza a subtração e imprime no console
            resultado = num1 - num2;
            Console.WriteLine("Subtração: " + resultado);

            //realiza a multiplicação e imprime
            resultado = num1 * num2;
            Console.WriteLine("Multiplização: " + resultado);

            //realiza a divisão e imprime 
            resultado = num1 / num2;
            Console.WriteLine("Divisão: " + resultado);
        }
    }
}