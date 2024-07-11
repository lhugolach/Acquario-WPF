using Acquario.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Acquario.ViewModels
{
    public class AcquarioViewModel : INotifyPropertyChanged
    {
        private Random rnd = new Random();
        private OggettoMarinoInanimato cof, band, conc;
        private OggettoMarinoAnimato pr1, somm, crab, bub, pp, ang, bet;
        private ObservableCollection<UIElement> _fondale;
        private DispatcherTimer _dt;
        private Dispatcher _dispatcher;
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<UIElement> Fondale
        {
            get { return _fondale; }
            set
            {
                _fondale = value;
                OnPropertyChanged("Fondale");
            }
        }

        public AcquarioViewModel()
        {
            InizializeElements();
        }

        public void SetDispatcher(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
            InitializeTimer();
        }

        private void InizializeElements()
        {
            cof = new Forziere(600, 300);
            band = new Bandiera(550, 160);
            conc = new Conchiglia(20, 500);

            somm = new Sommozzatore(-199, 110);
            pr1 = new PesceRosso(rnd.Next(100, 980), rnd.Next(100, 500));
            crab = new Granchio(500, 510);
            bub = new Bolle(rnd.Next(1, 999), 900);
            pp = new PescePagliaccio(rnd.Next(101, 981), rnd.Next(101, 501));
            ang = new PesceAngelo(rnd.Next(102, 982), rnd.Next(102, 502));
            bet = new PesceBetta(rnd.Next(103, 983), rnd.Next(103, 503));

            Fondale = new ObservableCollection<UIElement>
            {
                cof.spr1,
                band.spr1,
                conc.spr1,
                somm.spr1,
                pr1.spr1,
                crab.spr1,
                bub.spr1,
                pp.spr1,
                ang.spr1,
                bet.spr1
            };
        }

        private void InitializeTimer()
        {
            _dt = new DispatcherTimer(TimeSpan.FromMilliseconds(30), DispatcherPriority.Render, MoveElements, _dispatcher);
            _dt.Start();
        }

        private void MoveElements(object sender, EventArgs e)
        {
            cof.spr1.RenderTransform = new TranslateTransform(cof.staticX, cof.staticY);
            band.spr1.RenderTransform = new TranslateTransform(band.staticX, band.staticY);
            conc.spr1.RenderTransform = new TranslateTransform(conc.staticX, conc.staticY);

            somm.Movimento();
            somm.spr1.RenderTransform = new TranslateTransform(somm.movX, somm.movY);
            pr1.Movimento();
            pr1.spr1.RenderTransform = new TranslateTransform(pr1.movX, pr1.movY);
            crab.Movimento();
            crab.spr1.RenderTransform = new TranslateTransform(crab.movX, crab.movY);
            bub.Movimento();
            bub.spr1.RenderTransform = new TranslateTransform(bub.movX, bub.movY);
            pp.Movimento();
            pp.spr1.RenderTransform = new TranslateTransform(pp.movX, pp.movY);
            ang.Movimento();
            ang.spr1.RenderTransform = new TranslateTransform(ang.movX, ang.movY);
            bet.Movimento();
            bet.spr1.RenderTransform = new TranslateTransform(bet.movX, bet.movY);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
