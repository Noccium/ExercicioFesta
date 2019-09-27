using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFesta
{
    class ConvidadoNormal : Convidado
    {
        public ConvidadoNormal(string nome, string cpf, DateTime dataNascimento, EnumSexo sexo) :
            base(nome, cpf, dataNascimento, sexo)
        {
        }

        public override double CalculaValorIngresso(double valorIngresso)
        {
            return valorIngresso;
        }

        public override string ToString()
        {
            return "ConvidadoNormal";
        }
    }
}
