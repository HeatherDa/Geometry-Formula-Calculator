namespace Common_Geometery_Formulas_Calculator
{
    partial class Form1
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
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.rbtnSquare = new System.Windows.Forms.RadioButton();
            this.rbtnParallelogram = new System.Windows.Forms.RadioButton();
            this.rbtnRhombus = new System.Windows.Forms.RadioButton();
            this.rbtnTriangle = new System.Windows.Forms.RadioButton();
            this.rbtnTrapezoid = new System.Windows.Forms.RadioButton();
            this.rbtnCircle = new System.Windows.Forms.RadioButton();
            this.rbtnArea = new System.Windows.Forms.RadioButton();
            this.rbtnPerimeter = new System.Windows.Forms.RadioButton();
            this.rbtnAreaPerimeter = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInput4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.AutoSize = true;
            this.rbtnRectangle.Location = new System.Drawing.Point(6, 11);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbtnRectangle.TabIndex = 0;
            this.rbtnRectangle.TabStop = true;
            this.rbtnRectangle.Text = "Rectangle";
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            this.rbtnRectangle.CheckedChanged += new System.EventHandler(this.rbtnRectangle_CheckedChanged);
            // 
            // rbtnSquare
            // 
            this.rbtnSquare.AutoSize = true;
            this.rbtnSquare.Location = new System.Drawing.Point(101, 11);
            this.rbtnSquare.Name = "rbtnSquare";
            this.rbtnSquare.Size = new System.Drawing.Size(59, 17);
            this.rbtnSquare.TabIndex = 1;
            this.rbtnSquare.TabStop = true;
            this.rbtnSquare.Text = "Square";
            this.rbtnSquare.UseVisualStyleBackColor = true;
            this.rbtnSquare.CheckedChanged += new System.EventHandler(this.rbtnSquare_CheckedChanged);
            // 
            // rbtnParallelogram
            // 
            this.rbtnParallelogram.AutoSize = true;
            this.rbtnParallelogram.Location = new System.Drawing.Point(6, 80);
            this.rbtnParallelogram.Name = "rbtnParallelogram";
            this.rbtnParallelogram.Size = new System.Drawing.Size(88, 17);
            this.rbtnParallelogram.TabIndex = 2;
            this.rbtnParallelogram.TabStop = true;
            this.rbtnParallelogram.Text = "Parallelogram";
            this.rbtnParallelogram.UseVisualStyleBackColor = true;
            this.rbtnParallelogram.CheckedChanged += new System.EventHandler(this.rbtnParallelogram_CheckedChanged);
            // 
            // rbtnRhombus
            // 
            this.rbtnRhombus.AutoSize = true;
            this.rbtnRhombus.Location = new System.Drawing.Point(101, 57);
            this.rbtnRhombus.Name = "rbtnRhombus";
            this.rbtnRhombus.Size = new System.Drawing.Size(70, 17);
            this.rbtnRhombus.TabIndex = 3;
            this.rbtnRhombus.TabStop = true;
            this.rbtnRhombus.Text = "Rhombus";
            this.rbtnRhombus.UseVisualStyleBackColor = true;
            this.rbtnRhombus.CheckedChanged += new System.EventHandler(this.rbtnRhombus_CheckedChanged);
            // 
            // rbtnTriangle
            // 
            this.rbtnTriangle.AutoSize = true;
            this.rbtnTriangle.Location = new System.Drawing.Point(6, 34);
            this.rbtnTriangle.Name = "rbtnTriangle";
            this.rbtnTriangle.Size = new System.Drawing.Size(63, 17);
            this.rbtnTriangle.TabIndex = 4;
            this.rbtnTriangle.TabStop = true;
            this.rbtnTriangle.Text = "Triangle";
            this.rbtnTriangle.UseVisualStyleBackColor = true;
            this.rbtnTriangle.CheckedChanged += new System.EventHandler(this.rbtnTriangle_CheckedChanged);
            // 
            // rbtnTrapezoid
            // 
            this.rbtnTrapezoid.AutoSize = true;
            this.rbtnTrapezoid.Location = new System.Drawing.Point(6, 57);
            this.rbtnTrapezoid.Name = "rbtnTrapezoid";
            this.rbtnTrapezoid.Size = new System.Drawing.Size(72, 17);
            this.rbtnTrapezoid.TabIndex = 5;
            this.rbtnTrapezoid.TabStop = true;
            this.rbtnTrapezoid.Text = "Trapezoid";
            this.rbtnTrapezoid.UseVisualStyleBackColor = true;
            this.rbtnTrapezoid.CheckedChanged += new System.EventHandler(this.rbtnTrapezoid_CheckedChanged);
            // 
            // rbtnCircle
            // 
            this.rbtnCircle.AutoSize = true;
            this.rbtnCircle.Location = new System.Drawing.Point(101, 34);
            this.rbtnCircle.Name = "rbtnCircle";
            this.rbtnCircle.Size = new System.Drawing.Size(51, 17);
            this.rbtnCircle.TabIndex = 6;
            this.rbtnCircle.TabStop = true;
            this.rbtnCircle.Text = "Circle";
            this.rbtnCircle.UseVisualStyleBackColor = true;
            this.rbtnCircle.CheckedChanged += new System.EventHandler(this.rbtnCircle_CheckedChanged);
            // 
            // rbtnArea
            // 
            this.rbtnArea.AutoSize = true;
            this.rbtnArea.Location = new System.Drawing.Point(19, 126);
            this.rbtnArea.Name = "rbtnArea";
            this.rbtnArea.Size = new System.Drawing.Size(47, 17);
            this.rbtnArea.TabIndex = 7;
            this.rbtnArea.TabStop = true;
            this.rbtnArea.Text = "Area";
            this.rbtnArea.UseVisualStyleBackColor = true;
            this.rbtnArea.CheckedChanged += new System.EventHandler(this.rbtnArea_CheckedChanged);
            // 
            // rbtnPerimeter
            // 
            this.rbtnPerimeter.AutoSize = true;
            this.rbtnPerimeter.Location = new System.Drawing.Point(18, 148);
            this.rbtnPerimeter.Name = "rbtnPerimeter";
            this.rbtnPerimeter.Size = new System.Drawing.Size(69, 17);
            this.rbtnPerimeter.TabIndex = 8;
            this.rbtnPerimeter.TabStop = true;
            this.rbtnPerimeter.Text = "Perimeter";
            this.rbtnPerimeter.UseVisualStyleBackColor = true;
            this.rbtnPerimeter.CheckedChanged += new System.EventHandler(this.rbtnPerimeter_CheckedChanged);
            // 
            // rbtnAreaPerimeter
            // 
            this.rbtnAreaPerimeter.AutoSize = true;
            this.rbtnAreaPerimeter.Location = new System.Drawing.Point(19, 171);
            this.rbtnAreaPerimeter.Name = "rbtnAreaPerimeter";
            this.rbtnAreaPerimeter.Size = new System.Drawing.Size(115, 17);
            this.rbtnAreaPerimeter.TabIndex = 9;
            this.rbtnAreaPerimeter.TabStop = true;
            this.rbtnAreaPerimeter.Text = "Area and Perimeter";
            this.rbtnAreaPerimeter.UseVisualStyleBackColor = true;
            this.rbtnAreaPerimeter.CheckedChanged += new System.EventHandler(this.rbtnAreaPerimeter_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(41, 328);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(164, 328);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(75, 23);
            this.btnAC.TabIndex = 11;
            this.btnAC.Text = "All Clear";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(290, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(201, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 175);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(67, 280);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.ReadOnly = true;
            this.txtAnswer1.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer1.TabIndex = 14;
            this.txtAnswer1.TextChanged += new System.EventHandler(this.txtAnswer1_TextChanged);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(12, 283);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(47, 13);
            this.lblAnswer1.TabIndex = 15;
            this.lblAnswer1.Text = "answer1";
            this.lblAnswer1.Click += new System.EventHandler(this.lblAnswer1_Click);
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(190, 286);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(47, 13);
            this.lblAnswer2.TabIndex = 16;
            this.lblAnswer2.Text = "answer2";
            this.lblAnswer2.Click += new System.EventHandler(this.lblAnswer2_Click);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(253, 280);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.ReadOnly = true;
            this.txtAnswer2.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer2.TabIndex = 17;
            this.txtAnswer2.TextChanged += new System.EventHandler(this.txtAnswer2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(67, 202);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(100, 20);
            this.txtInput1.TabIndex = 19;
            this.txtInput1.TextChanged += new System.EventHandler(this.txtInput1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(253, 203);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(100, 20);
            this.txtInput2.TabIndex = 21;
            this.txtInput2.TextChanged += new System.EventHandler(this.txtInput2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtInput3
            // 
            this.txtInput3.Location = new System.Drawing.Point(67, 241);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(100, 20);
            this.txtInput3.TabIndex = 23;
            this.txtInput3.TextChanged += new System.EventHandler(this.txtInput3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtInput4
            // 
            this.txtInput4.Location = new System.Drawing.Point(253, 241);
            this.txtInput4.Name = "txtInput4";
            this.txtInput4.Size = new System.Drawing.Size(100, 20);
            this.txtInput4.TabIndex = 25;
            this.txtInput4.TextChanged += new System.EventHandler(this.txtInput4_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCircle);
            this.groupBox1.Controls.Add(this.rbtnTrapezoid);
            this.groupBox1.Controls.Add(this.rbtnTriangle);
            this.groupBox1.Controls.Add(this.rbtnParallelogram);
            this.groupBox1.Controls.Add(this.rbtnSquare);
            this.groupBox1.Controls.Add(this.rbtnRectangle);
            this.groupBox1.Controls.Add(this.rbtnRhombus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 103);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(407, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInput4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbtnAreaPerimeter);
            this.Controls.Add(this.rbtnPerimeter);
            this.Controls.Add(this.rbtnArea);
            this.Name = "Form1";
            this.Text = "Common Geometery Formulas Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.RadioButton rbtnSquare;
        private System.Windows.Forms.RadioButton rbtnParallelogram;
        private System.Windows.Forms.RadioButton rbtnRhombus;
        private System.Windows.Forms.RadioButton rbtnTriangle;
        private System.Windows.Forms.RadioButton rbtnTrapezoid;
        private System.Windows.Forms.RadioButton rbtnCircle;
        private System.Windows.Forms.RadioButton rbtnArea;
        private System.Windows.Forms.RadioButton rbtnPerimeter;
        private System.Windows.Forms.RadioButton rbtnAreaPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInput4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

