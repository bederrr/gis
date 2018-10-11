using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGis
{
    public partial class Map : UserControl
    {
        public Map()
        {
            InitializeComponent();
        }

        private List<Layer> _layers = new List<Layer>();
        public string name;
        private Node _center = new Node(0,0);
        private double _mapScale = 1;

        public Node Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public double MapScale
        {
            get { return _mapScale; }
            set { _mapScale = value; }
        }

        public System.Drawing.Point MapToScreen(Node point)
        {
            System.Drawing.Point screenPoint = new System.Drawing.Point();
            screenPoint.X = (int)((point.X - Center.X) * _mapScale + Width / 2 + 0.5);
            screenPoint.Y = (int)(-(point.Y - Center.Y) * _mapScale + Height / 2 + 0.5);

            return screenPoint;
        }


        //Реализовать скрин то мэп. на входи dr point на выходе Node
        public Node ScreenToMap(System.Drawing.Point screenPoint)
        {
            Node mapPoint = new Node(0, 0);
            mapPoint.X = (screenPoint.X - Width / 2) / _mapScale + Center.X;
            mapPoint.Y = -(screenPoint.Y - Height / 2) / _mapScale + Center.Y;
            return mapPoint;
        }                                                           

        public void AddLayer(Layer layer)
        {
            _layers.Add(layer);
            layer.map = this;
        }

        public void RemoveLayer(int index)
        {
            if (index < _layers.Count)
            {
                _layers.RemoveAt(index);
            }
        }

        public void RemoveMapObject()
        {
            _layers.RemoveAt(_layers.Count - 1);
        }

        public void RemoveAll()
        {
            _layers.Clear();
        }

        private void Map_Paint(object sender, PaintEventArgs e)
        {
//            e.Graphics.DrawLine(new Pen(Color.Black), new System.Drawing.Point(20,10), new System.Drawing.Point(90, 15));

            foreach(var layer in _layers)
            {
                layer.Draw(e);
            }
        }

        private void Map_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
