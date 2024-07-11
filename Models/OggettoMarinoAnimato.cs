using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Acquario.Models
{
    public abstract class OggettoMarinoAnimato : OggettoMarino
    {
        public Image spr1 { get; private set; }
        public double movX { get; protected set; }
        public double movY { get; protected set; }

        public OggettoMarinoAnimato(double x, double y, string file)
        {
            movX = x;
            movY = y;
            spr1 = new Image();
            Uri spr1Uri = new Uri(file, UriKind.Relative);
            spr1.Source = new BitmapImage(spr1Uri);
            spr1.Width = 120;
            spr1.Height = 100;
        }
        public abstract void Movimento();
    }
}
