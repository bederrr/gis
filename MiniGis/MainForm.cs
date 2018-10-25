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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
//            Line line = new Line(new Node(10,20), new Node(30, 40));
            Layer layer = new Layer();

            /*
                        Polyline polyline = new Polyline();
                        polyline.AddNode(0, 0);
                        polyline.AddNode(200, 100);
                        polyline.AddNode(200, -100);
            */
            for (int i = 0; i < 10000; i++)
            {
                Polygon polygon = new Polygon();
                polygon.AddNode(0-i, i-10);
                polygon.AddNode(i+1, i-1);
                polygon.AddNode(1000-i, i-1500);
                layer.AddMapObject(polygon);
            }


            /*
                        Pen pen = new Pen(Brushes.Red, 3);
                        Point point = new Point(0,0);
            */

            //            layer.AddMapObject(line);
            //            layer.AddMapObject(polygon);
            //            layer.AddMapObject(polyline);
            //            layer.AddMapObject(point);
            map1.AddLayer(layer);

        }

        private void ButtonZoomIn_Click(object sender, EventArgs e)
        {
            map1.MapScale *= 2;
        }

        private void ButtonZoomOut_Click(object sender, EventArgs e)
        {
            map1.MapScale /= 2;
        }


        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                map1.MapScale *= 2;
            else
                map1.MapScale /= 2;
        }
    }
}
