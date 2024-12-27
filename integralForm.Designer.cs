namespace Dixotomia
{
    partial class integralForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.function = new System.Windows.Forms.TextBox();
            this.interval = new System.Windows.Forms.TextBox();
            this.IntervalLimitation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpsonT = new System.Windows.Forms.CheckBox();
            this.trapezoid = new System.Windows.Forms.CheckBox();
            this.rectangle = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.simpsonResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trapezoidResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rectangleResult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.formatBox = new System.Windows.Forms.TextBox();
            this.pvGraph = new OxyPlot.WindowsForms.PlotView();
            this.lowBorder = new System.Windows.Forms.TextBox();
            this.upBorder = new System.Windows.Forms.TextBox();
            this.recViz = new System.Windows.Forms.CheckBox();
            this.simpsonViz = new System.Windows.Forms.CheckBox();
            this.trapViz = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox1.Text = "Построить";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click_1);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox2.Text = "Вычислить";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click_1);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(240, 27);
            this.toolStripTextBox3.Text = "Оптимальное число разбиений";
            this.toolStripTextBox3.Click += new System.EventHandler(this.toolStripTextBox3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 0);
            this.textBox1.TabIndex = 48;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 0);
            this.textBox2.TabIndex = 49;
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(74, 67);
            this.function.Multiline = true;
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(130, 37);
            this.function.TabIndex = 50;
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(151, 156);
            this.interval.Multiline = true;
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(53, 32);
            this.interval.TabIndex = 51;
            // 
            // IntervalLimitation
            // 
            this.IntervalLimitation.Location = new System.Drawing.Point(6, 140);
            this.IntervalLimitation.Multiline = true;
            this.IntervalLimitation.Name = "IntervalLimitation";
            this.IntervalLimitation.Size = new System.Drawing.Size(53, 28);
            this.IntervalLimitation.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "∫";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(221, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "dx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 55;
            this.label3.Text = "Число точек \r\nпостроения осей:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpsonT);
            this.groupBox1.Controls.Add(this.trapezoid);
            this.groupBox1.Controls.Add(this.rectangle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.IntervalLimitation);
            this.groupBox1.Location = new System.Drawing.Point(15, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 188);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // simpsonT
            // 
            this.simpsonT.AutoSize = true;
            this.simpsonT.Location = new System.Drawing.Point(6, 80);
            this.simpsonT.Name = "simpsonT";
            this.simpsonT.Size = new System.Drawing.Size(94, 20);
            this.simpsonT.TabIndex = 60;
            this.simpsonT.Text = "Симпсона";
            this.simpsonT.UseVisualStyleBackColor = true;
            // 
            // trapezoid
            // 
            this.trapezoid.AutoSize = true;
            this.trapezoid.Location = new System.Drawing.Point(6, 57);
            this.trapezoid.Name = "trapezoid";
            this.trapezoid.Size = new System.Drawing.Size(94, 20);
            this.trapezoid.TabIndex = 59;
            this.trapezoid.Text = "Трапеций";
            this.trapezoid.UseVisualStyleBackColor = true;
            // 
            // rectangle
            // 
            this.rectangle.AutoSize = true;
            this.rectangle.Location = new System.Drawing.Point(6, 31);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(147, 20);
            this.rectangle.TabIndex = 58;
            this.rectangle.Text = "Прямоугольников";
            this.rectangle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Число делений";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.simpsonResult);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.trapezoidResult);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rectangleResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 136);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 62;
            this.label8.Text = "Симпсона";
            // 
            // simpsonResult
            // 
            this.simpsonResult.Location = new System.Drawing.Point(141, 98);
            this.simpsonResult.Multiline = true;
            this.simpsonResult.Name = "simpsonResult";
            this.simpsonResult.Size = new System.Drawing.Size(85, 28);
            this.simpsonResult.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "Трапеций";
            // 
            // trapezoidResult
            // 
            this.trapezoidResult.Location = new System.Drawing.Point(141, 63);
            this.trapezoidResult.Multiline = true;
            this.trapezoidResult.Name = "trapezoidResult";
            this.trapezoidResult.Size = new System.Drawing.Size(85, 28);
            this.trapezoidResult.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Прямоугольников";
            // 
            // rectangleResult
            // 
            this.rectangleResult.Location = new System.Drawing.Point(142, 26);
            this.rectangleResult.Multiline = true;
            this.rectangleResult.Name = "rectangleResult";
            this.rectangleResult.Size = new System.Drawing.Size(84, 28);
            this.rectangleResult.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Точность";
            // 
            // formatBox
            // 
            this.formatBox.Location = new System.Drawing.Point(310, 156);
            this.formatBox.Multiline = true;
            this.formatBox.Name = "formatBox";
            this.formatBox.Size = new System.Drawing.Size(53, 32);
            this.formatBox.TabIndex = 63;
            // 
            // pvGraph
            // 
            this.pvGraph.Location = new System.Drawing.Point(381, 46);
            this.pvGraph.Name = "pvGraph";
            this.pvGraph.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.pvGraph.Size = new System.Drawing.Size(407, 468);
            this.pvGraph.TabIndex = 64;
            this.pvGraph.Text = "plotView1";
            this.pvGraph.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.pvGraph.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pvGraph.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // lowBorder
            // 
            this.lowBorder.Location = new System.Drawing.Point(12, 109);
            this.lowBorder.Multiline = true;
            this.lowBorder.Name = "lowBorder";
            this.lowBorder.Size = new System.Drawing.Size(53, 28);
            this.lowBorder.TabIndex = 61;
            // 
            // upBorder
            // 
            this.upBorder.Location = new System.Drawing.Point(12, 38);
            this.upBorder.Multiline = true;
            this.upBorder.Name = "upBorder";
            this.upBorder.Size = new System.Drawing.Size(53, 28);
            this.upBorder.TabIndex = 65;
            // 
            // recViz
            // 
            this.recViz.AutoSize = true;
            this.recViz.Location = new System.Drawing.Point(238, 237);
            this.recViz.Name = "recViz";
            this.recViz.Size = new System.Drawing.Size(18, 17);
            this.recViz.TabIndex = 66;
            this.recViz.UseVisualStyleBackColor = true;
            // 
            // simpsonViz
            // 
            this.simpsonViz.AutoSize = true;
            this.simpsonViz.Location = new System.Drawing.Point(238, 286);
            this.simpsonViz.Name = "simpsonViz";
            this.simpsonViz.Size = new System.Drawing.Size(18, 17);
            this.simpsonViz.TabIndex = 67;
            this.simpsonViz.UseVisualStyleBackColor = true;
            // 
            // trapViz
            // 
            this.trapViz.AutoSize = true;
            this.trapViz.Location = new System.Drawing.Point(238, 263);
            this.trapViz.Name = "trapViz";
            this.trapViz.Size = new System.Drawing.Size(18, 17);
            this.trapViz.TabIndex = 68;
            this.trapViz.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 69;
            this.label10.Text = "Визуализация";
            // 
            // integralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trapViz);
            this.Controls.Add(this.simpsonViz);
            this.Controls.Add(this.recViz);
            this.Controls.Add(this.upBorder);
            this.Controls.Add(this.lowBorder);
            this.Controls.Add(this.pvGraph);
            this.Controls.Add(this.formatBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.function);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "integralForm";
            this.Text = "integralForm";
            this.Load += new System.EventHandler(this.integralForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.TextBox IntervalLimitation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox simpsonT;
        private System.Windows.Forms.CheckBox trapezoid;
        private System.Windows.Forms.CheckBox rectangle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox simpsonResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox trapezoidResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rectangleResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox formatBox;
        private OxyPlot.WindowsForms.PlotView pvGraph;
        private System.Windows.Forms.TextBox lowBorder;
        private System.Windows.Forms.TextBox upBorder;
        private System.Windows.Forms.CheckBox recViz;
        private System.Windows.Forms.CheckBox simpsonViz;
        private System.Windows.Forms.CheckBox trapViz;
        private System.Windows.Forms.Label label10;
    }
}