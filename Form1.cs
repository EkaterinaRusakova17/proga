using System;
using System.Windows.Forms;

namespace Dixotomia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //дихотомия
        private void button6_Click(object sender, EventArgs e)
        {
            Form2 dichotomyForm = new Form2();
            dichotomyForm.Show();
        }
        //золотое сечение
        private void button1_Click(object sender, EventArgs e)
        {
            goldenRatioForm goldenRatioForm = new goldenRatioForm();
            goldenRatioForm.Show();
        }
        //Ньютон
        private void button5_Click(object sender, EventArgs e)
        {
            Form3 newtonForm = new Form3();
            newtonForm.Show();
        }
        //покоординатный спуск
        private void button4_Click(object sender, EventArgs e)
        {
            coordinateDescentForm coordinateDescentForm = new coordinateDescentForm();
            coordinateDescentForm.Show();
        }
        //олимпиадные сортировки
        private void button2_Click(object sender, EventArgs e)
        {
            sortingForm sortingForm = new sortingForm();
            sortingForm.Show();
        }
        //опреденный интервал
        private void button3_Click(object sender, EventArgs e)
        {
            integralForm integralForm = new integralForm();
            integralForm.Show();
        }
        //СЛАУ
        private void button8_Click(object sender, EventArgs e)
        {
            matrixForm matrixForm = new matrixForm();
            matrixForm.Show();
        }
        //наименьшие квадраты
        private void button7_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
