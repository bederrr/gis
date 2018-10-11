using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniGis
{
    public class Node
    {
        private double x;
        private double y;

        public Node(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
    }
}
