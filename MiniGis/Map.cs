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

        //масштаб
        private double _mapScale = 1; 

        private bool _isMouseDown = false;
        private System.Drawing.Point _mouseDownPosition = new System.Drawing.Point();

        //активный инструмент
        private MapToolType _activeTool; 

        public MapToolType ActiveTool
        {
            get { return _activeTool; }
            set
            {
                _activeTool = value;
                switch (_activeTool)
                {
                    case MapToolType.Select:
                        Cursor = Cursors.Arrow;
                        break;
                    case MapToolType.Pan:
                        Cursor = Cursors.Hand;
                        break;
                    case MapToolType.ZoomIn:
                        Cursor = Cursors.Help;
                        break;
                    case MapToolType.ZoomOut:
                        Cursor = Cursors.Help;
                        break;
                }
            }
        }

        public Node Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public double MapScale
        {
            get { return _mapScale; }
            set { _mapScale = value; Invalidate(); }
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
                //Включено оптимальное сглаживание
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                layer.Draw(e);
            }
        }

        private void Map_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
                _isMouseDown = true;
                _mouseDownPosition = e.Location;            
        }

        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            switch (ActiveTool)
            {
                case MapToolType.Select:
                    break;
                case MapToolType.Pan:
                    //Если кнопка мыши на нажата, выход из метода
                    if (!_isMouseDown)
                    {
                        return;
                    }
                    var dx = (e.X - _mouseDownPosition.X) / _mapScale;
                    var dy = (e.Y - _mouseDownPosition.Y) / _mapScale;
                    _center.X -= dx;
                    _center.Y += dy;
                    Invalidate();
                    _mouseDownPosition = e.Location;
                    break;
                case MapToolType.ZoomIn:
                    break;
                case MapToolType.ZoomOut:
                    break;
            }
        }

        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;

            switch (ActiveTool)
            {
                case MapToolType.Select:
                    break;
                case MapToolType.Pan:
                    break;
                case MapToolType.ZoomIn:
                    var v = Math.Abs(_mouseDownPosition.X - e.X);
                    var h = Math.Abs(_mouseDownPosition.Y - e.Y);

                    if (v == 0 || h == 0)
                    {
                        _mapScale *= 2;
                        break;
                    }


                    var kx = Width / v;
                    var ky = Height / h;


                    Center.X = (_mouseDownPosition.X - e.X) / 2;
                    Center.Y = (_mouseDownPosition.Y + e.Y) / 2;

                    

                    break;
                case MapToolType.ZoomOut:
                    break;
            }
        }
    }
}