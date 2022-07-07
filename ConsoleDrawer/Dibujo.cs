namespace ConsoleDrawer
{
    public class Dibujo
    {
        private List<IFigura> _figuras;

        public Dibujo()
        {
            _figuras = new List<IFigura>(10);
            _figuras.Add(new Texto(10, 5, "Hola a Todes"));
            _figuras.Add(new Cuadrado(2,10));

            var figura = _figuras[0];

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

        public void Dibujar()
        {
            foreach(var aFigura in _figuras)
            {
                aFigura?.Dibujar();
            }
        }
    }

}