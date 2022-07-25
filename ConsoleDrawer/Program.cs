namespace ConsoleDrawer
{
    class X
    {
        public void Test()
        {
            Console.WriteLine("Test en X");
        }
    }

    class Program
    {
        static void Foo(dynamic bar)
        {
            bar.Test();
        }


        static void Main(string[] args)
        {
            Foo(new X());

            Console.WriteLine("1 - Nuevo dibujo");
            Console.WriteLine("2 - Salir");

            bool opcion;
            do
            {
                opcion = DrawMenu();
            }
            while (!opcion);
        }

        static bool DrawMenu()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            if (info.KeyChar == '1')
            {
                Dibujo aDibujo = new Dibujo();

                aDibujo.AddFigura(FiguraFactory.Instance.GetTexto("Ay TUUUUUU", 10, 10));
                aDibujo.AddFigura(FiguraFactory.Instance.GetCuadrado(1, 3));

                var f = aDibujo.Figuras.First();

                Evaluar(f);

                var ciudad = aDibujo.GetTupla().city;

                var (miCiudad, _) = aDibujo.GetTupla();

                var name = aDibujo.GetFiguraInfo().First().name;

                aDibujo.Save(@"C:\sandbox\curso-dotnet-core\ConsoleDrawer\Dibujo.txt");

                var s = aDibujo.Names;
                var s2 = aDibujo.Figuras;

                var test = aDibujo["Texto 0"];

                aDibujo.GetByName<Cuadrado>("Cuadrado 0");

                aDibujo.Dibujar();
                Console.Read();
                return true;
            }
            else if (info.KeyChar == '2')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Seleccione 1 ó 2");
                return false;
            }
        }

        private static void Evaluar(IFigura figura)
        {
            switch (figura)
            {
                case Texto t:
                    Console.WriteLine($"Es un texto con mensaje {t.Text}");
                    break;
                case Cuadrado c when c.Lado == 0:
                    Console.WriteLine("Es un cuadrado invisible");
                    break;
                case Cuadrado c:
                    Console.WriteLine($"Es un cuadrado invisible de lado {c.Lado}");
                    break;                    
            }
        }
    }
}