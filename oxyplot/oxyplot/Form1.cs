using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.WindowsForms;
using OxyPlot;
using OxyPlot.Series;

namespace oxyplot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OxyPlot.WindowsForms.PlotView pv = new PlotView();
            pv.Location = new Point(0, 0);
            pv.Size = new Size(500, 250);
            this.Controls.Add(pv);
            pv.Model = new PlotModel { Title = "Example"};
            FunctionSeries fs = new FunctionSeries();
            fs.Points.Add(new DataPoint(0, 0));
            fs.Points.Add(new DataPoint(10, 10));

            pv.Model.Series.Add(fs);
            pv.Model.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
            pv.Model.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            pv.Model.Series.Add(new FunctionSeries(Math.Tan, 0, 1, 0.1, "tan(x)"));
        }
    }
}
