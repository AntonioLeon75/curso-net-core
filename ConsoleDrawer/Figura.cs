namespace ConsoleDrawer
{
    public abstract class Figura : IFigura
    {
        public Posicion Pos{ get;}

        public string Name{ get;}

        public Figura(string name, int aFila, int aColumna)
        {
            Name = name;
            Pos = new Posicion(aFila, aColumna);
        }

        public abstract void Dibujar();
    }
}