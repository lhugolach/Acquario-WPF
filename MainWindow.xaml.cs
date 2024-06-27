using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Acquario
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random(); // var random per la posizione
        private DispatcherTimer dt;
        private OggettoMarinoInanimato cof, band, conc;
        private OggettoMarinoAnimato pr1, somm, crab, bub, pp, ang, bet;
        

        public MainWindow()
        {
            InitializeComponent();

            InizializeElements();

            dt = new DispatcherTimer(TimeSpan.FromMilliseconds(30), DispatcherPriority.Render, MoveElements, Dispatcher);
            dt.Start();
        }

        private void InizializeElements()
        {
            cof = new Forziere(600, 300);
            band = new Bandiera(550,160);
            conc = new Conchiglia(20, 500);

            somm = new Sommozzatore(-199, 110);
            pr1 = new PesceRosso(rnd.Next(100,980),rnd.Next(100,500));
            crab = new Granchio(500, 510);
            bub = new Bolle(rnd.Next(1,999), 900);
            pp = new PescePagliaccio(rnd.Next(101, 981), rnd.Next(101, 501));
            ang = new PesceAngelo(rnd.Next(102, 982), rnd.Next(102, 502));
            bet = new PesceBetta(rnd.Next(103, 983), rnd.Next(103, 503));


            fondo.Children.Add(cof.spr1);
            fondo.Children.Add(band.spr1);
            fondo.Children.Add(conc.spr1);

            fondo.Children.Add(somm.spr1);
            fondo.Children.Add(pr1.spr1);
            fondo.Children.Add(crab.spr1);            
            fondo.Children.Add(bub.spr1);
            fondo.Children.Add(pp.spr1);
            fondo.Children.Add(ang.spr1);
            fondo.Children.Add(bet.spr1);
        }

        private void MoveElements(object sender, EventArgs e)
        {
            cof.spr1.RenderTransform = new TranslateTransform(cof.staticX, cof.staticY);
            conc.spr1.RenderTransform = new TranslateTransform(conc.staticX, conc.staticY);
            band.spr1.RenderTransform = new TranslateTransform(band.staticX, band.staticY);

            somm.Movimento();
            somm.spr1.RenderTransform = new TranslateTransform(somm.movX, somm.movY);            
            pr1.Movimento();
            pr1.spr1.RenderTransform = new TranslateTransform(pr1.movX, pr1.movY);
            crab.Movimento();
            crab.spr1.RenderTransform = new TranslateTransform(crab.movX, crab.movY);
            pp.Movimento();
            pp.spr1.RenderTransform = new TranslateTransform(pp.movX, pp.movY);
            ang.Movimento();
            ang.spr1.RenderTransform = new TranslateTransform(ang.movX, ang.movY);
            bet.Movimento();
            bet.spr1.RenderTransform = new TranslateTransform(bet.movX, bet.movY);
            bub.Movimento();
            bub.spr1.RenderTransform = new TranslateTransform(bub.movX, bub.movY);            
        }
    }
}
