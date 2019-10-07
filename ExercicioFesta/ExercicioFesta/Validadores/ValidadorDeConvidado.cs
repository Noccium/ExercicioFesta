using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    public class ValidadorDeConvidado<TConvidado> : AbstractValidator<Convidado> where TConvidado : Convidado
    {
        public ValidadorDeConvidado()
        {
            RuleFor(convidado => convidado.Nome).ValidaNome();

            RuleFor(convidado => convidado.DataNascimento).ValidaIdade();

            RuleFor(convidado => convidado.CPF).ValidaCPF();

            RuleFor(convidado => convidado.Sexo).ValidaSexo();
        }

       public void Valide(Convidado convidado) 
        {
            var validadorDeConvidado = new ValidadorDeConvidado<Convidado>();

            var resultado = validadorDeConvidado.Validate(convidado);

            foreach (var erro in resultado.Errors)
            {
                Console.WriteLine("MSG: " + erro.ErrorMessage);
                Console.WriteLine("PROP: " + erro.PropertyName);
                Console.WriteLine();
            }
        }
    }
}
