using System;
using System.Collections.Generic;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dixotomia
{
    public partial class Form2 : Form, IView
    {
        public Form2()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }
        double IView.leftLimit() { return 0; }
        double IView.rightLimit() { return 0; }

        double IView.iterationCount()
        {
            return 0;
        }

        double IView.firstSide()
        {
            return Convert.ToDouble(txtboxFrom.Text);
        }

        double IView.lowLimit()
        {
            return Convert.ToDouble(txtboxNegativeSide.Text);
        }

        double IView.upLimit()
        {
            return Convert.ToDouble(txtboxPositiveSide.Text);
        }

        string IView.returnFunction()
        {
            return txtboxFunction.Text;
        }

        double IView.Interval()
        {
            return Convert.ToDouble(txtboxNumberOfAxles.Text);
        }

        double IView.secondSide()
        {
            return Convert.ToDouble(txtboxTo.Text);
        }

        double IView.epsilon()
        {
            return Convert.ToDouble(txtboxEpselon.Text);
        }

        bool IView.MinimumOrMaximum()
        {
            return true;
        }

        byte IView.Choice()
        {
            byte choice = 1;

            return choice;
        }

        public event EventHandler<EventArgs> StartDichotomy;
        public event EventHandler<EventArgs> CreateGraph;
        public event EventHandler<EventArgs> StartGoldenRatio;
        public event EventHandler<EventArgs> StartNewton;
        public event EventHandler<EventArgs> StartDescent;

        void IView.UpdateGraph(List<double[]> inputArray)
        {

        }
        void IView.ShowGraph(PlotModel plotModel)
        {
            this.plotView1.Model = plotModel;
        }

        void IView.ShowResult(double result, double errorCheck)
        {
            if (errorCheck != 1)
            {
                result = Math.Round(result, Convert.ToInt16(txtboxE.Text));
                MessageBox.Show("Результат:" + result.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("В выбранном интервале корней нет", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateText()
        {
            Regex regex = new Regex(@"^[\d,-]+$");
            bool result = true;
            bool mathces;
            if (string.IsNullOrEmpty(txtboxFrom.Text) || (mathces = regex.IsMatch(txtboxFrom.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода левого ограничения интервала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtboxTo.Text) || (mathces = regex.IsMatch(txtboxTo.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода правого ограничения интервала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtboxEpselon.Text) || (mathces = regex.IsMatch(txtboxEpselon.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения epsilon", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtboxE.Text) || (mathces = regex.IsMatch(txtboxE.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения требуемой точности", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtboxNumberOfAxles.Text) || (mathces = regex.IsMatch(txtboxNumberOfAxles.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа точек построения осей", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtboxNegativeSide.Text) || (mathces = regex.IsMatch(txtboxNegativeSide.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа точек построения отрицательной стороны  функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtboxPositiveSide.Text) || (mathces = regex.IsMatch(txtboxPositiveSide.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа точек построения положительной стороны функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                CreateGraph(sender, e);
            }
        }

        private void toolStripTextBox2_Click_1(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                StartDichotomy(sender, e);
            }
        }
    }
}