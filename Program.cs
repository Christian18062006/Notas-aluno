using System;

namespace AlunoNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno = string.Empty;
            double nota1, nota2, nota3,notaFinal;
            Console.WriteLine("Aprovado ou reprovado?");
            Console.WriteLine("digite o nome do aluno.");
            nomeAluno = Console.ReadLine();
            Console.WriteLine("digite a nota do primeiro trimestre.");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a nota do segundo trimestre.");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a nota do terceiro trimestre.");
            nota3 = double.Parse(Console.ReadLine());
        }
    }
}
