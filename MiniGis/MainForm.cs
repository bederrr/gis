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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Line line = new Line(new Node(10,20), new Node(30, 40));
            Layer layer = new Layer();


            Polyline polyline = new Polyline();
            polyline.AddNode(0, 0);
            polyline.AddNode(200, 100);
            polyline.AddNode(200, -100);

            Polygon polygon = new Polygon();
            polygon.AddNode(0, 0);
            polygon.AddNode(-200, 100);
            polygon.AddNode(-200, -100);

            Pen pen = new Pen(Brushes.Red, 3);
            Point point = new Point(0,0);

            
            layer.AddMapObject(line);
            layer.AddMapObject(polygon);
            layer.AddMapObject(polyline);
            layer.AddMapObject(point);
            map1.AddLayer(layer);


        }
    }
}
