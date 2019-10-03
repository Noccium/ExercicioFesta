using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    public class RelatorioDeConvidados<T> where T : Convidado
    {
        private ICustomList<T>  _listaDeConvidados;

        public RelatorioDeConvidados(ICustomList<T> listaDeConvidados)
        {
            _listaDeConvidados = listaDeConvidados;
        }
        public void Exiba()
        {
            var relatorio = new StringBuilder();
            foreach (var item in _listaDeConvidados)
            {
                relatorio.Append(item);
            }
            Console.WriteLine(relatorio);
        }
    }
}
