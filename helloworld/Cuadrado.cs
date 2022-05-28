namespace CursoNet
{
    class Cuadrado
    {
        int aSide;

        public Cuadrado( int aSide = 0, string aName = "" )
        {
            Side = aSide;
            Name = aName;
        }

        public string Name { get; set; }

        public int Side
        {
            get
            {
                return aSide;
            }

            set
            {
                aSide = value;
            }

        }

        public void Dibujar()
        {
            Console.WriteLine( "Mi lado es " + Side + " y mi nombre es " + Name );
        }

    }
}