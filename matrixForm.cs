﻿using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dixotomia
{
    public partial class matrixForm : Form, IAlgebraicView
    {
        private string path = string.Empty;

        public matrixForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        public event EventHandler<EventArgs> StartGauss;
        public event EventHandler<EventArgs> StartJordanoGauss;
        public event EventHandler<EventArgs> StartCramer;

        double[,] IAlgebraicView.GetMatrix()
        {
            double[,] matrix = new double[dataGridView1.Rows.Count - 1, dataGridView1.Columns.Count];
            for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count - 1; ++rowIndex)
            {
                for (int columnIndex = 0; columnIndex < dataGridView1.Columns.Count; ++columnIndex)
                {
                    if (dataGridView1.Rows[rowIndex].Cells[columnIndex].Value == null ||
                        string.IsNullOrWhiteSpace(dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString()))
                    {
                        MessageBox.Show("Пустоту вводить нельзя. Присвоено значение 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = 1;
                    }

                    if (!double.TryParse(dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString(), out double value))
                    {
                        MessageBox.Show("Буквы вводить нельзя. Присвоено значение 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = 1;
                    }

                    matrix[rowIndex, columnIndex] = value;
                }
            }
            return matrix;
        }

        double[] IAlgebraicView.GetVector()
        {
            double[] vector = new double[dataGridView2.Rows.Count - 1];
            for (int vectorIndex = 0; vectorIndex < dataGridView2.Rows.Count - 1; ++vectorIndex)
            {
                if (dataGridView2.Rows[vectorIndex].Cells[0].Value == null ||
                    string.IsNullOrWhiteSpace(dataGridView2.Rows[vectorIndex].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Пустоту вводить нельзя. Присвоено значение 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView2.Rows[vectorIndex].Cells[0].Value = 1;
                }

                if (!double.TryParse(dataGridView2.Rows[vectorIndex].Cells[0].Value.ToString(), out double value))
                {
                    MessageBox.Show("Буквы вводить нельзя. Присвоено значение 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView2.Rows[vectorIndex].Cells[0].Value = 1;
                }

                vector[vectorIndex] = value;
            }
            return vector;
        }

        void IAlgebraicView.ShowResult(double[] result, double elapsedTime)
        {
            Regex regex = new Regex(@"^[\d,-]+$");
            int accuracy;
            if (string.IsNullOrEmpty(accuracytextBox.Text) || (regex.IsMatch(accuracytextBox.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода точности. Присвоено значение 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                accuracy = 2;
            }
            else
            {
                accuracy = Convert.ToInt32(accuracytextBox.Text);
            }

            string resultString = "";
            if (result != null)
            {
                for (int outputIndex = 0; outputIndex < result.Length; ++outputIndex)
                {
                    resultString += "x" + (outputIndex + 1) + " = " + Math.Round(result[outputIndex], accuracy).ToString() + "\n";
                }

            }
            resultString += $"Время выполнения: {elapsedTime} с";
            MessageBox.Show(resultString, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            Regex regex = new Regex(@"^[\d,-]+$");
            bool result = true;
            bool mathces;
            int matrixCount;
            int minValue;
            int maxValue;

            if (string.IsNullOrEmpty(left.Text) || (regex.IsMatch(left.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода минимального значения. Присвоено значение 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                minValue = 1;
            }
            else
            {
                minValue = Convert.ToInt32(left.Text);
            }

            if (string.IsNullOrEmpty(right.Text) || (regex.IsMatch(right.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода максимального значения. Присвоено значение 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maxValue = 1;
            }
            else
            {
                maxValue = Convert.ToInt32(right.Text);
            }

            if (string.IsNullOrEmpty(txtBoxCountNumbers.Text) || (regex.IsMatch(txtBoxCountNumbers.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода размерности матрицы", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                matrixCount = 1;
            }
            else
            {
                matrixCount = Convert.ToInt32(txtBoxCountNumbers.Text);
            }

            if (hand.Checked)
            {

                foreach (Control control in this.Controls)
                {
                    if (control is DataGridView)
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView2.Rows.Clear();
                        dataGridView2.Columns.Clear();
                    }
                }

                for (int mainColumnIndex = 0; mainColumnIndex < matrixCount; ++mainColumnIndex)
                {
                    dataGridView1.Columns.Add("col" + mainColumnIndex.ToString(), "X [" + (mainColumnIndex + 1).ToString() + "]");
                }

                // Добавить строки в таблицу для матрицы
                for (int mainRowIndex = 0; mainRowIndex < matrixCount; ++mainRowIndex)
                {
                    dataGridView1.Rows.Add();
                }

                // Заспавнить значения в таблице для матрицы
                for (int spawnZeroIndex = 0; spawnZeroIndex < matrixCount; ++spawnZeroIndex)
                {
                    for (int ZeroIndex = 0; ZeroIndex < matrixCount; ++ZeroIndex)
                    {
                        dataGridView1.Rows[spawnZeroIndex].Cells[ZeroIndex].Value = 0;
                    }
                }

                dataGridView2.Columns.Add("col1", "X");

                // Добавить строки в таблицу для вектора-столбца
                for (int vectorIndex = 0; vectorIndex < matrixCount; ++vectorIndex)
                {
                    dataGridView2.Rows.Add();
                }

                // Заспавнить значения в таблице для вектора-столбца
                for (int vectorSpawnIndex = 0; vectorSpawnIndex < matrixCount; ++vectorSpawnIndex)
                {
                    dataGridView2.Rows[vectorSpawnIndex].Cells[0].Value = 0;
                }
            }
            if (file.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is DataGridView)
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView2.Rows.Clear();
                        dataGridView2.Columns.Clear();
                    }
                }
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                }
                using (FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(file);
                    ISheet sheet = workbook.GetSheetAt(0);
                    // Извлечь данные из таблицы
                    int rows = sheet.PhysicalNumberOfRows;
                    int columns = sheet.GetRow(0).LastCellNum;

                    // Добавить столбцы в матрицу
                    for (int columnMatrixIndex = 0; columnMatrixIndex < columns - 1; ++columnMatrixIndex)
                    {
                        dataGridView1.Columns.Add("col" + columnMatrixIndex.ToString(), "X [" + (columnMatrixIndex + 1).ToString() + "]");
                    }

                    // Добавить строки в матрицу
                    for (int rowMatrixIndex = 0; rowMatrixIndex < rows - 1; ++rowMatrixIndex)
                    {
                        dataGridView1.Rows.Add();
                    }
                    dataGridView2.Columns.Add("col1", "X");
                    // Добавить строки в вектор
                    for (int vectorIndex = 0; vectorIndex < rows - 1; ++vectorIndex)
                    {
                        dataGridView2.Rows.Add();
                    }

                    // Заполнить dataGridViewMatrix и dataGridViewVector данными
                    for (int fillRow = 0; fillRow < rows - 1; ++fillRow)
                    {
                        var row = sheet.GetRow(fillRow + 1);
                        if (row != null)
                        {
                            for (int fillColumn = 0; fillColumn < columns - 1; ++fillColumn)
                            {
                                if (row.GetCell(fillColumn) != null)
                                {
                                    dataGridView1.Rows[fillRow].Cells[fillColumn].Value = row.GetCell(fillColumn).NumericCellValue;
                                }

                            }
                            if (row.GetCell(columns - 1) != null)
                            {
                                dataGridView2.Rows[fillRow].Cells[0].Value = row.GetCell(columns - 1).NumericCellValue;
                            }
                        }
                    }
                }
            }
            if (auto.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is DataGridView)
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        dataGridView2.Rows.Clear();
                        dataGridView2.Columns.Clear();
                    }
                }

                for (int columnIndex = 0; columnIndex < matrixCount; ++columnIndex)
                {
                    dataGridView1.Columns.Add("col" + columnIndex.ToString(), "X [" + (columnIndex + 1).ToString() + "]");
                }

                for (int rowIndex = 0; rowIndex < matrixCount; ++rowIndex)
                {
                    dataGridView1.Rows.Add();
                }

                for (int rowIndex = 0; rowIndex < matrixCount; ++rowIndex)
                {
                    for (int columnIndex = 0; columnIndex < matrixCount; ++columnIndex)
                    {
                        if (radioButton4.Checked)
                        {
                            dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = random.Next(minValue, maxValue);
                        }
                        else if (doubl.Checked)
                        {
                            dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = random.NextDouble() * (maxValue - minValue) + minValue;
                        }
                    }
                }

                dataGridView2.Columns.Add("col1", "X");

                for (int rowIndex = 0; rowIndex < matrixCount; ++rowIndex)
                {
                    dataGridView2.Rows.Add();
                }

                for (int rowIndex = 0; rowIndex < matrixCount; ++rowIndex)
                {
                    if (radioButton4.Checked)
                    {
                        dataGridView2.Rows[rowIndex].Cells[0].Value = random.Next(minValue, maxValue);
                    }
                    else if (doubl.Checked)
                    {
                        dataGridView2.Rows[rowIndex].Cells[0].Value = random.NextDouble() * (maxValue - minValue) + minValue;
                    }
                }
            }
        }

        private void toolStripTextBox2_Click_1(object sender, EventArgs e)
        {
            if (Gauss.Checked)
            {
                StartGauss(sender, e);
            }
            if (GaussJordan.Checked)
            {
                StartJordanoGauss(sender, e);
            }
            if (Kramer.Checked)
            {
                StartCramer(sender, e);
            }
        }
    }
}
