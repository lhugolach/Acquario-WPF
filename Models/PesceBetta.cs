using System;
using System.Windows.Media.Imaging;

namespace Acquario.Models
{
    internal class PesceBetta : OggettoMarinoAnimato
    {
        private bool direzX = true;
        private bool direzY = true;
        Random rnd = new Random();
        private int randomX, randomY;

        public PesceBetta(double x, double y) : base(x, y, "...")
        {
            randomX = rnd.Next(5, 10);
            randomY = rnd.Next(5, 11);
        }

        public override void Movimento()
        {
            if (direzX == true)
            {
                Uri pr1Uri = new Uri("\\images\\betta2.png", UriKind.Relative);
                spr1.Source = new BitmapImage(pr1Uri);

                if (movX <= 850)
                {
                    movX = movX + randomX;
                }
                else
                {
                    randomX = rnd.Next(5, 10);
                    direzX = false;
                    direzY = true;
                }
            }
            else
            {
                Uri pr1Uri = new Uri("\\images\\betta.png", UriKind.Relative);
                spr1.Source = new BitmapImage(pr1Uri);

                if (movX >= 1)
                {
                    movX = movX - randomX;
                }
                else
                {
                    randomX = rnd.Next(5, 10);
                    direzX = true;
                    direzY = false;
                }
            }

            if (direzY == true)
            {
                if (movY <= 500)
                {
                    movY = movY + randomY;
                }

                else
                {
                    randomY = rnd.Next(3, 11);
                    direzX = false;
                    direzY = false;
                }
            }
            else
            {
                if (movY >= 1)
                {
                    movY = movY - randomY;
                }

                else
                {
                    randomY = rnd.Next(3, 11);
                    direzX = true;
                    direzY = true;
                }
            }
        }
    }
}
