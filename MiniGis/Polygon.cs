using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using ScreenPoint = System.Drawing.Point;

namespace MiniGis
{
    public class Polygon : Polyline
    {
        public Polygon()
        {
            _objecttype = MapObjectType.Polygon;
        }

        internal override void Draw(PaintEventArgs e)
        {
            List<ScreenPoint> points = new List<ScreenPoint>();

            foreach (var node in _nodes)
            {
                if (_nodes.Count() < 2)
                    return;

                var point = Layer.Map.MapToScreen(node);
                points.Add(point);
            }
            UseOwnStyle = true;
            Brush abrush = new SolidBrush(Color.Green);
            Brush bbrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Green);

            e.Graphics.FillPolygon(bbrush, points.ToArray());
            e.Graphics.DrawPolygon(layer.Pen, points.ToArray());
        }
    }
}
