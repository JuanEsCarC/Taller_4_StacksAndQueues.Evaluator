﻿namespace Evaluator.UI.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnResult = new Button();
            btnOpenParenthesis = new Button();
            btnPlus = new Button();
            btnDivide = new Button();
            btnCloseParenthesis = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnPow = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(12, 13);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(573, 51);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 84);
            btn7.Name = "btn7";
            btn7.Size = new Size(74, 55);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(102, 84);
            btn8.Name = "btn8";
            btn8.Size = new Size(74, 55);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(191, 84);
            btn9.Name = "btn9";
            btn9.Size = new Size(74, 55);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(191, 152);
            btn6.Name = "btn6";
            btn6.Size = new Size(74, 55);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(102, 152);
            btn5.Name = "btn5";
            btn5.Size = new Size(74, 55);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 152);
            btn4.Name = "btn4";
            btn4.Size = new Size(74, 55);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(191, 224);
            btn3.Name = "btn3";
            btn3.Size = new Size(74, 55);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(102, 224);
            btn2.Name = "btn2";
            btn2.Size = new Size(74, 55);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 224);
            btn1.Name = "btn1";
            btn1.Size = new Size(74, 55);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(191, 296);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(74, 55);
            btnDot.TabIndex = 12;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(12, 296);
            btn0.Name = "btn0";
            btn0.Size = new Size(164, 55);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnResult
            // 
            btnResult.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnResult.BackColor = Color.FromArgb(255, 192, 128);
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(282, 296);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(296, 55);
            btnResult.TabIndex = 16;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 192, 128);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(282, 224);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(74, 55);
            btnOpenParenthesis.TabIndex = 15;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 192, 128);
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(282, 152);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(74, 55);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 192, 128);
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(282, 84);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(74, 55);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 192, 128);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParenthesis.Location = new Point(369, 224);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(74, 55);
            btnCloseParenthesis.TabIndex = 19;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 192, 128);
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(369, 152);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(74, 55);
            btnMinus.TabIndex = 18;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 192, 128);
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(369, 84);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(74, 55);
            btnMultiply.TabIndex = 17;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnPow
            // 
            btnPow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPow.BackColor = Color.FromArgb(255, 192, 128);
            btnPow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPow.Location = new Point(458, 224);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(120, 55);
            btnPow.TabIndex = 23;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(255, 192, 128);
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(458, 152);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 55);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(255, 192, 128);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(458, 84);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 55);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(597, 373);
            Controls.Add(btnPow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnResult);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnPlus);
            Controls.Add(btnDivide);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Funtions Evaluator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDot;
        private Button btn0;
        private Button btnResult;
        private Button btnOpenParenthesis;
        private Button btnPlus;
        private Button btnDivide;
        private Button btnCloseParenthesis;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnPow;
        private Button btnClear;
        private Button btnDelete;
    }
}
