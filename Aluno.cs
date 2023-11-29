using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_classe3_aluno
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double somatoria;

        public double SomaNota()
        {
            somatoria = Nota1 + Nota2 + Nota3;
            return somatoria;
        }

        public string Aprovacao()
        {
            if (SomaNota() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                double total = 60 - somatoria;
                Console.WriteLine("FALTARAM: " + total + " PONTOS");
                return "REPROVADO";
            }
        }
    }
}
