using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace KresleniObrazcu.Tridy
{
    public class Kruh : Obrazec
    {
        public Kruh(double x, double y, double tloustkaCary, Brush vypln)
        {
            X = x;
            Y = y;
            TloustkaCary = tloustkaCary;
            Vypln = vypln;
        }
        public override void Vykresli(Canvas platno)
        {
            Ellipse kruh = new Ellipse();

            kruh.Width = 100;
            kruh.Height = 100;

            kruh.Stroke = Brushes.Black;
            kruh.StrokeThickness = TloustkaCary;
            kruh.Fill = Vypln;

            Canvas.SetLeft(kruh, X);
            Canvas.SetTop(kruh, Y);

            platno.Children.Add(kruh);
        }
    }
}
