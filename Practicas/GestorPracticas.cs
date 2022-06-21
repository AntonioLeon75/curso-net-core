namespace Practicas
{
    public class GestorPracticas
    {
        // Ejecuta la práctica de yield
        public void ExecuteYield()
        {
            var parcelas = new Parcelas();
            parcelas.PrintAreaParcelas();
        }

        public void ExecuteDelegados()
        {
            var delegados = new Delegados();
            delegados.ExecMainDelegados();
        }
    }
}