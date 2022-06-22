namespace Practicas
{
    public class Delegados
    {
        public delegate void Delegado(string message);

        void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        void ExecBasicPractice()
        {
            Delegado handler = PrintMessage;
            handler("Soy un delegado básico");
        }


        delegate void Operacion(int a, int b);
        void Suma(int a, int b)
        {
            Console.WriteLine("La suma de " + a.ToString() + " y " + b.ToString() + " es " + (a + b).ToString());
        }

        void Multiplica(int a, int b)
        {
            Console.WriteLine("La multiplicación de " + a.ToString() + " por " + b.ToString() + " es " + (a * b).ToString());
        }

        void ExecOperaciones()
        {
            Operacion opDel;

            Console.WriteLine("Ejemplo de Delegados con operaciones");

            for (int i = 0; i <= 30; i++)
            {
                int rA = new Random().Next(1, 100);
                int rB = new Random().Next(1, 100);

                if (i % 3 == 0)
                {
                    opDel = Suma;
                    opDel(rA, rB);
                }
                else if (i % 5 == 0)
                {
                    opDel = Multiplica;
                    opDel(rA, rB);
                }

                Thread.Sleep(500);
            }
        }

        public void ExecMainDelegados()
        {
            ExecBasicPractice();
            ExecOperaciones();
        }
    }
}