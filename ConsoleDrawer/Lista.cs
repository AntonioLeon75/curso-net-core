namespace ConsoleDrawer
{

  /*   public class Lista<T>
    {
        private readonly Lista _lista;

        public int Count
        {
            get
            {
                return _lista.Count;
            }
        }

        public Lista(int limit)
        {
            _lista = new Lista(limit, typeof(T));
        }

        public T GetAt(int idx)
        {
            return (T)_lista.GetAt(idx);
        }

        public void Add(T item)
        {
            _lista.Add(item);
        }


    } */


/*     public class Lista
    {
        private readonly object[] _items;
        private readonly Type _type;
        public int Count { get; private set; }
        public Lista(int limit, Type type)
        {
            _items = new object[limit];
            Count = 0;
            _type = type;
        }

        public void Add(object item)
        {
            if (item.GetType().IsAssignableFrom(_type))
            {
                throw new ArgumentException("Tipo " + item.GetType().Name + " no es válido");
            }

            if (Count == _items.Length)
            {
                throw new System.InvalidOperationException("Lista llena!!");
            }

            _items[Count] = item;
            Count++;
        }

        public object GetAt(int idx)
        {
            return _items[idx];
        }
    }
 */
      public class Lista<T>
    {
        private readonly T[] _items;
        public int Count {get; private set;}
        public Lista( int limit )
        {
            _items = new T[limit];
            Count = 0;
        }

        public void Add(T item)
        {
            if(Count == _items.Length)
            {
                throw new System.InvalidOperationException("Lista llena!!");
            }
            
            _items[Count] = item;
            Count++;   
        }    

        public T GetAt(int idx)
        {
            return _items[idx];
        }
    }
   
}