using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    class PessoaMap : ClassMap<Pessoa>
    {
        public PessoaMap()
        {
            Table("PESSOA");

            Id(x => x.CPF, "CPF").Not.Nullable().Unique();

            Map(x => x.Nome, "NOME").Length(50).Not.Nullable();
            Map(x => x.DataNascimento).Not.Nullable();
            Map(x => x.Sexo).Not.Nullable();

            HasManyToMany(x => x.CPF)
           .Cascade.All()
           .Table("CONVIDADOS");
        }
    }
}
