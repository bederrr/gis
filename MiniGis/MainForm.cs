using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MouseWheel += new MouseEventHandler(this_MouseWheel);
            ButtonSelect.Checked = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
//            Line line = new Line(new Node(10,20), new Node(30, 40));
            Layer layer = new Layer();

            
                        Polyline polyline = new Polyline();
                        polyline.AddNode(0, 0);
                        polyline.AddNode(200, 100);
                        polyline.AddNode(200, -100);
            /*
            for (int i = 0; i < 10000; i++)
            {
                Polygon polygon = new Polygon();
                polygon.AddNode(0-i, i-10);
                polygon.AddNode(i+1, i-1);
                polygon.AddNode(1000-i, i-1500);
                layer.AddMapObject(polygon);
            }
            */

            /*
                        Pen pen = new Pen(Brushes.Red, 3);
                        Point point = new Point(0,0);
            */

            //            layer.AddMapObject(line);
            //            layer.AddMapObject(polygon);
                        layer.AddMapObject(polyline);
            //            layer.AddMapObject(point);
            map1.AddLayer(layer);

        }

        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                map1.MapScale *= 2;
            else
                map1.MapScale /= 2;
        }

        private void ButtonZoomIn_Click(object sender, EventArgs e)
        {
            
//            map1.ActiveTool = MapToolType.ZoomIn;
//            map1.MapScale *= 2;

            ButtonZoomIn.Checked = true;
            ButtonSelect.Checked = false;
            ButtonPan.Checked = false;
            ButtonZoomOut.Checked = false;
        }

        private void ButtonZoomOut_Click(object sender, EventArgs e)
        {
//            map1.ActiveTool = MapToolType.ZoomOut;
//            map1.MapScale /= 2;

            ButtonZoomIn.Checked = false;
            ButtonSelect.Checked = false;
            ButtonPan.Checked = false;
            ButtonZoomOut.Checked = true;
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            map1.ActiveTool = MapToolType.Select;

            ButtonSelect.Checked = true;
            ButtonPan.Checked = false;
            ButtonZoomIn.Checked = false;
            ButtonZoomOut.Checked = false;
        }

        private void ButtonPan_Click(object sender, EventArgs e)
        {
            map1.ActiveTool = MapToolType.Pan;

            ButtonZoomIn.Checked = false;
            ButtonSelect.Checked = false;
            ButtonPan.Checked = true;
            ButtonZoomOut.Checked = false;
        }

        private void map1_MouseMove(object sender, MouseEventArgs e)
        {
            var mapCursorLocation = map1.ScreenToMap(e.Location);
            LabelMapCursorPosition.Text = "x: " + mapCursorLocation.X + " y: " + mapCursorLocation.Y;
        }
    }
}
