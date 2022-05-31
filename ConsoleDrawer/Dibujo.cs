namespace ConsoleDrawer
{
    public class Dibujo
    {
        private Lista<IFigura> aFiguras;

        public Dibujo()
        {
            aFiguras = new Lista<IFigura>(10);
            aFiguras.Add(new Texto(10, 5, "Hola a Todes")) ;
        }

        public void Dibujar()
        {
            /*foreach(var aFigura in aFiguras)
            {
                aFigura?.Dibujar();
            }*/

            for(var idx = 0; idx < aFiguras.Count; idx++)
            {
                var figura = aFiguras.GetAt(idx) as Figura;
                figura.Dibujar();                
            }
        }
    }

}