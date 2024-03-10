using System;

namespace AlunoNotas
{
    class Program
    {
        public static double calculaNota(double nota1, double nota2, double nota3)
        {
            double notaFinal = (nota1 * 3.0 + nota2 * 3.5 + nota3 * 3.5) / (3.0+3.5+3.5);
            return (notaFinal);

        }
        public static bool verificaAprovacao(double notaFinal)
        {
            if (notaFinal>=60)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
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
            notaFinal = calculaNota(nota1, nota2, nota3);
            Console.WriteLine($"A nota final é :{notaFinal}");

        }
    }
}
