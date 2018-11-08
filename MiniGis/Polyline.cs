using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using ScreenPoint = System.Drawing.Point;

namespace MiniGis
{
    public class Polyline : MapObject
    {
        protected List<Node> _nodes = new List<Node>();

        public Polyline()
        {
            _objecttype = MapObjectType.Polyline;
        }

        public void AddNode(Node node)
        {
            _nodes.Add(node);
        }

        /// <summary>
        /// Добавление тратата
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        public void AddNode(double x, double y)
        {
            _nodes.Add(new Node(x,y));
        }

        public void RemoveNode(int index)
        {
            if (index < _nodes.Count)
            {
                _nodes.RemoveAt(index);
            }
        }

        public void RemoveNode()
        {
            _nodes.RemoveAt(_nodes.Count - 1);
        }

        public void RemoveAll()
        {
            _nodes.Clear();
        }

        protected override Bounds GetBounds()
        {
            Bounds bounds = new Bounds();
            foreach(var u in _nodes)
            {
                bounds += bounds.SetBounds()
            }
        }

        internal override void Draw(PaintEventArgs e)
        {

            List <ScreenPoint> points = new List<ScreenPoint>();
            
            foreach(var node in _nodes)
            {
                var point = Layer.Map.MapToScreen(node);
                points.Add(point);
            }

            e.Graphics.DrawLines(GetCurrentPen(), points.ToArray());            
        }
    }
}
