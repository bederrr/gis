using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MiniGis
{
    public class Layer
    {
        private List<MapObject> _objects = new List<MapObject>();
        public string name;
        internal Map map;
        public Pen Pen = new Pen(Color.Black);
        public Brush brush = new SolidBrush(Color.Orange);
        public Symbol symbol = new Symbol();
        private Bounds _bounds = new Bounds();

        public Map Map
        {
            get { return map; }
        }

        internal Bounds Bounds { get => _bounds; }

        public void AddMapObject(MapObject mapobject)
        {
            _objects.Add(mapobject);
            mapobject.layer = this;
        }

        public void RemoveMapObject(int index)
        {
            if (index < _objects.Count)
            {
                _objects.RemoveAt(index);
            }
        }

        public void RemoveMapObject()
        {
            _objects.RemoveAt(_objects.Count - 1);
        }
        public void RemoveAll()
        {
            _objects.Clear();
        }

        internal void Draw(PaintEventArgs e)
        {
            foreach (var obj in _objects)
            {
                obj.Draw(e);
            }
        }

        public void CalcBounds()
        {
            Bounds bounds = new Bounds();

            foreach (var obj in _objects)
            {
                this._bounds += _objects.Bounds;
            }
        }
    }
}
