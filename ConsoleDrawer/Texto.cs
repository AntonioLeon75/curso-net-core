namespace ConsoleDrawer
{
    public class Texto : Figura, IFigura
    {
        private readonly string theText;

        public string Text { get; }

        public Texto( string name, int aFila, int aColumna, string aText) : base (name, aFila, aColumna)
        {
            theText = aText;
            Text = aText;
        }
        public override void Dibujar()
        {
            Console.SetCursorPosition(Pos.Columna, Pos.Fila);
            Console.Write(Text);
        }
    }
}
