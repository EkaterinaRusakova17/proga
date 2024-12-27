namespace Dixotomia
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxFunction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxE = new System.Windows.Forms.TextBox();
            this.txtboxFrom = new System.Windows.Forms.TextBox();
            this.txtboxTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxEpselon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxNumberOfAxles = new System.Windows.Forms.TextBox();
            this.txtboxPositiveSide = new System.Windows.Forms.TextBox();
            this.txtboxNegativeSide = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите функцию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "f(x)=";
            // 
            // txtboxFunction
            // 
            this.txtboxFunction.Location = new System.Drawing.Point(54, 100);
            this.txtboxFunction.Name = "txtboxFunction";
            this.txtboxFunction.Size = new System.Drawing.Size(330, 22);
            this.txtboxFunction.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите интервал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "до";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "от";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "e=";
            // 
            // txtboxE
            // 
            this.txtboxE.Location = new System.Drawing.Point(44, 242);
            this.txtboxE.Name = "txtboxE";
            this.txtboxE.Size = new System.Drawing.Size(111, 22);
            this.txtboxE.TabIndex = 9;
            // 
            // txtboxFrom
            // 
            this.txtboxFrom.Location = new System.Drawing.Point(44, 162);
            this.txtboxFrom.Name = "txtboxFrom";
            this.txtboxFrom.Size = new System.Drawing.Size(111, 22);
            this.txtboxFrom.TabIndex = 10;
            // 
            // txtboxTo
            // 
            this.txtboxTo.Location = new System.Drawing.Point(216, 162);
            this.txtboxTo.Name = "txtboxTo";
            this.txtboxTo.Size = new System.Drawing.Size(111, 22);
            this.txtboxTo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "E=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(417, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Введите необходимую точность (число знаков после запятой)";
            // 
            // txtboxEpselon
            // 
            this.txtboxEpselon.Location = new System.Drawing.Point(216, 241);
            this.txtboxEpselon.Name = "txtboxEpselon";
            this.txtboxEpselon.Size = new System.Drawing.Size(111, 22);
            this.txtboxEpselon.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Введите кол-во точек для полож.стороны";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(276, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Введите кол-во точек для отриц.стороны";
            // 
            // txtboxNumberOfAxles
            // 
            this.txtboxNumberOfAxles.Location = new System.Drawing.Point(13, 410);
            this.txtboxNumberOfAxles.Name = "txtboxNumberOfAxles";
            this.txtboxNumberOfAxles.Size = new System.Drawing.Size(111, 22);
            this.txtboxNumberOfAxles.TabIndex = 19;
            // 
            // txtboxPositiveSide
            // 
            this.txtboxPositiveSide.Location = new System.Drawing.Point(14, 303);
            this.txtboxPositiveSide.Name = "txtboxPositiveSide";
            this.txtboxPositiveSide.Size = new System.Drawing.Size(111, 22);
            this.txtboxPositiveSide.TabIndex = 20;
            // 
            // txtboxNegativeSide
            // 
            this.txtboxNegativeSide.Location = new System.Drawing.Point(14, 357);
            this.txtboxNegativeSide.Name = "txtboxNegativeSide";
            this.txtboxNegativeSide.Size = new System.Drawing.Size(111, 22);
            this.txtboxNegativeSide.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Введите кол-во осей";
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(434, 66);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(343, 351);
            this.plotView1.TabIndex = 23;
            this.plotView1.Text = "pvGraph";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 31);
            this.menuStrip1.TabIndex = 24;
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
            this.toolStripTextBox2.Text = "Рассчитать";
            this.toolStripTextBox2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxFunction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxE;
        private System.Windows.Forms.TextBox txtboxFrom;
        private System.Windows.Forms.TextBox txtboxTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxEpselon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxNumberOfAxles;
        private System.Windows.Forms.TextBox txtboxPositiveSide;
        private System.Windows.Forms.TextBox txtboxNegativeSide;
        private System.Windows.Forms.Label label9;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}