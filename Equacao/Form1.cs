using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Equacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            var a = Convert.ToDouble(txtA.Text);
            var b = Convert.ToDouble(txtB.Text);
            var c = Convert.ToDouble(txtC.Text);

            var delta = (b * b) - (4 * a * c);
            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            txtX1.Text = x1.ToString();
            txtX2.Text = x2.ToString();

            // Plot
            var lineAnnotation = new LineAnnotation()
            {
                Type = LineAnnotationType.Vertical,
                Y = 0,
            };


            PlotModel model = new PlotModel { Title = "Função de Segundo Grau" };
            model.Annotations.Add(lineAnnotation);
            model.Series.Add(new FunctionSeries(x => a * x * x + b * x + c, -10, 10, 0.1, "y = ax^2 + bx + c"));
            var yAxis = new LinearAxis
            {
                Maximum = 10,
            };

            model.Axes.Add(yAxis);
            PlotView view = new PlotView
            {
                Model = model,
                Dock = System.Windows.Forms.DockStyle.Fill,
            };


            panel1.Controls.Add(view);
        }
    }
}