using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    public interface ICustomList<T> : IEnumerable
    {
        void Add(T item);
        T this[int index] { get; }
        bool All(Predicate<T> condicao);
        bool Any(Predicate<T> condicao);

        ICustomList<T> Where(Predicate<T> condicao);

        int Count { get;  }
    }
}
