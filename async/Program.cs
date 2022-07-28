namespace async
{
    class program
    {
        static async Task Main(string[] args)
        {
            Intermedio();
            Console.WriteLine("En Main después de Intermedio");
            Console.ReadLine();
        }

        static async Task<int> Intermedio()
        {
            Console.WriteLine("Inicio Intermedio");
            var r = await Tarda();
            Console.WriteLine("Fin Intermedio y el resultado es " + r);

            return r;
        }

        public static Task<int> Tarda()
        {
            Console.WriteLine("+++ Comienza Tarda");
            var t = Task.Factory.StartNew(() =>
            {
                for (var j = 0; j < 200; j++)
                {
                    for (var i = 0; i < 10000000; i++)
                        ;
                }

                Console.WriteLine("+++ Terminó Tarda");
                return 42;
            });

            return t;
        }
    }
}
