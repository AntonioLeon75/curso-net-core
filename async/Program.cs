namespace async
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");
            var i = Tarda();
            Console.WriteLine("Fin");

            i.ContinueWith(t =>
            {
                Console.WriteLine($"Resultado función asíncroma = {i.Result}");
            }
            );
            Console.WriteLine("Sigo ejecutando en paralelo a la tarea asíncrona");
            Console.ReadLine();
        }
        static Task<int> Tarda()
        {
            var t = Task.Factory.StartNew(() =>
            {
                for (var j = 0; j < 200; j++)
                {
                    for (var i = 0; i < 10000000; i++) ;
                }

                Console.WriteLine("+++Terminó Tarda");
                return 42;
            });

            return t;
        }
    }
}