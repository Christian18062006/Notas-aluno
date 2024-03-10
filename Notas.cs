using System;
using System.Collections.Generic;
using System.Text;

namespace AlunoNotas
{
    class Notas
    {
        public double nota1;
        public double nota2;
        public double nota3;
        double notaFinal;
        public string nome = string.Empty;
        public double calculaNota()
        {
           notaFinal = (nota1 * 3.0 + nota2 * 3.5 + nota3 * 3.5) / (3.0 + 3.5 + 3.5);
            return (notaFinal);
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
