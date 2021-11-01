using System;

namespace Calculadora
{
    class Program
    {
        static float RealizarOperacao(float primeiroNum, float segundoNum, string operador)
        {
            switch (operador)
            {
                case "+": return primeiroNum + segundoNum;
                case "-": return primeiroNum - segundoNum;
                case "*": return primeiroNum * segundoNum;
                case "/": return primeiroNum / segundoNum;
                case "%": return primeiroNum % segundoNum;
                default: return 0f;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero: ");
            var primeiroNumString = Console.ReadLine();
            float primeiroNum;

            bool isPrimeiroNumValido = float.TryParse(primeiroNumString, out primeiroNum);

            if (!isPrimeiroNumValido)
            {
                Console.WriteLine("Primeiro Número Invalido");
                return;
            }

            Console.WriteLine("Informe outro numero: ");
            var segundoNumString = Console.ReadLine();
            float segundoNum;

            bool isSegundoNumValido = float.TryParse(segundoNumString, out segundoNum);

            if (!isSegundoNumValido)
            {
                Console.WriteLine("Segundo Número Invalido");
                return;
            }

            Console.WriteLine("Informe o operador: ");
            var operador = Console.ReadLine();

            var resultado = RealizarOperacao(primeiroNum, segundoNum, operador);
            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}
