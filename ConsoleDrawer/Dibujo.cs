namespace ConsoleDrawer
{
    public class Dibujo
    {
        private Lista<IFigura> _figuras;

        public Dibujo()
        {
            _figuras = new Lista<IFigura>(10);
            _figuras.Add(new Texto(10, 5, "Hola a Todes"));
            _figuras.Add(new Cuadrado(2,10));

            var listaInt = new Lista<int>(10);
            listaInt.Add(1);
            listaInt.Add(2);
            listaInt.Add(3);
            listaInt.Add(5);
            listaInt.Add(6);

            //var odds = listaInt.FindPredicate(new PredicateIntOdd());

            var odds = listaInt.SearchByDelegate(IsOdd);
        }

        private bool IsOdd(int num)
        {
            return num % 2 == 0;
        }

        public void Foo2(Lista<IFigura> figuras)
        {

        }

        public void Foo(IEnumerable<IFigura> figuras)
        {
            foreach(var f in figuras){}
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