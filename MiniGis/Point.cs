using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniGis
{
    /// <summary>
    /// Класс для работы с точечными объектами
    /// </summary>
    public class Point : MapObject
    {
        private Node _position;

        public Point(Node _node)
        {
            _position = _node;
            _objecttype = MapObjectType.Point;
        }

        public Point(double x, double y)
        {
            _position = new Node(x, y);
            _objecttype = MapObjectType.Point;
        }

        public double X
        {
            get { return _position.X; }
            set { _position.X = value; }
        }

        public double Y
        {
            get { return _position.Y; }
            set { _position.Y = value; }
        }

        internal override void Draw(PaintEventArgs e)
        {
            Char c = (char)Symbol.Number;
            e.Graphics.DrawString(c.ToString(),Symbol.font, Brush,0,0);
        }
    }
}
