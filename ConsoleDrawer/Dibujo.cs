namespace ConsoleDrawer
{
    public class Dibujo
    {
        private Figura[] aFiguras;

        public Dibujo()
        {
            aFiguras = new Figura[10];
            aFiguras[0] = new Texto(10, 5, "Hola a Todes");
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