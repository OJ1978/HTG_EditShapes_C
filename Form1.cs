using EditShape;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HTG_EditShapes_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void Add(shpShape shape)
        {

            canvas1.Shapes.Add(shape);
            canvas1.Invalidate();

        }

        private void canvas1_SelectedShapeChanged(object sender, EventArgs e)
        {

            shpShape s = canvas1.SelectedShape;
            propertyGrid1.SelectedObject = s;

        }

        private void addEllipseButton_Click(object sender, EventArgs e)
        {

            this.Add(new shpCircle(Point.Empty));

        }
    }
}
