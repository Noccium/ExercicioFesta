using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    public class Conversor<T, T2>
        where T : Convidado 
        where T2 : Convidado
    {
        public T2 Converta(T convidado)
        {
            var convidado2 = Activator.CreateInstance<T2>();

            if (convidado == null)
            {
                return null;
            } else
            {
                convidado2.CPF = convidado.CPF;
                convidado2.DataNascimento = convidado.DataNascimento;
                convidado2.Nome = convidado.Nome;
                convidado2.Sexo = convidado.Sexo;  
                return convidado2;
            }
        }

        public ListaDeConvidados<T2> Converta(ListaDeConvidados<T> lista)
        {
            return null;
        }

    }
}
