using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Acquario.Models
{
    public class OggettoMarinoInanimato : OggettoMarino
    {
        public Image spr1 { get; private set; }
        public double staticX { get; protected set; }
        public double staticY { get; protected set; }

        public OggettoMarinoInanimato(double x, double y, string file)
        {
            staticX = x;
            staticY = y;
            spr1 = new Image();
            Uri spr1Uri = new Uri(file, UriKind.Relative);
            spr1.Source = new BitmapImage(spr1Uri);
            spr1.Width = 120;
            spr1.Height = 100;
        }
    }
}
