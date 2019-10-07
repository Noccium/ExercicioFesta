using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFesta
{
    public class Festa
    {
        public string Id;
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public double ValorIngresso { get; set; }
        public List<Convidado> ListaDeConvidados { get; set; }
        //private ListaDeConvidados<Convidado> ListaDeConvidados { get; set; }

        public Festa(DateTime data, string nome, double valorIngresso)
        {
            Data = data;
            Nome = nome;
            ValorIngresso = valorIngresso;
            ListaDeConvidados = new List<Convidado>();
        }

        public void AdicionarConvidado(Convidado convidado)
        {
            ListaDeConvidados.Add(convidado);
        }

        public double TotalConvidados()
        {
            return ListaDeConvidados.Count();
        }

        public double PorcentagemDeHomens()
        {
            return ( ListaDeConvidados.Where(x => x.Sexo == EnumSexo.Masculino).Count() / TotalConvidados() ) * 100;
        }

        public double PorcentagemDeMulheres()
        {
            return (ListaDeConvidados.Where(x => x.Sexo == EnumSexo.Feminino).Count() / TotalConvidados() ) * 100;
        }

        public double PorcentagemConvidadosCortesia()
        {
            return ( ListaDeConvidados.Where(x => x.GetType() == typeof(ConvidadoCortesia)).Count() / TotalConvidados() ) * 100;
        }

        public string TotalDeConvidados()
        {
            StringBuilder listaDeConvidados = new StringBuilder();
            listaDeConvidados.AppendLine("- Lista de Convidados -\n");
            ListaDeConvidados.ForEach(convidado => listaDeConvidados.AppendLine(
                String.Format(
                    "Tipo : {0}\nNome: {1}\nSexo: {2}\nCPF: {3}\nData Nascimento: {4}\n",
                    convidado, convidado.Nome, convidado.Sexo, convidado.CPF, convidado.DataNascimento)
                ));
            return listaDeConvidados.ToString();
        }

        public double CalculaValorTotalPago()
        {
            return ListaDeConvidados.Sum(x => x.CalculaValorIngresso(ValorIngresso));
        }
    }
}
