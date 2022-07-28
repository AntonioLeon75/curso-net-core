namespace async
{
    class program2
    {
        static void Main2(string[] args)
        {
            //InvokeWithoutAwait();

            InvokeWithAwait();
        }

        public static async void InvokeWithAwait()
        {
            Console.WriteLine("+++++++ Ejecutando tarea asíncrona con Await +++++++");

            Console.WriteLine("Inicio");
            var r = await Tarda();
            Console.WriteLine("Sigo ejecutando en paralelo a la tarea asíncrona");
            Console.WriteLine($"Resultado función asíncroma = {r}");
            Console.WriteLine("Fin");

            Console.ReadLine();
        }

        static void InvokeWithoutAwait()
        {
            Console.WriteLine("+++++++ Ejecutando tarea asíncrona sin Await +++++++");

            Console.WriteLine("Inicio");
            var i = Tarda();
            Console.WriteLine("Fin");

            i.ContinueWith(t =>
            {
                Console.WriteLine($"Resultado función asíncroma = {i.Result}");
            });
            Console.WriteLine("Sigo ejecutando en paralelo a la tarea asíncrona");

            Console.ReadLine();
        }

        public static Task<int> Tarda()
        {
            var t = Task.Factory.StartNew(() =>
            {
                for (var j = 0; j < 200; j++)
                {
                    for (var i = 0; i < 10000000; i++)
                        ;
                }

                Console.WriteLine("+++Terminó Tarda");
                return 42;
            });

            return t;
        }
    }
}
