namespace MathQuiz_WindowsFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlusLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPlusRight = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.Difference = new System.Windows.Forms.NumericUpDown();
            this.lblMinusRight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMinusLeft = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.NumericUpDown();
            this.lblTimesRight = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTimesLeft = new System.Windows.Forms.Label();
            this.Quotient = new System.Windows.Forms.NumericUpDown();
            this.lblRightDivide = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLeftDivide = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(262, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 37);
            this.lblTime.TabIndex = 0;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // lblPlusLeft
            // 
            this.lblPlusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusLeft.Location = new System.Drawing.Point(50, 51);
            this.lblPlusLeft.Name = "lblPlusLeft";
            this.lblPlusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblPlusLeft.TabIndex = 2;
            this.lblPlusLeft.Text = "?";
            this.lblPlusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlusRight
            // 
            this.lblPlusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusRight.Location = new System.Drawing.Point(182, 51);
            this.lblPlusRight.Name = "lblPlusRight";
            this.lblPlusRight.Size = new System.Drawing.Size(60, 50);
            this.lblPlusRight.TabIndex = 5;
            this.lblPlusRight.Text = "?";
            this.lblPlusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(314, 51);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 48);
            this.Sum.TabIndex = 1;
            //this.Sum.ValueChanged += new System.EventHandler(this.Sum_ValueChanged);
            this.Sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // Difference
            // 
            this.Difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difference.Location = new System.Drawing.Point(314, 115);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(100, 48);
            this.Difference.TabIndex = 2;
            this.Difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // lblMinusRight
            // 
            this.lblMinusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusRight.Location = new System.Drawing.Point(182, 115);
            this.lblMinusRight.Name = "lblMinusRight";
            this.lblMinusRight.Size = new System.Drawing.Size(60, 50);
            this.lblMinusRight.TabIndex = 10;
            this.lblMinusRight.Text = "?";
            this.lblMinusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinusLeft
            // 
            this.lblMinusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusLeft.Location = new System.Drawing.Point(50, 115);
            this.lblMinusLeft.Name = "lblMinusLeft";
            this.lblMinusLeft.Size = new System.Drawing.Size(60, 50);
            this.lblMinusLeft.TabIndex = 7;
            this.lblMinusLeft.Text = "?";
            this.lblMinusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(314, 177);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(100, 48);
            this.Product.TabIndex = 3;
            // 
            // lblTimesRight
            // 
            this.lblTimesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesRight.Location = new System.Drawing.Point(182, 177);
            this.lblTimesRight.Name = "lblTimesRight";
            this.lblTimesRight.Size = new System.Drawing.Size(60, 50);
            this.lblTimesRight.TabIndex = 15;
            this.lblTimesRight.Text = "?";
            this.lblTimesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 14;
            this.label7.Text = "×";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 13;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimesLeft
            // 
            this.lblTimesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesLeft.Location = new System.Drawing.Point(50, 177);
            this.lblTimesLeft.Name = "lblTimesLeft";
            this.lblTimesLeft.Size = new System.Drawing.Size(60, 50);
            this.lblTimesLeft.TabIndex = 12;
            this.lblTimesLeft.Text = "?";
            this.lblTimesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quotient
            // 
            this.Quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quotient.Location = new System.Drawing.Point(314, 242);
            this.Quotient.Name = "Quotient";
            this.Quotient.Size = new System.Drawing.Size(100, 48);
            this.Quotient.TabIndex = 4;
            // 
            // lblRightDivide
            // 
            this.lblRightDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightDivide.Location = new System.Drawing.Point(182, 242);
            this.lblRightDivide.Name = "lblRightDivide";
            this.lblRightDivide.Size = new System.Drawing.Size(60, 50);
            this.lblRightDivide.TabIndex = 20;
            this.lblRightDivide.Text = "?";
            this.lblRightDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(116, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 19;
            this.label11.Text = "÷";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(248, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 18;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftDivide
            // 
            this.lblLeftDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftDivide.Location = new System.Drawing.Point(50, 242);
            this.lblLeftDivide.Name = "lblLeftDivide";
            this.lblLeftDivide.Size = new System.Drawing.Size(60, 50);
            this.lblLeftDivide.TabIndex = 17;
            this.lblLeftDivide.Text = "?";
            this.lblLeftDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnStart
            // 
            this.BtnStart.AutoSize = true;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(23, 312);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(197, 42);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start the Quiz";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(255, 312);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(197, 42);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 390);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Quotient);
            this.Controls.Add(this.lblRightDivide);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblLeftDivide);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.lblTimesRight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTimesLeft);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.lblMinusRight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMinusLeft);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.lblPlusRight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlusLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Prueba Matematica";
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlusLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPlusRight;
        private System.Windows.Forms.NumericUpDown Sum;
        private System.Windows.Forms.NumericUpDown Difference;
        private System.Windows.Forms.Label lblMinusRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMinusLeft;
        private System.Windows.Forms.NumericUpDown Product;
        private System.Windows.Forms.Label lblTimesRight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTimesLeft;
        private System.Windows.Forms.NumericUpDown Quotient;
        private System.Windows.Forms.Label lblRightDivide;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLeftDivide;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSalir;
    }
}

