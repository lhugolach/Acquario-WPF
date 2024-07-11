namespace Acquario.Models
{
    public class Bandiera : OggettoMarinoInanimato
    {
        public Bandiera(double x, double y) : base(x, y, "\\images\\flag.png")
        {
            staticX = 550;
            staticY = 160;
        }
    }
}
