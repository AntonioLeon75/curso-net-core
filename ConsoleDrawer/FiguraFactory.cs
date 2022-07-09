namespace ConsoleDrawer
{
    public class FiguraFactory
    {
        private int numCuadrados;
        private int numTextos;

        public FiguraFactory()
        {
            numCuadrados = 0;
            numTextos = 0;
        }

        public Cuadrado GetCuadrado(int fila, int columna)
        {
            var cuadrado = new Cuadrado($"Cuadrado {numCuadrados}", fila, columna);
            numCuadrados++;
            return cuadrado;
        }

        public Texto GetTexto(string texto, int fila, int columna)
        {
            var textoFigura = new Texto($"Texto {numTextos}", fila, columna, texto);
            numTextos++;
            return textoFigura;
        }

    }
}