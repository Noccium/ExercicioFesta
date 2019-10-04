using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    //static
    public static class ValidadorDeConvidadoExtensions
    {
        public static IRuleBuilderOptions<T, DateTime> IdadeValida<T>(this IRuleBuilder<T, DateTime> ruleBuilder, int idadeMinima) where T : Convidado
        {
            return ruleBuilder.Must(x => MaiorQue18Anos(x, idadeMinima));
        }

        public static IRuleBuilderOptions<T, String> CPFValida<T>(this IRuleBuilder<T, String> ruleBuilder) where T : Convidado
        {
            return ruleBuilder.Must(ValidaDigito);
        }

        public static IRuleBuilderOptions<T, EnumSexo> SexoValida<T>(this IRuleBuilder<T, EnumSexo> ruleBuilder) where T : Convidado
        {
            return ruleBuilder.Must(ValidaSexo);
        }

        private static bool MaiorQue18Anos(DateTime dataDeNascimento, int idadeMinima)
        {
            return dataDeNascimento.Year - DateTime.Now.Year >= idadeMinima;
        }

        private static bool ValidaDigito(String digito)
        {
            return digito.All(x => char.IsDigit(x));
        }

        private static bool ValidaSexo(EnumSexo enumSexo)
        {
            return Enum.IsDefined(typeof(EnumSexo), enumSexo);
            //return string.Equals(enumSexo.ToString(), "masculino", StringComparison.OrdinalIgnoreCase) ;
        }

    }
}
