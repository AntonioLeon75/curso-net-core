namespace ConsoleDrawer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Nuevo dibujo");
            Console.WriteLine("2 - Salir");

            bool opcion;
            do
            {
                opcion = DrawMenu();
            }
            while(!opcion);
        }

        static bool DrawMenu()
        {
            ConsoleKeyInfo info = Console.ReadKey();
            if(info.KeyChar == '1')
            {
                Dibujo aDibujo = new Dibujo();
                aDibujo.Dibujar();
                Console.Read();
                return true;
            }
            else if(info.KeyChar == '2')
            {
                return true;
            }
            else
            {
                Console.WriteLine("Seleccione 1 ó 2");
                return false;
            }
        }
    }
}