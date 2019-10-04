using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2019, 09, 27);
            Festa festa = new Festa(data.Date, "Festa1", 125.87);
            ConvidadoCortesia convidadoCortesia = new ConvidadoCortesia("", "75095783.1", new DateTime(1996,1,1), (EnumSexo)4);
            ConvidadoNormal convidadoNormal = new ConvidadoNormal("João Normal", "75097843191", DateTime.Now, EnumSexo.Masculino);
            ConvidadoVIP convidadoVIP = new ConvidadoVIP("João Vip", "75097843191", DateTime.Now, EnumSexo.Masculino);
            ConvidadoNormal convidadoNormal2 = new ConvidadoNormal("Maria Normal", "75097843191", DateTime.Now, EnumSexo.Feminino);
            ConvidadoVIP convidadoVIP2 = new ConvidadoVIP("Maria Vip", "75097843191", DateTime.Now, EnumSexo.Feminino);

            festa.AdicionarConvidado(convidadoCortesia);
            festa.AdicionarConvidado(convidadoNormal);
            festa.AdicionarConvidado(convidadoVIP);
            festa.AdicionarConvidado(convidadoNormal2);
            festa.AdicionarConvidado(convidadoVIP2);

            Console.WriteLine(String.Format("Nome da Festa: {0}\nData: {1}\nValor Ingresso: R$ {2}\n", festa.Nome, festa.Data, festa.ValorIngresso).ToString());
            Console.Write(festa.ListaDeConvidados());
            Console.WriteLine("Total de Convidados: " + festa.TotalConvidados().ToString() + "\n");
            Console.WriteLine("Percentual de Homens: "+ festa.PorcentagemDeHomens().ToString() + "%\n");
            Console.WriteLine("Percentual de Mulheres: " + festa.PorcentagemDeMulheres().ToString() + "%\n");
            Console.WriteLine("Percentual de Convidados Cortesia: " + festa.PorcentagemConvidadosCortesia().ToString() + "%\n");
            Console.WriteLine("Valor Total Pago: R$ " + festa.CalculaValorTotalPago().ToString("F") + "\n");

            //Console.WriteLine("Converter Convidado");
            //var novoConvidado = new Conversor<ConvidadoNormal, ConvidadoVIP>().Converta(convidadoNormal);
            //Console.WriteLine(novoConvidado.ToString());

            var validadorDeConvidado = new ValidadorDeConvidado<Convidado>();

            validadorDeConvidado.Valide(convidadoCortesia);
            


            //Console.WriteLine(ValidadorDeConvidado<Convidado>.ValidaSexo((EnumSexo)1)); 
        }
    }
}
