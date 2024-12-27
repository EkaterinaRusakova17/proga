namespace Dixotomia
{
    partial class sortingForm
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
            this.hand = new System.Windows.Forms.RadioButton();
            this.auto = new System.Windows.Forms.RadioButton();
            this.file = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxCountNumbers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.TextBox();
            this.right = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doubl = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.swamp = new System.Windows.Forms.CheckBox();
            this.insert = new System.Windows.Forms.CheckBox();
            this.shake = new System.Windows.Forms.CheckBox();
            this.fast = new System.Windows.Forms.CheckBox();
            this.bubble = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxIter = new System.Windows.Forms.TextBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.increase = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iterations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hand
            // 
            this.hand.AutoSize = true;
            this.hand.Location = new System.Drawing.Point(6, 27);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(77, 20);
            this.hand.TabIndex = 0;
            this.hand.TabStop = true;
            this.hand.Text = "Ручной";
            this.hand.UseVisualStyleBackColor = true;
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.Location = new System.Drawing.Point(6, 79);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(101, 20);
            this.auto.TabIndex = 1;
            this.auto.TabStop = true;
            this.auto.Text = "Генерация:";
            this.auto.UseVisualStyleBackColor = true;
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(6, 53);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(92, 20);
            this.file.TabIndex = 2;
            this.file.TabStop = true;
            this.file.Text = "Из файла";
            this.file.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выбор пути";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxCountNumbers
            // 
            this.txtBoxCountNumbers.Location = new System.Drawing.Point(143, 107);
            this.txtBoxCountNumbers.Name = "txtBoxCountNumbers";
            this.txtBoxCountNumbers.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCountNumbers.TabIndex = 4;
            this.txtBoxCountNumbers.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество чисел ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "от";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "до";
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(32, 140);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 22);
            this.left.TabIndex = 8;
            this.left.Text = "0";
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(167, 140);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(76, 22);
            this.right.TabIndex = 9;
            this.right.Text = "1000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.auto);
            this.groupBox1.Controls.Add(this.right);
            this.groupBox1.Controls.Add(this.hand);
            this.groupBox1.Controls.Add(this.left);
            this.groupBox1.Controls.Add(this.file);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxCountNumbers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 194);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки ввода";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doubl);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(22, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Генерировать";
            // 
            // doubl
            // 
            this.doubl.AutoSize = true;
            this.doubl.Location = new System.Drawing.Point(159, 29);
            this.doubl.Name = "doubl";
            this.doubl.Size = new System.Drawing.Size(86, 20);
            this.doubl.TabIndex = 13;
            this.doubl.TabStop = true;
            this.doubl.Text = "Дробные";
            this.doubl.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 29);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 20);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Целые";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // swamp
            // 
            this.swamp.AutoSize = true;
            this.swamp.Location = new System.Drawing.Point(6, 31);
            this.swamp.Name = "swamp";
            this.swamp.Size = new System.Drawing.Size(92, 20);
            this.swamp.TabIndex = 12;
            this.swamp.Text = "Болотная";
            this.swamp.UseVisualStyleBackColor = true;
            // 
            // insert
            // 
            this.insert.AutoSize = true;
            this.insert.Location = new System.Drawing.Point(6, 139);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(100, 20);
            this.insert.TabIndex = 13;
            this.insert.Text = "Вставками";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // shake
            // 
            this.shake.AutoSize = true;
            this.shake.Location = new System.Drawing.Point(6, 113);
            this.shake.Name = "shake";
            this.shake.Size = new System.Drawing.Size(102, 20);
            this.shake.TabIndex = 14;
            this.shake.Text = "Шейкерная";
            this.shake.UseVisualStyleBackColor = true;
            // 
            // fast
            // 
            this.fast.AutoSize = true;
            this.fast.Location = new System.Drawing.Point(6, 84);
            this.fast.Name = "fast";
            this.fast.Size = new System.Drawing.Size(84, 20);
            this.fast.TabIndex = 15;
            this.fast.Text = "Быстрая";
            this.fast.UseVisualStyleBackColor = true;
            // 
            // bubble
            // 
            this.bubble.AutoSize = true;
            this.bubble.Location = new System.Drawing.Point(6, 56);
            this.bubble.Name = "bubble";
            this.bubble.Size = new System.Drawing.Size(117, 20);
            this.bubble.TabIndex = 16;
            this.bubble.Text = "Пузырьковая";
            this.bubble.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Сортировка по:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.maxIter);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.increase);
            this.groupBox3.Controls.Add(this.swamp);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.insert);
            this.groupBox3.Controls.Add(this.bubble);
            this.groupBox3.Controls.Add(this.shake);
            this.groupBox3.Controls.Add(this.fast);
            this.groupBox3.Location = new System.Drawing.Point(330, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 271);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сортировки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Максимум итераций";
            // 
            // maxIter
            // 
            this.maxIter.Location = new System.Drawing.Point(151, 31);
            this.maxIter.Name = "maxIter";
            this.maxIter.Size = new System.Drawing.Size(76, 22);
            this.maxIter.TabIndex = 10;
            this.maxIter.Text = "1000";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(165, 229);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(96, 20);
            this.radioButton7.TabIndex = 18;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Убыванию";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // increase
            // 
            this.increase.AutoSize = true;
            this.increase.Location = new System.Drawing.Point(6, 229);
            this.increase.Name = "increase";
            this.increase.Size = new System.Drawing.Size(117, 20);
            this.increase.TabIndex = 14;
            this.increase.TabStop = true;
            this.increase.Text = "Возрастанию";
            this.increase.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(656, 38);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(238, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(656, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 386);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Числа для сортировки";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Method,
            this.Iterations,
            this.Time,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(22, 330);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(575, 150);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Method
            // 
            this.Method.HeaderText = "Метод";
            this.Method.MinimumWidth = 6;
            this.Method.Name = "Method";
            this.Method.Width = 125;
            // 
            // Iterations
            // 
            this.Iterations.HeaderText = "Итерации";
            this.Iterations.MinimumWidth = 6;
            this.Iterations.Name = "Iterations";
            this.Iterations.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Открыть файл";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1082, 31);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox1.Text = "Ввод";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox2.Text = "Сортировать";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 684);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "sortingForm";
            this.Text = "sortingFormcs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton hand;
        private System.Windows.Forms.RadioButton auto;
        private System.Windows.Forms.RadioButton file;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxCountNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.TextBox right;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton doubl;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox swamp;
        private System.Windows.Forms.CheckBox insert;
        private System.Windows.Forms.CheckBox shake;
        private System.Windows.Forms.CheckBox fast;
        private System.Windows.Forms.CheckBox bubble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox maxIter;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton increase;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iterations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}