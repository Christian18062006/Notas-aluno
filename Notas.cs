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
        public string nome = string.Empty;
        public double calculaNota()
        {
            double notaFinal = (nota1 * 3.0 + nota2 * 3.5 + nota3 * 3.5) / (3.0 + 3.5 + 3.5);
            return (notaFinal);
        }
    }
}
