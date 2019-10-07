using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFesta
{
    public abstract class Convidado : Pessoa
    {
        public Convidado(string nome, string cpf, DateTime dataNascimento, EnumSexo sexo) : 
            base(nome, cpf, dataNascimento, sexo)
        {
        }
        public abstract double CalculaValorIngresso(double valorIngresso);
    }
}
