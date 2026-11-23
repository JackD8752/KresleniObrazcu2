using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace KresleniObrazcu.Tridy
{
    public abstract class Obrazec//TEST
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }

        public double TloustkaCary { get; protected set; }
        public Brush Vypln { get; protected set; }

        public abstract void Vykresli(Canvas platno);
    }
}
