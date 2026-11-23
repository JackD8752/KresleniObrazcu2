using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KresleniObrazcu.Tridy
{
    public class Trojuhelnik : Obrazec
    {
        public Trojuhelnik(double x, double y, double tloustkaCary, Brush vypln) : base(x, y, tloustkaCary, vypln)
        {

        }
        public override void Vykresli(Canvas platno)
        {
            Polygon trojuhelnik = new Polygon
            {
                Points = new PointCollection()
                {
                    new Point(Rozmery.x/2, 0),
                    new Point(0, Rozmery.y),
                    new Point(Rozmery.x, Rozmery.y)
                },

                Stroke = Brushes.Black,
                StrokeThickness = TloustkaCary,
                Fill = Vypln
            };

            Canvas.SetLeft(trojuhelnik, X);
            Canvas.SetTop(trojuhelnik, Y);

            platno.Children.Add(trojuhelnik);
        }
    }
}
