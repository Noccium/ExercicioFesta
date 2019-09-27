using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFesta
{
    class ConvidadoCortesia : Convidado
    {
        public ConvidadoCortesia(string nome, string cpf, DateTime dataNascimento, EnumSexo sexo) :
            base(nome, cpf, dataNascimento, sexo)
        {
        }

        public override double CalculaValorIngresso(double valorIngresso)
        {
            return 0;
        }

        public override string ToString()
        {
            return "kkkkkk";
        }
    }
}
