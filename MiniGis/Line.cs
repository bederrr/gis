using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MiniGis
{
    public class Line : MapObject
    {
        private Node _begin;
        private Node _end;

        public Line(Node begin, Node end)
        {
            _begin = begin;
            _end = end;
            _objecttype = MapObjectType.Line;
        }

        internal override void Draw(PaintEventArgs e)
        {            
            var beginPoint = Layer.Map.MapToScreen(_begin);
            var endPoint = Layer.Map.MapToScreen(_end);

            UseOwnStyle = true;
            Pen pen = new Pen(Color.Red);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            e.Graphics.DrawLine(pen,beginPoint,endPoint);
        }

        #region acsess methods
        public double BX
        {
            get {return _begin.X; }
            set { _begin.X = value; }
        }

        public double BY
        {
            get { return _begin.Y; }
            set { _begin.Y = value; }
        }

        public double EX
        {
            get { return _end.X; }
            set { _end.X = value; }
        }

        public double EY
        {
            get { return _end.Y; }
            set { _end.Y = value; }
        }
#endregion acsess methods
    }
}
