namespace Dixotomia
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.kvadrat = new System.Windows.Forms.RadioButton();
            this.lineradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accuracytextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.RadioButton();
            this.right = new System.Windows.Forms.TextBox();
            this.hand = new System.Windows.Forms.RadioButton();
            this.left = new System.Windows.Forms.TextBox();
            this.file = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCountNumbers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OSItextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(264, 149);
            this.dataGridView1.TabIndex = 56;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox1.Text = "Ввод";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.Color.Cyan;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox2.Text = "Вычислить";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // kvadrat
            // 
            this.kvadrat.AutoSize = true;
            this.kvadrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kvadrat.Location = new System.Drawing.Point(137, 287);
            this.kvadrat.Name = "kvadrat";
            this.kvadrat.Size = new System.Drawing.Size(122, 20);
            this.kvadrat.TabIndex = 13;
            this.kvadrat.TabStop = true;
            this.kvadrat.Text = "Квадратичная";
            this.kvadrat.UseVisualStyleBackColor = true;
            // 
            // lineradioButton
            // 
            this.lineradioButton.AutoSize = true;
            this.lineradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineradioButton.Location = new System.Drawing.Point(22, 287);
            this.lineradioButton.Name = "lineradioButton";
            this.lineradioButton.Size = new System.Drawing.Size(92, 20);
            this.lineradioButton.TabIndex = 12;
            this.lineradioButton.TabStop = true;
            this.lineradioButton.Text = "Линейная";
            this.lineradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.OSItextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.accuracytextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.auto);
            this.groupBox1.Controls.Add(this.right);
            this.groupBox1.Controls.Add(this.hand);
            this.groupBox1.Controls.Add(this.left);
            this.groupBox1.Controls.Add(this.file);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxCountNumbers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(22, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 221);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки ввода";
            // 
            // accuracytextBox
            // 
            this.accuracytextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracytextBox.Location = new System.Drawing.Point(184, 164);
            this.accuracytextBox.Name = "accuracytextBox";
            this.accuracytextBox.Size = new System.Drawing.Size(70, 26);
            this.accuracytextBox.TabIndex = 10;
            this.accuracytextBox.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Точность";
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto.Location = new System.Drawing.Point(6, 79);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(107, 22);
            this.auto.TabIndex = 1;
            this.auto.TabStop = true;
            this.auto.Text = "Генерация:";
            this.auto.UseVisualStyleBackColor = true;
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right.Location = new System.Drawing.Point(184, 193);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(70, 26);
            this.right.TabIndex = 9;
            this.right.Text = "100";
            // 
            // hand
            // 
            this.hand.AutoSize = true;
            this.hand.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hand.Location = new System.Drawing.Point(6, 27);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(80, 22);
            this.hand.TabIndex = 0;
            this.hand.TabStop = true;
            this.hand.Text = "Ручной";
            this.hand.UseVisualStyleBackColor = true;
            // 
            // left
            // 
            this.left.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left.Location = new System.Drawing.Point(79, 192);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(59, 26);
            this.left.TabIndex = 8;
            this.left.Text = "5";
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file.Location = new System.Drawing.Point(6, 53);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(97, 22);
            this.file.TabIndex = 2;
            this.file.TabStop = true;
            this.file.Text = "Из файла";
            this.file.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(152, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "до";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Числа от";
            // 
            // txtBoxCountNumbers
            // 
            this.txtBoxCountNumbers.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxCountNumbers.Location = new System.Drawing.Point(183, 104);
            this.txtBoxCountNumbers.Name = "txtBoxCountNumbers";
            this.txtBoxCountNumbers.Size = new System.Drawing.Size(70, 26);
            this.txtBoxCountNumbers.TabIndex = 4;
            this.txtBoxCountNumbers.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество точек";
            // 
            // OSItextBox
            // 
            this.OSItextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OSItextBox.Location = new System.Drawing.Point(183, 134);
            this.OSItextBox.Name = "OSItextBox";
            this.OSItextBox.Size = new System.Drawing.Size(70, 26);
            this.OSItextBox.TabIndex = 12;
            this.OSItextBox.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Число точек на оси";
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(313, 45);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(461, 427);
            this.plotView1.TabIndex = 57;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.kvadrat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lineradioButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.RadioButton kvadrat;
        private System.Windows.Forms.RadioButton lineradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox accuracytextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton auto;
        private System.Windows.Forms.TextBox right;
        private System.Windows.Forms.RadioButton hand;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.RadioButton file;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCountNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OSItextBox;
        private System.Windows.Forms.Label label5;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}