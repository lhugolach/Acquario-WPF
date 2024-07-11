using System;
using System.Windows.Media.Imaging;

namespace Acquario.Models
{
    internal class Granchio : OggettoMarinoAnimato
    {
        private bool Direz = true;
        private string[] url = new string[] {
            "\\images\\crab\\cr1.png",
            "\\images\\crab\\cr2.png",
            "\\images\\crab\\cr3.png",
            "\\images\\crab\\cr4.png",
            "\\images\\crab\\cr5.png",
            "\\images\\crab\\cr6.png",
            "\\images\\crab\\cr7.png",
            "\\images\\crab\\cr8.png",
            "\\images\\crab\\cr9.png", };
        private int n = 0;

        public Granchio(double x, double y) : base(x, y, "...")
        {
            spr1.Width = 150;
            spr1.Height = 150;
        }

        public override void Movimento()
        {
            if (Direz == true)
            {
                Uri spr2Uri = new Uri(url[n], UriKind.Relative);
                spr1.Source = new BitmapImage(spr2Uri);

                if (movX <= 850)
                {
                    movX = movX + 5;

                    if (n == 8) n = -1;

                    n++;
                }
                else Direz = false;
            }
            else
            {
                Uri spr2Uri = new Uri(url[n], UriKind.Relative);
                spr1.Source = new BitmapImage(spr2Uri);

                if (movX >= 190)
                {
                    movX = movX - 5;

                    if (n == 8) n = -1;

                    n++;
                }
                else Direz = true;
            }
        }
    }
}
