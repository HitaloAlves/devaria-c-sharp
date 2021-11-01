using System;

namespace TesteVarConst
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constante = "uma constate que não muda";

            if (args.Length == 0)
            {
                Console.WriteLine("Por favor, informe um número");
                return;
            }

            int inteiro;
            bool teste = int.TryParse(args[0], out inteiro);

            if (teste == false)
            {
                Console.WriteLine("O argumento informado não é inteiro");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi: " + inteiro);
        }
    }
}
