namespace Acquario.Models
{
    public class Conchiglia : OggettoMarinoInanimato
    {
        public Conchiglia(double x, double y) : base(x, y, "\\images\\conchiglia.png")
        {
            spr1.Width = 200;
            spr1.Height = 200;
            staticX = 20;
            staticY = 500;
        }
    }
}
