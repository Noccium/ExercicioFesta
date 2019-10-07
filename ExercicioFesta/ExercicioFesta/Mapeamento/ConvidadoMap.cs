using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    public class ConvidadoMap : ClassMap<Convidado>
    {
        public ConvidadoMap()
        {
            Table("CONVIDADOS");
            HasMany(x => x.ListaDeFestas).KeyColumn("ID_FESTA").Cascade.AllDeleteOrphan();
            References(x => x.CPF).Column("CPF_CONVIDADO").Cascade.All();
        }
    }
}
