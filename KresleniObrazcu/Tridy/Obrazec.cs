using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace KresleniObrazcu.Tridy
{
    public abstract class Obrazec
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public double TloustkaCary { get; protected set; }
        public Brush Vypln { get; protected set; }

        public (int x, int y) Rozmery { get; set; }

        public abstract void Vykresli(Canvas platno);

        public Obrazec(double x, double y, double tloustkaCary, Brush vypln)
        {
            X = x;
            Y = y;
            TloustkaCary = tloustkaCary;
            Vypln = vypln;
        }
    }
}
