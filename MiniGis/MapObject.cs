using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MiniGis
{
    public abstract class MapObject
    {
        protected MapObjectType _objecttype;
        internal Layer layer;
        public bool UseOwnStyle = false;
        private Pen _pen;
        private Brush _brush;
        private Symbol _symbol = new Symbol();

        public Brush Brush
        {
            get
            {
                if (_brush == null)
                {
                    _brush = new SolidBrush(Color.Black);
                }
                return _brush;
            }
            set { _brush = value; }
        }

        public Pen Pen
        {
            get
            {
                if(_pen==null)
                {
                    _pen = new Pen(Color.Black);
                }
                return _pen;
            }
            set { _pen = value; }
        }

        public Symbol Symbol
        {
            get
            {
                if (_symbol == null)
                {
                    _symbol = new Symbol();
                }
                return _symbol;
            }
            set { _symbol = value; }
        }

        protected Pen GetCurrentPen()
        {
            if (UseOwnStyle)
                return this.Pen;
            else return Layer.Pen;
        }

        protected Symbol GetCurrentSymol()
        {
            if (UseOwnStyle)
                return this.Symbol;
            else return Layer.symbol;
        }

        public Layer Layer
        {
            get { return layer; }
        }

        public MapObjectType ObjectType
        {
            get { return _objecttype; }
        }

        internal abstract void Draw(PaintEventArgs e);
    }
}
