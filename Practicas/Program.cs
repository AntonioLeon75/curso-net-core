namespace Practicas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            GestorPracticas gestorPracticas = new GestorPracticas();
            
            while( !exit )
            {
                Console.WriteLine("0 - Salir");
                Console.WriteLine("1 - Uso de yield");
                Console.WriteLine("2 - Uso de delegados");
                
                var option = Console.ReadLine();

                switch( option )
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        Console.WriteLine("Vamos a ver yield");
                        gestorPracticas.ExecuteYield();
                        break;
                    case "2":
                        Console.WriteLine("Vamos a ver delegados");
                        gestorPracticas.ExecuteDelegados();
                        break;                        
                }
            }
        }
    }
}