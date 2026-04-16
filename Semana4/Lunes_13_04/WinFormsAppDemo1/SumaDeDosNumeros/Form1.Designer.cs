namespace SumaDeDosNumeros
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_limpiar = new Button();
            button_calcular = new Button();
            button_salir = new Button();
            textBox_primer = new TextBox();
            textBox_segundo = new TextBox();
            label_resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 50);
            label1.Name = "label1";
            label1.Size = new Size(333, 34);
            label1.TabIndex = 0;
            label1.Text = "Suma de Dos Numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 146);
            label2.Name = "label2";
            label2.Size = new Size(157, 26);
            label2.TabIndex = 1;
            label2.Text = "Primer Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(90, 214);
            label3.Name = "label3";
            label3.Size = new Size(171, 26);
            label3.TabIndex = 2;
            label3.Text = "Segundo Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(156, 287);
            label4.Name = "label4";
            label4.Size = new Size(105, 26);
            label4.TabIndex = 3;
            label4.Text = "Resultado";
            // 
            // button_limpiar
            // 
            button_limpiar.BackColor = Color.Chartreuse;
            button_limpiar.Location = new Point(115, 370);
            button_limpiar.Name = "button_limpiar";
            button_limpiar.Size = new Size(109, 40);
            button_limpiar.TabIndex = 4;
            button_limpiar.Text = "Limpiar";
            button_limpiar.UseVisualStyleBackColor = false;
            button_limpiar.Click += button_limpiar_Click;
            // 
            // button_calcular
            // 
            button_calcular.BackColor = Color.Turquoise;
            button_calcular.Location = new Point(360, 368);
            button_calcular.Name = "button_calcular";
            button_calcular.Size = new Size(115, 41);
            button_calcular.TabIndex = 5;
            button_calcular.Text = "Calcular";
            button_calcular.UseVisualStyleBackColor = false;
            button_calcular.Click += button_calcular_Click;
            // 
            // button_salir
            // 
            button_salir.BackColor = Color.Red;
            button_salir.Location = new Point(626, 370);
            button_salir.Name = "button_salir";
            button_salir.Size = new Size(118, 39);
            button_salir.TabIndex = 6;
            button_salir.Text = "Salir";
            button_salir.UseVisualStyleBackColor = false;
            button_salir.Click += button_salir_Click;
            // 
            // textBox_primer
            // 
            textBox_primer.Location = new Point(318, 147);
            textBox_primer.Name = "textBox_primer";
            textBox_primer.Size = new Size(213, 27);
            textBox_primer.TabIndex = 7;
            // 
            // textBox_segundo
            // 
            textBox_segundo.Location = new Point(318, 215);
            textBox_segundo.Name = "textBox_segundo";
            textBox_segundo.Size = new Size(213, 27);
            textBox_segundo.TabIndex = 8;
            // 
            // label_resultado
            // 
            label_resultado.AutoSize = true;
            label_resultado.Location = new Point(318, 288);
            label_resultado.Name = "label_resultado";
            label_resultado.Size = new Size(0, 20);
            label_resultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 494);
            Controls.Add(label_resultado);
            Controls.Add(textBox_segundo);
            Controls.Add(textBox_primer);
            Controls.Add(button_salir);
            Controls.Add(button_calcular);
            Controls.Add(button_limpiar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_limpiar;
        private Button button_calcular;
        private Button button_salir;
        private TextBox textBox_primer;
        private TextBox textBox_segundo;
        private Label label_resultado;
    }
}
