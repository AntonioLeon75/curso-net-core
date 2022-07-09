namespace ConsoleDrawer
{
    public class FiguraFactory
    {
        private static FiguraFactory _instance;
        private int numCuadrados;
        private int numTextos;

        public static FiguraFactory Instance
        {
            get{ return _instance; }
        }

        static FiguraFactory()
        {
            _instance = new FiguraFactory();
        }
        
        private FiguraFactory()
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