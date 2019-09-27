using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFesta
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnumSexo Sexo { get; set; }

        public Pessoa(string nome, string cpf, DateTime dataNascimento, EnumSexo sexo)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Sexo = sexo;
        }
    }
}
