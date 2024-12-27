using OxyPlot.Series;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text.RegularExpressions;

namespace Dixotomia
{
    public partial class coordinateDescentForm : Form, IView
    {
        private bool checkExistence = false;

        public coordinateDescentForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }
        double IView.leftLimit() { return 0; }
        double IView.rightLimit() { return 0; }

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
            if (txtboxFunction.Text.Contains("x"))
            {
                return txtboxFunction.Text;
            }
            else
            {
                MessageBox.Show("Нет функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "x";
            }
        }

        double IView.firstSide()
        {
            return Convert.ToDouble(txtboxNachPriblis.Text);
        }

        double IView.iterationCount()
        {
            return Convert.ToDouble(textBoxNumIter.Text);
        }

        byte IView.Choice()
        {
            byte choice = 1;
            if (rbtnMin.Checked)
            {
                choice = 2;
            }
            else if (rbtnMax.Checked)
            {
                choice = 3;
            }
            return choice;
        }

        double IView.Interval()
        {
            return Convert.ToDouble(txtboxNumberOfAxles.Text);
        }

        double IView.secondSide()
        {
            return Convert.ToDouble(txtboxZnachForNumDiff.Text);
        }

        double IView.epsilon()
        {
            return Convert.ToDouble(txtboxEpselon.Text);
        }

        void IView.UpdateGraph(List<double[]> inputArr)
        {
            var plotModel = this.plotView1.Model;
            var lineSeries = new LineSeries
            {
                Title = "точки производной",
                Color = OxyColor.FromRgb(0, 128, 0)
            };
            foreach (var line in inputArr)
            {
                lineSeries.Points.Add(new DataPoint(line[0], line[1]));
            }
            plotModel.Series.Add(lineSeries);
            this.plotView1.Model = plotModel;
        }

        bool IView.MinimumOrMaximum()
        {
            return true;
        }

        public event EventHandler<EventArgs> StartDichotomy;
        public event EventHandler<EventArgs> CreateGraph;
        public event EventHandler<EventArgs> StartGoldenRatio;
        public event EventHandler<EventArgs> StartNewton;
        public event EventHandler<EventArgs> StartDescent;

        void IView.ShowGraph(PlotModel plotModel)
        {
            this.plotView1.Model = plotModel;
            checkExistence = true;
        }
        void IView.ShowResult(double result, double functionResult)
        {
            result = Math.Round(result, Convert.ToInt16(txtboxE.Text));
            functionResult = Math.Round(functionResult, Convert.ToInt16(txtboxE.Text));
            if (double.IsNaN(result) && !double.IsNaN(functionResult))
            {
                MessageBox.Show("Метод остановлен: производная достигла 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.IsNaN(result) && double.IsNaN(functionResult))
            {
                if (rbtnMin.Checked)
                {
                    MessageBox.Show("Метод остановлен: найден максимум, а не минимум. Измените начальное приближение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbtnMax.Checked)
                {
                    MessageBox.Show("Метод остановлен: найден минимум, а не максимум. Измените начальное приближение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (double.IsNaN(result) && double.IsNaN(functionResult))
            {
                MessageBox.Show("Метод остановлен: за введённое число итераций он не подошёл к точке. Проверьте, есть ли у функции точки минимума или максимума, либо увеличьте число итераций", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtnMin.Checked)
                {
                    MessageBox.Show("Минимум:" + result.ToString() + "\n" + "Значение минимума:" + functionResult.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbtnMax.Checked)
                {
                    functionResult = Math.Abs(functionResult);
                    MessageBox.Show("Максимум:" + result.ToString() + "\n" + "Значение максимума:" + functionResult.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidateText()
        {
            Regex regex = new Regex(@"^[\d,-]+$");
            bool result = true;
            bool mathces;
            if (string.IsNullOrEmpty(txtboxNachPriblis.Text) || (mathces = regex.IsMatch(txtboxNachPriblis.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода начального приближения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtboxZnachForNumDiff.Text) || (mathces = regex.IsMatch(txtboxZnachForNumDiff.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения численного дифференциала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (string.IsNullOrEmpty(textBoxNumIter.Text) || (mathces = regex.IsMatch(textBoxNumIter.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа итераций", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                CreateGraph(sender, e);
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                if (checkExistence)
                {
                    CreateGraph(sender, e);
                    StartDescent(sender, e);
                }
                else
                {
                    MessageBox.Show("Не задана функция и не построен график", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbtnMax_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
