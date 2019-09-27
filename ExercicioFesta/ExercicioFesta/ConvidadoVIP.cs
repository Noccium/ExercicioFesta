using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFesta
{
    class ConvidadoVIP : Convidado
    {
        public ConvidadoVIP(string nome, string cpf, DateTime dataNascimento, EnumSexo sexo) :
            base(nome, cpf, dataNascimento, sexo)
        {
        }

        public override double CalculaValorIngresso(double valorIngresso)
        {
            if (Sexo == EnumSexo.Masculino)
            {
                return valorIngresso -= 0.1 * valorIngresso;
            } else if (Sexo == EnumSexo.Feminino)
            {
                return valorIngresso -= 0.2 * valorIngresso;
            } else
            {
                throw new ArgumentException("Sexo inválido!");
            }
            
        }
    }
}
