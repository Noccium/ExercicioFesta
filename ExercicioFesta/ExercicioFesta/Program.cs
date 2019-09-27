using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFesta
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime();
            Festa festa = new Festa(data, "Festa1", 125.87);
            ConvidadoCortesia convidadoCortesia = new ConvidadoCortesia("João Cortesia", "75097843191", DateTime.Now, EnumSexo.Masculino);
            ConvidadoNormal convidadoNormal = new ConvidadoNormal("João Normal", "75097843191", DateTime.Now, EnumSexo.Masculino);
            ConvidadoVIP convidadoVIP = new ConvidadoVIP("João Vip", "75097843191", DateTime.Now, EnumSexo.Masculino);

            festa.AdicionarConvidado(convidadoCortesia);
            festa.AdicionarConvidado(convidadoNormal);
            festa.AdicionarConvidado(convidadoVIP);

            Console.Write(festa.ListaDeConvidados());
        }
    }
}
