using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGis
{
    public class Bounds
    {
        private Node _min;
        private Node _max;
        private bool _valid;

        public Bounds()
        {

        }

        public void SetBounds(double xmax, double ymax, double xmin, double ymin)
        {
            _max.X = xmax;
            _max.Y = ymax;

            _min.X = xmin;
            _min.Y = ymin;

            _valid = true;
        }

        public void SetBounds(Node max, Node min)
        {
            _max = max;
            _min = min;

            _valid = true;
        }

        public static Bounds operator+(Bounds a, Bounds b)
        {
            if (!a._valid && b._valid)
                return b;

            if (!b._valid && a._valid)
                return a;

            if (!a._valid && !b._valid)
                return a;

            Bounds c = new Bounds();

            c.Min.X = Math.Min(a.Min.X, b.Min.X);
            c.Min.Y = Math.Min(a.Min.Y, b.Min.Y);

            c.Max.X = Math.Max(a.Max.X, b.Max.X);
            c.Max.Y = Math.Max(a.Max.Y, b.Max.Y);

            return c;
        }

        //Уязвимость, менять х и у можно
        public Node Min { get => _min; }
        public Node Max { get => _max; }
        public bool Valid { get => _valid; }
    }
}
