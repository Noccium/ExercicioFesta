﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFesta
{
    public class Festa
    {
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public double ValorIngresso { get; set; }
        private static List<Convidado> _listaDeConvidados { get; set; }

        public Festa(DateTime data, string nome, double valorIngresso)
        {
            Data = data;
            Nome = nome;
            ValorIngresso = valorIngresso;
            _listaDeConvidados = new List<Convidado>();
        }

        public void AdicionarConvidado(Convidado convidado)
        {
            _listaDeConvidados.Add(convidado);
        }

        public double TotalConvidados()
        {
            double total = 0;
            foreach (var c in _listaDeConvidados)
            {
                total++;
            }
            return total;
        }

        public double PorcentagemDeHomens()
        {
            int totalHomens = 0;
            foreach (var c in _listaDeConvidados)
            {
                if (c.Sexo == EnumSexo.Masculino) totalHomens++;
            }
            //_listaDeConvidados.ForEach(x => {});
            return (totalHomens / TotalConvidados()) * 100;
        }

        public double PorcentagemDeMulheres()
        {
            int totalMulheres = 0;          
            foreach (var c in _listaDeConvidados)
            {
                if (c.Sexo == EnumSexo.Feminino) totalMulheres++;
            }

            //_listaDeConvidados.ForEach(x => {});
            return (totalMulheres / TotalConvidados()) * 100;
        }

        public double PorcentagemConvidadosCortesia()
        {
            int totalConvidadosCortesia = 0;

            foreach(var convidado in _listaDeConvidados)
            {
                if (convidado.GetType() == (typeof(ConvidadoCortesia)))
                {
                    totalConvidadosCortesia++;
                }
            } 
            return (totalConvidadosCortesia / TotalConvidados()) * 100;
        }

        public string ListaDeConvidados()
        {
            StringBuilder listaDeConvidados = new StringBuilder();
            listaDeConvidados.AppendLine("- Lista de Convidados -\n");

            foreach (var convidado in _listaDeConvidados)
            {
                listaDeConvidados.AppendLine(String.Format(
                    "Tipo : {0}\nNome: {1}\nSexo: {2}\nCPF: {3}\nData Nascimento: {4}\n", 
                    convidado, convidado.Nome, convidado.Sexo, convidado.CPF, convidado.DataNascimento)
                );
            }
            
            return listaDeConvidados.ToString();
        }

        public double CalculaValorTotalPago()
        {
            double valorTotalPago = 0;
            foreach (var convidado in _listaDeConvidados)
            {
                valorTotalPago += convidado.CalculaValorIngresso(ValorIngresso);
            }
            return valorTotalPago;
        }
    }
}
