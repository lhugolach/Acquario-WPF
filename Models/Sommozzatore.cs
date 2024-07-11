using System;
using System.Windows.Media.Imaging;

namespace Acquario.Models
{
    internal class Sommozzatore : OggettoMarinoAnimato
    {
        private bool Direz = true;
        private string[] url = new string[] {
            "\\images\\diver\\sp1.png",
            "\\images\\diver\\sp2.png",
            "\\images\\diver\\sp3.png",
            "\\images\\diver\\sp4.png",
            "\\images\\diver\\sp5.png",
            "\\images\\diver\\sp6.png",
            "\\images\\diver\\sp7.png",
            "\\images\\diver\\sp8.png",
            "\\images\\diver\\sp9.png",
            "\\images\\diver\\sp10.png", };
        private string[] urlReverse = new string[] {
            "\\images\\diver\\sp1r.png",
            "\\images\\diver\\sp2r.png",
            "\\images\\diver\\sp3r.png",
            "\\images\\diver\\sp4r.png",
            "\\images\\diver\\sp5r.png",
            "\\images\\diver\\sp6r.png",
            "\\images\\diver\\sp7r.png",
            "\\images\\diver\\sp8r.png",
            "\\images\\diver\\sp9r.png",
            "\\images\\diver\\sp10r.png", };
        private int n = 0;

        public Sommozzatore(double x, double y) : base(x, y, "...")
        {

        }

        public override void Movimento()
        {
            if (Direz == true)
            {
                Uri spr2Uri = new Uri(url[n], UriKind.Relative);
                spr1.Source = new BitmapImage(spr2Uri);

                if (movX <= 1100)
                {
                    movX = movX + 5;

                    if (n == 9) n = -1;

                    n++;
                }
                else Direz = false;
            }
            else
            {
                Uri spr2Uri = new Uri(urlReverse[n], UriKind.Relative);
                spr1.Source = new BitmapImage(spr2Uri);

                if (movX >= -200)
                {
                    movX = movX - 5;

                    if (n == 9) n = -1;

                    n++;
                }
                else Direz = true;
            }
        }
    }
}
