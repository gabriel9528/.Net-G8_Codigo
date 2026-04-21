namespace TresEnRaya
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            buttonExit = new Button();
            buttonReset = new Button();
            buttonNewGame = new Button();
            panel4 = new Panel();
            labelPlayer0 = new Label();
            labelPlayerX = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(20, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(985, 57);
            label1.TabIndex = 0;
            label1.Text = "JUEGO TIC TAC TOC - WINDOWS FORMS";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(23, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(1027, 525);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonExit);
            panel5.Controls.Add(buttonReset);
            panel5.Controls.Add(buttonNewGame);
            panel5.Location = new Point(536, 249);
            panel5.Name = "panel5";
            panel5.Size = new Size(464, 267);
            panel5.TabIndex = 2;
            panel5.Paint += panel5_Paint;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(236, 128);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(211, 105);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += button10_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(14, 128);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(216, 104);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNewGame.Location = new Point(14, 12);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(433, 110);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "New Game";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(labelPlayer0);
            panel4.Controls.Add(labelPlayerX);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(536, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(464, 229);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // labelPlayer0
            // 
            labelPlayer0.AutoSize = true;
            labelPlayer0.BackColor = Color.White;
            labelPlayer0.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer0.Location = new Point(357, 128);
            labelPlayer0.Name = "labelPlayer0";
            labelPlayer0.Size = new Size(70, 81);
            labelPlayer0.TabIndex = 3;
            labelPlayer0.Text = "0";
            // 
            // labelPlayerX
            // 
            labelPlayerX.AutoSize = true;
            labelPlayerX.BackColor = Color.White;
            labelPlayerX.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayerX.Location = new Point(357, 19);
            labelPlayerX.Name = "labelPlayerX";
            labelPlayerX.Size = new Size(70, 81);
            labelPlayerX.TabIndex = 2;
            labelPlayerX.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 128);
            label3.Name = "label3";
            label3.Size = new Size(333, 81);
            label3.TabIndex = 1;
            label3.Text = "PLAYER 0 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 19);
            label2.Name = "label2";
            label2.Size = new Size(337, 81);
            label2.TabIndex = 0;
            label2.Text = "PLAYER X :";
            // 
            // panel3
            // 
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(13, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(517, 513);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // button9
            // 
            button9.Location = new Point(339, 338);
            button9.Name = "button9";
            button9.Size = new Size(160, 160);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(173, 338);
            button8.Name = "button8";
            button8.Size = new Size(160, 160);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(6, 338);
            button7.Name = "button7";
            button7.Size = new Size(160, 160);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(339, 172);
            button6.Name = "button6";
            button6.Size = new Size(160, 160);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(173, 172);
            button5.Name = "button5";
            button5.Size = new Size(160, 160);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 172);
            button4.Name = "button4";
            button4.Size = new Size(160, 160);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(339, 6);
            button3.Name = "button3";
            button3.Size = new Size(160, 160);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(173, 6);
            button2.Name = "button2";
            button2.Size = new Size(160, 160);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 6);
            button1.Name = "button1";
            button1.Size = new Size(160, 160);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1069, 655);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Tag = "Tres en Raya";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label labelPlayerX;
        private Label label3;
        private Label label2;
        private Label labelPlayer0;
        private Button buttonReset;
        private Button buttonNewGame;
        private Button buttonExit;
    }
}
