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

            var lista2 = new Lista<Texto>(10);
            //Foo2(lista2);

            Foo(lista2);
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