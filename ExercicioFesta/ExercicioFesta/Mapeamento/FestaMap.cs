using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace ExercicioFesta
{
    public class FestaMap : ClassMap<Festa>
    {
        public FestaMap()
        {
            Table("FESTA");

            Id(x => x.Id, "ID").GeneratedBy.Guid();

            Map(x => x.Nome, "NOME").Length(50).Not.Nullable();
            Map(x => x.Data, "DATA").Not.Nullable();
            Map(x => x.ValorIngresso, "VALORINGRESSO").Not.Nullable();

            HasMany(x => x.ListaDeConvidados).KeyColumn("Convidados").Cascade.AllDeleteOrphan();

            HasManyToMany(x => x.Id)
           .Cascade.All()
           .Table("CONVIDADOS");
        }        
    }
}
