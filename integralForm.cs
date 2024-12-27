using OxyPlot.Series;
using OxyPlot;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dixotomia
{
    public partial class integralForm : Form, IIntegralView
    {
        private Regex regex = new Regex(@"^[\d,-]+$");
        public integralForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        double IIntegralView.Interval()
        {
            bool matches;
            if (string.IsNullOrEmpty(interval.Text) || (matches = regex.IsMatch(interval.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода числа построения осей", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;

            }
            else
            {
                return Convert.ToDouble(interval.Text);
            }

        }

        double IIntegralView.upLimit()
        {
            bool matches;
            if (string.IsNullOrEmpty(upBorder.Text) || (matches = regex.IsMatch(upBorder.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода верхнего значения интеграла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {

                return Convert.ToDouble(upBorder.Text);
            }

        }

        double IIntegralView.lowLimit()
        {
            bool matches;
            if (string.IsNullOrEmpty(lowBorder.Text) || (matches = regex.IsMatch(lowBorder.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода нижнего значения интеграла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                return Convert.ToDouble(lowBorder.Text);
            }
        }

        double IIntegralView.Accuracy()
        {
            bool matches;
            if (string.IsNullOrEmpty(formatBox.Text) || (matches = regex.IsMatch(formatBox.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода значения точности", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;

            }
            else
            {
                return Convert.ToDouble(formatBox.Text);
            }
        }

        int IIntegralView.IntegralIntervalCount()
        {
            bool matches;
            if (string.IsNullOrEmpty(IntervalLimitation.Text) || (matches = regex.IsMatch(IntervalLimitation.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода значения количества интервалов", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;

            }
            else
            {
                int IntervalCount = Convert.ToInt32(IntervalLimitation.Text);

                if (simpsonT.Checked)
                {
                    if (IntervalCount < 2)
                    {
                        MessageBox.Show("Количество интервалов доолжно быть не меньше 2 для метода Симпсона. Вставлено значение 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 2;
                    }

                    if (IntervalCount % 2 != 0)
                    {
                        MessageBox.Show("Количество интервалов доолжно быть четным для метода Симпсона. Вставлено значение 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 2;
                    }
                }

                return IntervalCount;
            }
        }

        void IIntegralView.UpdateGraph(List<double[]> inputArr, byte choice)
        {
            var plotModel = this.pvGraph.Model;
            if (choice == 0 && recViz.Checked)
            {
                var lineSeries = new LineSeries
                {
                    Title = "Метод прямоугольников",
                    Color = OxyColor.FromRgb(0, 128, 0)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            else if (choice == 1 && trapViz.Checked)
            {
                var lineSeries = new LineSeries
                {
                    Title = "Метод трапеций",
                    Color = OxyColor.FromRgb(0, 0, 0)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            else if (choice == 2 && simpsonT.Checked)
            {
                var lineSeries = new LineSeries
                {
                    Title = "Метод Симпсона",
                    Color = OxyColor.FromRgb(153, 50, 204)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }

        }
        bool IIntegralView.IsRectangleActive()
        {
            if (rectangle.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IIntegralView.IsTrapezoidActive()
        {
            if (trapezoid.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IIntegralView.IsSimpsonActive()
        {
            if (simpsonT.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void IIntegralView.ShowResult(double[] inputArray)
        {
            if (formatBox.Text.Length != 0)
            {
                inputArray[0] = Math.Truncate(inputArray[0] * Math.Pow(10, Convert.ToInt32(formatBox.Text))) / Math.Pow(10, Convert.ToInt32(formatBox.Text));
                inputArray[1] = Math.Truncate(inputArray[1] * Math.Pow(10, Convert.ToInt32(formatBox.Text))) / Math.Pow(10, Convert.ToInt32(formatBox.Text));
                inputArray[2] = Math.Truncate(inputArray[2] * Math.Pow(10, Convert.ToInt32(formatBox.Text))) / Math.Pow(10, Convert.ToInt32(formatBox.Text));
            }
            rectangleResult.Text = inputArray[0].ToString();
            trapezoidResult.Text = inputArray[1].ToString();
            simpsonResult.Text = inputArray[2].ToString();

        }

        void IIntegralView.ReverseResult(int countOfIterations)
        {
            MessageBox.Show("Необходимое n = " + countOfIterations, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string IIntegralView.returnFunction()
        {
            return function.Text;
        }

        void IIntegralView.ShowGraph(PlotModel plotModel)
        {
            this.pvGraph.Model = plotModel;
        }

        public event EventHandler<EventArgs> CreateIntegralGraph;
        public event EventHandler<EventArgs> Calculate;
        public event EventHandler<EventArgs> ReverseMode;

        private void integralForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            CreateIntegralGraph(sender, e);
        }

        private void toolStripTextBox2_Click_1(object sender, EventArgs e)
        {
            Calculate(sender, e);
        }

        private void toolStripTextBox3_Click_1(object sender, EventArgs e)
        {
            ReverseMode(sender, e);
        }
    }
}
