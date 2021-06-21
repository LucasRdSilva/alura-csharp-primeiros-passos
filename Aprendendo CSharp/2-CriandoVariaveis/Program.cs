using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade);


            Console.WriteLine("Execução Finalizada. Tecle ENTER para sair. . . ");
            Console.ReadLine();
        }
    }
}
