namespace ConsoleDrawer
{
    public class Texto : Figura
    {
        private readonly string theText;

        public Texto( int aFila, int aColumna, string aText) : base (aFila, aColumna)
        {
            theText = aText;

        }
        public override void Dibujar()
        {
            Console.SetCursorPosition(Pos.Columna, Pos.Fila);
            Console.Write(theText);
        }

    }
}