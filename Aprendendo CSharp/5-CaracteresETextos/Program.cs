using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            // character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            //Tabela ASCII
            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            //Concatenação
            string titulo = "Alura Cursos de Tecnologia " + 2021;
            string cursosProgramacao = @" - .NET
 - Java
 - Javascript";

//@" - .NET
//- Java
//- Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();
        }
    }
}
