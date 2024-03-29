﻿using System;

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
            bool passou = verificaAprovacao(notaFinal);
            if (passou)
            {
                Console.WriteLine("A provado!");
            }
            else
            {
                double pontosFinal = Math.Abs(notaFinal - 60);
                Console.WriteLine($"você precisa de {pontosFinal.ToString("F2")} pra ser aprovado.");
            }
            //usando a classe//
            Notas aluno1 = new Notas();
            aluno1.nome = nomeAluno;
            aluno1.nota1 = nota1;
            aluno1.nota2=nota2;
            aluno1.nota3=nota3;
            double calculoNota1 = aluno1.calculaNota();
            Console.WriteLine($"nota final: {calculoNota1}");
            bool aprovado = aluno1.verificaAprovacao();
            if (aprovado)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                double pontosFalta = Math.Abs(calculoNota1 - 60);
                Console.WriteLine($"Você precisa de {pontosFalta.ToString("F2")} para ser aprovado.");
            }
                    }
    }
}
