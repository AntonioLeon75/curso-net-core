using Newtonsoft.Json;

namespace ConsoleDrawer
{
    public class Dibujo
    {
        private readonly List<IFigura> _figuras;

        public Dibujo()
        {
            _figuras = new List<IFigura>(10);

            // Demostración de método indizador
            //var figura = _figuras[0];

            // Métodos de extensión
            //_figuras.GetFirst()?.Dibujar();

            var isnum = StringUtils.IsNumber("3423d4");
            isnum = "3423d4".IsNumber();
            //-------------------------------------------------

            /* Código utilizado para ver delegados que no se sigue usando en el curso
                        var listaInt = new Lista<int>(10);
                        listaInt.Add(1);
                        listaInt.Add(2);
                        listaInt.Add(3);
                        listaInt.Add(5);
                        listaInt.Add(6);

                        //var odds = listaInt.FindPredicate(new PredicateIntOdd());

                        PredicateDelegate<int> p = delegate (int i) { return i % 2 == 0 ;};

                        PredicateDelegate<int> p2 = i => i % 2 == 0;

                        //var odds = listaInt.SearchByDelegate(delegate (int i) { return i % 2 == 0; });
                        var odds = listaInt.SearchByDelegate( i => i % 2 == 0 );

                        //Delegado genérico Func
                        Func<int, bool> func = i => i % 2 == 0;
                        odds = listaInt.SearchByDelegate( func );

                        var biggerThanThree = listaInt.SearchByDelegate( i => i > 3 );
            */
        }

        public IFigura this[string name]
        {
            get
            {
                return _figuras.FirstOrDefault(x => x.Name == name);
            }
        }

        public IEnumerable<string> Names
        {
            get
            {
                return _figuras
                .Select(f => f.Name)
                .OrderBy(n => n);
            }
        }

        public IEnumerable<IFigura> Figuras
        {
            get
            {
                return _figuras;
            }
        }

        public (string city, Type tipo) GetTupla()
        {
            return ("Toledo", typeof(string));
        }

        public IEnumerable<(string name, Type tipo)> GetFiguraInfo()
        {
            foreach(var figura in _figuras)
            {
                yield return (figura.Name, figura.GetType());
            }
        }

        public T? GetByName<T>(string name)
            where T : class, IFigura
        {
            return this[name] as T;
        }

        public void AddFigura(IFigura figura)
        {
            _figuras.Add(figura);
        }
        public void Dibujar()
        {
            foreach (var aFigura in _figuras)
            {
                aFigura?.Dibujar();
            }
        }

        public void Save(string path)
        {
            var cuadrados = _figuras.OfType<Cuadrado>();
            var textos = _figuras.OfType<Texto>();

            var resultado = new {
                Cuadrados = cuadrados,
                Textos = textos,
                Count = _figuras.Count()
            };

            var json = JsonConvert.SerializeObject(resultado);
            File.WriteAllText(path, json);
        }
    }

}