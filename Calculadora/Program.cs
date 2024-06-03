using System;

namespace Calculadora
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Exibe um menu para o usuário escolher a operação desejada
            Console.WriteLine("Escolha a operação: 1-Somar, 2-Subtrair, 3-Multiplicar, 4-Dividir");

            // Lê a escolha da operação do usuário  
            int operacao = int.Parse(Console.ReadLine());

            // Solicita os dois números
            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            // Variável para armazenar o resultado da operação
            double resultado = operacao switch
            {
                // Executa operação com base na escolha
                1 => Somar(num1, num2),
                2 => Subtrair(num1, num2),
                3 => Multiplicar(num1, num2),
                4 => Dividir(num1, num2),
                _ => throw new ArgumentException("Operação inválida")
            };

            // Exibe o resultado da operação
            Console.WriteLine($"Resultado: {resultado}");
        }

        // Métodos com as operações básicas
        public static double Somar(double a, double b) => a + b;
        public static double Subtrair(double a, double b) => a - b;
        public static double Multiplicar(double a, double b) => a * b;
        public static double Dividir(double a, double b)
        {
            // Verifica se o divisor é zero e lança uma exceção se for
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");

            // Realiza a divisão
            return a / b;
        }
    }
}
