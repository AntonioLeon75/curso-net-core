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

        public void ExecMainDelegados()
        {
            ExecBasicPractice();
        }
    }
}