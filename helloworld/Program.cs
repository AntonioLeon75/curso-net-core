namespace CursoNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, wuachufli!");

            Cuadrado c = new Cuadrado( aName: "Pepe");
            c.Dibujar();

            Cuadrado c2 = new Cuadrado( aName: "Wachufliii", aSide: 34 );
            c2.Dibujar();

            object o = c;
            Console.WriteLine(o.GetType());

            int i = 10;
            o = i;
            Console.WriteLine(o.ToString());




        }
    }

}
