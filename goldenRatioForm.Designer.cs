namespace Dixotomia
{
    partial class goldenRatioForm
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
            this.components = new System.ComponentModel.Container();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxNegativeSide = new System.Windows.Forms.TextBox();
            this.txtboxPositiveSide = new System.Windows.Forms.TextBox();
            this.txtboxNumberOfAxles = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtboxEpselon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxTo = new System.Windows.Forms.TextBox();
            this.txtboxFrom = new System.Windows.Forms.TextBox();
            this.txtboxE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxFunction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rbtnMin = new System.Windows.Forms.RadioButton();
            this.rbtnMax = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(434, 46);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(343, 351);
            this.plotView1.TabIndex = 44;
            this.plotView1.Text = "pvGraph";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Введите кол-во осей";
            // 
            // txtboxNegativeSide
            // 
            this.txtboxNegativeSide.Location = new System.Drawing.Point(14, 337);
            this.txtboxNegativeSide.Name = "txtboxNegativeSide";
            this.txtboxNegativeSide.Size = new System.Drawing.Size(111, 22);
            this.txtboxNegativeSide.TabIndex = 42;
            // 
            // txtboxPositiveSide
            // 
            this.txtboxPositiveSide.Location = new System.Drawing.Point(14, 283);
            this.txtboxPositiveSide.Name = "txtboxPositiveSide";
            this.txtboxPositiveSide.Size = new System.Drawing.Size(111, 22);
            this.txtboxPositiveSide.TabIndex = 41;
            // 
            // txtboxNumberOfAxles
            // 
            this.txtboxNumberOfAxles.Location = new System.Drawing.Point(13, 390);
            this.txtboxNumberOfAxles.Name = "txtboxNumberOfAxles";
            this.txtboxNumberOfAxles.Size = new System.Drawing.Size(111, 22);
            this.txtboxNumberOfAxles.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(276, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Введите кол-во точек для отриц.стороны";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Введите кол-во точек для полож.стороны";
            // 
            // txtboxEpselon
            // 
            this.txtboxEpselon.Location = new System.Drawing.Point(216, 221);
            this.txtboxEpselon.Name = "txtboxEpselon";
            this.txtboxEpselon.Size = new System.Drawing.Size(111, 22);
            this.txtboxEpselon.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(417, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Введите необходимую точность (число знаков после запятой)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "E=";
            // 
            // txtboxTo
            // 
            this.txtboxTo.Location = new System.Drawing.Point(216, 142);
            this.txtboxTo.Name = "txtboxTo";
            this.txtboxTo.Size = new System.Drawing.Size(111, 22);
            this.txtboxTo.TabIndex = 34;
            // 
            // txtboxFrom
            // 
            this.txtboxFrom.Location = new System.Drawing.Point(44, 142);
            this.txtboxFrom.Name = "txtboxFrom";
            this.txtboxFrom.Size = new System.Drawing.Size(111, 22);
            this.txtboxFrom.TabIndex = 33;
            // 
            // txtboxE
            // 
            this.txtboxE.Location = new System.Drawing.Point(44, 222);
            this.txtboxE.Name = "txtboxE";
            this.txtboxE.Size = new System.Drawing.Size(111, 22);
            this.txtboxE.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "e=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Введите интервал";
            // 
            // txtboxFunction
            // 
            this.txtboxFunction.Location = new System.Drawing.Point(54, 80);
            this.txtboxFunction.Name = "txtboxFunction";
            this.txtboxFunction.Size = new System.Drawing.Size(330, 22);
            this.txtboxFunction.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "f(x)=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Введите функцию";
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
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox1.Text = "Построить";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 27);
            this.toolStripTextBox2.Text = "Рассчитать";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rbtnMin);
            this.groupBox.Controls.Add(this.rbtnMax);
            this.groupBox.Location = new System.Drawing.Point(13, 434);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(111, 74);
            this.groupBox.TabIndex = 46;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Выберите";
            // 
            // rbtnMin
            // 
            this.rbtnMin.AutoSize = true;
            this.rbtnMin.Location = new System.Drawing.Point(3, 44);
            this.rbtnMin.Name = "rbtnMin";
            this.rbtnMin.Size = new System.Drawing.Size(89, 20);
            this.rbtnMin.TabIndex = 1;
            this.rbtnMin.TabStop = true;
            this.rbtnMin.Text = "Минимум";
            this.rbtnMin.UseVisualStyleBackColor = true;
            // 
            // rbtnMax
            // 
            this.rbtnMax.AutoSize = true;
            this.rbtnMax.Location = new System.Drawing.Point(3, 18);
            this.rbtnMax.Name = "rbtnMax";
            this.rbtnMax.Size = new System.Drawing.Size(95, 20);
            this.rbtnMax.TabIndex = 0;
            this.rbtnMax.TabStop = true;
            this.rbtnMax.Text = "Максимум";
            this.rbtnMax.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // goldenRatioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtboxNegativeSide);
            this.Controls.Add(this.txtboxPositiveSide);
            this.Controls.Add(this.txtboxNumberOfAxles);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtboxEpselon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtboxTo);
            this.Controls.Add(this.txtboxFrom);
            this.Controls.Add(this.txtboxE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxFunction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "goldenRatioForm";
            this.Text = "goldenRatioForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxNegativeSide;
        private System.Windows.Forms.TextBox txtboxPositiveSide;
        private System.Windows.Forms.TextBox txtboxNumberOfAxles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtboxEpselon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxTo;
        private System.Windows.Forms.TextBox txtboxFrom;
        private System.Windows.Forms.TextBox txtboxE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxFunction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rbtnMin;
        private System.Windows.Forms.RadioButton rbtnMax;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}