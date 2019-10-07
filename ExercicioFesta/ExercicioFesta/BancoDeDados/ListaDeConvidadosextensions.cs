using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    public static class ListaDeConvidadosExtensions
    {
        public static ListaDeConvidados<T> ToListaDeConvidados<T>(this IEnumerable<T> lista) where T : Convidado
        {
            var listaDeConvidados = new ListaDeConvidados<T>();
            foreach (var item in lista)
            {
                listaDeConvidados.Add(item);
            }
            return listaDeConvidados;
        }
    }
}
