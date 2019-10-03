using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioFesta
{
    public class ListaDeConvidados<T> : ICustomList<T> where T : Convidado
    {
        private List<T> _lista;

        public T this[int index] => _lista[index];

        public int Count => _lista.Count;

        public object Current => throw new NotImplementedException();

        public void Add(T item)
        {
            _lista.Add(item);
        }

        public bool All(Predicate<T> condicao)
        {
            foreach (var item in _lista)
            {
                if (condicao(item) == false)
                    return false;
            }
            return true;
        } 

        public bool Any(Predicate<T> condicao)
        {
            foreach (var item in _lista)
            {
                if (condicao(item) == true)
                    return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _lista.GetEnumerator();
        }

        public ICustomList<T> Where(Predicate<T> condicao)
        {
            ListaDeConvidados<T> lista = new ListaDeConvidados<T>();
            foreach (T item in _lista)
            {
                if (condicao(item) == true)
                    lista.Add(item);
            }
            return lista;
        }
    }
}
