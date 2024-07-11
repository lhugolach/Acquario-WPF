using System;

namespace Acquario.Models
{
    internal class Bolle : OggettoMarinoAnimato
    {
        private Random rnd = new Random();

        public Bolle(double x, double y) : base(x, y, "\\images\\bubble.png")
        {
            spr1.Width = 200;
            spr1.Height = 200;
        }

        public override void Movimento()
        {
            if (movY >= -500)
            {
                movY = movY - 15;
            }
            else
            {
                movY = 1300;
                movX = rnd.Next(1, 900);
            }
        }
    }
}
