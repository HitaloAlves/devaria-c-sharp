using System;

namespace ListaDeConvidados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado: ");
            var nome = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("O nome não foi informado");
                return;
            }

            Console.WriteLine("Informe a idade do convidado: ");

            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);
            if(idadeInformada == false)
            {
                Console.WriteLine("Idade informada não é valida");
                return;
            }

            bool estaConvidado;
            switch (nome)
            {
                case "Hitalo":
                    estaConvidado = true;
                    break;
                case "Daniel":
                        estaConvidado = true;
                    break;
                case "Jose":
                    estaConvidado = true;
                    break;
                case "Mateus":
                        estaConvidado = true;
                    break;
                case "Bento":
                        estaConvidado = true;
                    break;
                case "Gabriela":
                        estaConvidado = true;
                    break;
                case "Fernanda":
                    estaConvidado = true;
                    break;
                case "Bianca":
                    estaConvidado = true;
                    break;
                default:
                    estaConvidado = false;
                    break;
            }

            if(estaConvidado == true && idade > 18)
            {
                Console.WriteLine("Seja Bem vindo(a) a festa !");
            }else if(estaConvidado == false)
            {
                Console.WriteLine("O seu nome não esta na lista, por favor, verifique com a pessoa que te convidou");
            }
            else
            {
                Console.WriteLine("Você não tem 18 anos para entrar na festa");
            }
        }
    }
}
