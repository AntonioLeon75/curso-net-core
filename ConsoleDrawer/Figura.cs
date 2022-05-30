namespace ConsoleDrawer
{
    public abstract class Figura : IFigura
    {
        public Posicion Pos{ get;}

        public Figura(int aFila, int aColumna)
        {
            Pos = new Posicion(aFila, aColumna);
        }

        public abstract void Dibujar();
    }
}