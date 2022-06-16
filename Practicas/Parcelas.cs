namespace Practicas
{
    public class Parcela
    {
        public string? Nombre { get; set; }
        public int Largo { get; set; }
        public int Ancho { get; set; }
    }

    public class Parcelas
    {
        List<Parcela> misParcelas = new List<Parcela>()
        {
            new Parcela{ Nombre = "Blanca", Largo = 326, Ancho = 89 },
            new Parcela{ Nombre = "Amarilla", Largo = 157, Ancho = 38 },
            new Parcela{ Nombre = "Azul", Largo = 202, Ancho = 103 }
        };

        IEnumerable<Parcela> GetParcelas()
        {
            foreach (var parcela in misParcelas)
            {
                yield return parcela;
            }
        }

        public void PrintAreaParcelas()
        {
            foreach (var parcela in GetParcelas())
            {
                var area = parcela.Ancho * parcela.Largo;
                Console.WriteLine("El area de la parcela " + parcela.Nombre + " es " + area.ToString());
            }
        }
    }
}