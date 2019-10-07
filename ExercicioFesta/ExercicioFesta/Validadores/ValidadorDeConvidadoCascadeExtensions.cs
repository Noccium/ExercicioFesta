using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    public static class ValidadorDeConvidadoCascadeExtensions
    {
        public static IRuleBuilderOptions<T, string> ValidaNome<T>(this IRuleBuilderInitial<T, string> ruleBuilder) where T : Convidado
        {
            return ruleBuilder.Cascade(CascadeMode.StopOnFirstFailure)
                                                .NotNull().WithMessage("Nome não pode ser nulo!")
                                                .NotEmpty().WithMessage("Nome não pode ser vazio!")
                                                .Length(0, 100).WithMessage("O Tamanho do Nome não pode ser maior que 100!");
        }

        public static IRuleBuilderOptions<T, DateTime> ValidaIdade<T>(this IRuleBuilderInitial<T, DateTime> ruleBuilder) where T : Convidado
        {
            return ruleBuilder.IdadeValida(18).WithMessage("Convidado deve ter idade maior que 18!");
        }

        public static IRuleBuilderOptions<T, string> ValidaCPF<T>(this IRuleBuilderInitial<T, string> ruleBuilder) where T : Convidado
        {
            return ruleBuilder.Cascade(CascadeMode.StopOnFirstFailure)
                                               .NotNull().WithMessage("CPF não pode ser nulo!")
                                               .NotEmpty().WithMessage("CPF não pode ser vazio!")
                                               .CPFValida().WithMessage("CPF deve conter apenas numeros!")
                                               .Length(0, 11).WithMessage("O Tamanho do CPF não pode ser maior que 11!");
        }

        public static IRuleBuilderOptions<T, EnumSexo> ValidaSexo<T>(this IRuleBuilderInitial<T, EnumSexo> ruleBuilder) where T : Convidado
        {
            return ruleBuilder.Cascade(CascadeMode.StopOnFirstFailure)
                                                .SexoValida().WithMessage("EnumSexo Invalido!");
        }
        

    }
}
