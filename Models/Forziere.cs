namespace Acquario.Models
{
    public class Forziere : OggettoMarinoInanimato
    {
        public Forziere(double x, double y) : base(x, y, "\\images\\forziere.png")
        {
            spr1.Width = 250;
            spr1.Height = 250;
            staticX = 720;
            staticY = 280;
        }
    }
}
