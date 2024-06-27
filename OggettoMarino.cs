using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Acquario
{
    public class OggettoMarino
    {        
        public OggettoMarino()
        {
            
        }
    }

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

    public class Forziere : OggettoMarinoInanimato
    {
        public Forziere(double x, double y) : base(x,y,"images\\forziere.png")
        {
            spr1.Width = 250;
            spr1.Height = 250;
            staticX = 720;
            staticY = 280;
        }
    }

    public class Conchiglia : OggettoMarinoInanimato
    {
        public Conchiglia(double x, double y) : base(x, y, "images\\conchiglia.png")
        {
            spr1.Width = 200;
            spr1.Height = 200;
            staticX = 20;
            staticY = 500;
        }
    }

    public class Bandiera : OggettoMarinoInanimato
    {
        public Bandiera(double x, double y) : base(x, y, "images\\flag.png")
        {            
            staticX = 550;
            staticY = 160;
        }
    }

    //--------------------------------------------------------------------------------------------//

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

    public class Sommozzatore : OggettoMarinoAnimato
    {
        private bool Direz = true;
        private string[] url = new string[] {
            "images\\diver\\sp1.png",
            "images\\diver\\sp2.png",
            "images\\diver\\sp3.png",
            "images\\diver\\sp4.png",
            "images\\diver\\sp5.png",
            "images\\diver\\sp6.png",
            "images\\diver\\sp7.png",
            "images\\diver\\sp8.png",
            "images\\diver\\sp9.png",
            "images\\diver\\sp10.png", };
        private string[] urlReverse = new string[] {
            "images\\diver\\sp1r.png",
            "images\\diver\\sp2r.png",
            "images\\diver\\sp3r.png",
            "images\\diver\\sp4r.png",
            "images\\diver\\sp5r.png",
            "images\\diver\\sp6r.png",
            "images\\diver\\sp7r.png",
            "images\\diver\\sp8r.png",
            "images\\diver\\sp9r.png",
            "images\\diver\\sp10r.png", };
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

    public class PesceRosso : OggettoMarinoAnimato
    {
        private bool direzX = true;
        private bool direzY = true;
        Random rnd = new Random();
        private int randomX, randomY;

        public PesceRosso(double x, double y) : base(x, y, "...")
        {
            randomX = rnd.Next(5, 10);
            randomY = rnd.Next(5, 11);
        }        

        public override void Movimento()
        {
            if (direzX == true)
            {               
                Uri pr1Uri = new Uri("images\\pr1.png", UriKind.Relative);
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
                Uri pr1Uri = new Uri("images\\pr1Reverse.png", UriKind.Relative);
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

    public class PescePagliaccio : OggettoMarinoAnimato
    {
        private bool direzX = true;
        private bool direzY = true;
        Random rnd = new Random();
        private int randomX, randomY;

        public PescePagliaccio(double x, double y) : base(x, y, "...")
        {
            randomX = rnd.Next(5, 10);
            randomY = rnd.Next(5, 11);
        }

        public override void Movimento()
        {
            if (direzX == true)
            {
                Uri pr1Uri = new Uri("images\\pagliaccio.png", UriKind.Relative);
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
                Uri pr1Uri = new Uri("images\\pagliaccio2.png", UriKind.Relative);
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

    public class PesceAngelo : OggettoMarinoAnimato
    {
        private bool direzX = true;
        private bool direzY = true;
        Random rnd = new Random();
        private int randomX, randomY;

        public PesceAngelo(double x, double y) : base(x, y, "...")
        {
            randomX = rnd.Next(5, 10);
            randomY = rnd.Next(5, 11);
        }

        public override void Movimento()
        {
            if (direzX == true)
            {
                Uri pr1Uri = new Uri("images\\angelo.png", UriKind.Relative);
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
                Uri pr1Uri = new Uri("images\\angelo2.png", UriKind.Relative);
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

    public class PesceBetta : OggettoMarinoAnimato
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
                Uri pr1Uri = new Uri("images\\betta2.png", UriKind.Relative);
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
                Uri pr1Uri = new Uri("images\\betta.png", UriKind.Relative);
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

    public class Granchio : OggettoMarinoAnimato
    {
        private bool Direz = true;
        private string[] url = new string[] {
            "images\\crab\\cr1.png",
            "images\\crab\\cr2.png",
            "images\\crab\\cr3.png",
            "images\\crab\\cr4.png",
            "images\\crab\\cr5.png",
            "images\\crab\\cr6.png",
            "images\\crab\\cr7.png",
            "images\\crab\\cr8.png",
            "images\\crab\\cr9.png", };
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

    public class Bolle : OggettoMarinoAnimato
    {
        private Random rnd = new Random();

        public Bolle(double x, double y) : base(x, y, "images\\bubble.png")
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
