using System;
using System.Collections.Generic;
using System.Text;

namespace AlunoNotas
{
    class AlunosNota
    {
        public string nome = string.Empty;
        public double nota1, nota2, nota3, notaFinal;
public double calculaNota()
        {
            notaFinal = (nota1 * 3.0 + nota2 * 3.5 + nota3 * 3.5) / (3.0 + 3.5 + 3.5);
        }
        public bool verificaAprovacao()
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
    }
}
