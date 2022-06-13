namespace ConsoleDrawer
{
    public class Dibujo
    {
        private Lista<IFigura> aFiguras;

        public Dibujo()
        {
            aFiguras = new Lista<IFigura>(10);
            aFiguras.Add(new Texto(10, 5, "Hola a Todes"));
            aFiguras.Add(new Cuadrado(2,10));
        }

        public void Dibujar()
        {
            foreach(var aFigura in aFiguras)
            {
                aFigura?.Dibujar();
            }
        }
    }

}