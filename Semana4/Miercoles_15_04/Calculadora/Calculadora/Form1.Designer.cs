namespace Calculadora
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
            textBoxResultado = new TextBox();
            buttonBorrarUltimo = new Button();
            buttonBorrarTodo = new Button();
            buttonRecorrer = new Button();
            buttonRaizCuadrada = new Button();
            buttonElevarCuadrado = new Button();
            buttonSiete = new Button();
            buttonNueve = new Button();
            buttonOcho = new Button();
            buttonCinco = new Button();
            buttonCuatro = new Button();
            buttonSeis = new Button();
            buttonUno = new Button();
            buttonDos = new Button();
            buttonTres = new Button();
            buttonSigno = new Button();
            buttonCero = new Button();
            buttonPunto = new Button();
            buttonDivision = new Button();
            buttonMultiplicar = new Button();
            buttonMas = new Button();
            buttonMenos = new Button();
            buttonIgual = new Button();
            SuspendLayout();
            // 
            // textBoxResultado
            // 
            textBoxResultado.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxResultado.Location = new Point(56, 21);
            textBoxResultado.MaxLength = 10;
            textBoxResultado.Multiline = true;
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.RightToLeft = RightToLeft.Yes;
            textBoxResultado.Size = new Size(567, 77);
            textBoxResultado.TabIndex = 0;
            textBoxResultado.Text = "0";
            // 
            // buttonBorrarUltimo
            // 
            buttonBorrarUltimo.BackColor = SystemColors.ScrollBar;
            buttonBorrarUltimo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBorrarUltimo.Location = new Point(60, 118);
            buttonBorrarUltimo.Name = "buttonBorrarUltimo";
            buttonBorrarUltimo.Size = new Size(60, 60);
            buttonBorrarUltimo.TabIndex = 1;
            buttonBorrarUltimo.Text = "CE";
            buttonBorrarUltimo.UseVisualStyleBackColor = false;
            buttonBorrarUltimo.Click += buttonBorrarUltimo_Click;
            // 
            // buttonBorrarTodo
            // 
            buttonBorrarTodo.BackColor = SystemColors.ScrollBar;
            buttonBorrarTodo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBorrarTodo.Location = new Point(178, 118);
            buttonBorrarTodo.Name = "buttonBorrarTodo";
            buttonBorrarTodo.Size = new Size(60, 60);
            buttonBorrarTodo.TabIndex = 2;
            buttonBorrarTodo.Text = "C";
            buttonBorrarTodo.UseVisualStyleBackColor = false;
            buttonBorrarTodo.Click += buttonBorrarTodo_Click;
            // 
            // buttonRecorrer
            // 
            buttonRecorrer.BackColor = SystemColors.ScrollBar;
            buttonRecorrer.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRecorrer.Location = new Point(306, 118);
            buttonRecorrer.Name = "buttonRecorrer";
            buttonRecorrer.Size = new Size(60, 60);
            buttonRecorrer.TabIndex = 3;
            buttonRecorrer.Text = "<-";
            buttonRecorrer.UseVisualStyleBackColor = false;
            buttonRecorrer.Click += buttonRecorrer_Click;
            // 
            // buttonRaizCuadrada
            // 
            buttonRaizCuadrada.BackColor = SystemColors.ScrollBar;
            buttonRaizCuadrada.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRaizCuadrada.Location = new Point(451, 118);
            buttonRaizCuadrada.Name = "buttonRaizCuadrada";
            buttonRaizCuadrada.Size = new Size(60, 60);
            buttonRaizCuadrada.TabIndex = 4;
            buttonRaizCuadrada.Tag = "√";
            buttonRaizCuadrada.Text = "√";
            buttonRaizCuadrada.UseVisualStyleBackColor = false;
            buttonRaizCuadrada.Click += AgregarOperador;
            // 
            // buttonElevarCuadrado
            // 
            buttonElevarCuadrado.BackColor = SystemColors.ScrollBar;
            buttonElevarCuadrado.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonElevarCuadrado.Location = new Point(563, 118);
            buttonElevarCuadrado.Name = "buttonElevarCuadrado";
            buttonElevarCuadrado.Size = new Size(60, 60);
            buttonElevarCuadrado.TabIndex = 5;
            buttonElevarCuadrado.Tag = "²";
            buttonElevarCuadrado.Text = "x²";
            buttonElevarCuadrado.UseVisualStyleBackColor = false;
            buttonElevarCuadrado.Click += AgregarOperador;
            // 
            // buttonSiete
            // 
            buttonSiete.BackColor = SystemColors.ScrollBar;
            buttonSiete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSiete.Location = new Point(60, 220);
            buttonSiete.Name = "buttonSiete";
            buttonSiete.Size = new Size(60, 60);
            buttonSiete.TabIndex = 6;
            buttonSiete.Text = "7";
            buttonSiete.UseVisualStyleBackColor = false;
            buttonSiete.Click += AgregarNumero;
            // 
            // buttonNueve
            // 
            buttonNueve.BackColor = SystemColors.ScrollBar;
            buttonNueve.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNueve.Location = new Point(306, 220);
            buttonNueve.Name = "buttonNueve";
            buttonNueve.Size = new Size(60, 60);
            buttonNueve.TabIndex = 7;
            buttonNueve.Text = "9";
            buttonNueve.UseVisualStyleBackColor = false;
            buttonNueve.Click += AgregarNumero;
            // 
            // buttonOcho
            // 
            buttonOcho.BackColor = SystemColors.ScrollBar;
            buttonOcho.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOcho.Location = new Point(178, 220);
            buttonOcho.Name = "buttonOcho";
            buttonOcho.Size = new Size(60, 60);
            buttonOcho.TabIndex = 8;
            buttonOcho.Text = "8";
            buttonOcho.UseVisualStyleBackColor = false;
            buttonOcho.Click += AgregarNumero;
            // 
            // buttonCinco
            // 
            buttonCinco.BackColor = SystemColors.ScrollBar;
            buttonCinco.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCinco.Location = new Point(178, 312);
            buttonCinco.Name = "buttonCinco";
            buttonCinco.Size = new Size(60, 60);
            buttonCinco.TabIndex = 9;
            buttonCinco.Text = "5";
            buttonCinco.UseVisualStyleBackColor = false;
            buttonCinco.Click += AgregarNumero;
            // 
            // buttonCuatro
            // 
            buttonCuatro.BackColor = SystemColors.ScrollBar;
            buttonCuatro.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCuatro.Location = new Point(60, 312);
            buttonCuatro.Name = "buttonCuatro";
            buttonCuatro.Size = new Size(60, 60);
            buttonCuatro.TabIndex = 10;
            buttonCuatro.Text = "4";
            buttonCuatro.UseVisualStyleBackColor = false;
            buttonCuatro.Click += AgregarNumero;
            // 
            // buttonSeis
            // 
            buttonSeis.BackColor = SystemColors.ScrollBar;
            buttonSeis.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSeis.Location = new Point(306, 312);
            buttonSeis.Name = "buttonSeis";
            buttonSeis.Size = new Size(60, 60);
            buttonSeis.TabIndex = 11;
            buttonSeis.Text = "6";
            buttonSeis.UseVisualStyleBackColor = false;
            buttonSeis.Click += AgregarNumero;
            // 
            // buttonUno
            // 
            buttonUno.BackColor = SystemColors.ScrollBar;
            buttonUno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUno.Location = new Point(60, 405);
            buttonUno.Name = "buttonUno";
            buttonUno.Size = new Size(60, 60);
            buttonUno.TabIndex = 12;
            buttonUno.Text = "1";
            buttonUno.UseVisualStyleBackColor = false;
            buttonUno.Click += AgregarNumero;
            // 
            // buttonDos
            // 
            buttonDos.BackColor = SystemColors.ScrollBar;
            buttonDos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDos.Location = new Point(178, 405);
            buttonDos.Name = "buttonDos";
            buttonDos.Size = new Size(60, 60);
            buttonDos.TabIndex = 13;
            buttonDos.Text = "2";
            buttonDos.UseVisualStyleBackColor = false;
            buttonDos.Click += AgregarNumero;
            // 
            // buttonTres
            // 
            buttonTres.BackColor = SystemColors.ScrollBar;
            buttonTres.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTres.Location = new Point(306, 405);
            buttonTres.Name = "buttonTres";
            buttonTres.Size = new Size(60, 60);
            buttonTres.TabIndex = 14;
            buttonTres.Text = "3";
            buttonTres.UseVisualStyleBackColor = false;
            buttonTres.Click += AgregarNumero;
            // 
            // buttonSigno
            // 
            buttonSigno.BackColor = SystemColors.ScrollBar;
            buttonSigno.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSigno.Location = new Point(60, 498);
            buttonSigno.Name = "buttonSigno";
            buttonSigno.Size = new Size(60, 60);
            buttonSigno.TabIndex = 15;
            buttonSigno.Text = "+/-";
            buttonSigno.UseVisualStyleBackColor = false;
            buttonSigno.Click += buttonSigno_Click;
            // 
            // buttonCero
            // 
            buttonCero.BackColor = SystemColors.ScrollBar;
            buttonCero.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCero.Location = new Point(178, 498);
            buttonCero.Name = "buttonCero";
            buttonCero.Size = new Size(60, 60);
            buttonCero.TabIndex = 16;
            buttonCero.Text = "0";
            buttonCero.UseVisualStyleBackColor = false;
            buttonCero.Click += AgregarNumero;
            // 
            // buttonPunto
            // 
            buttonPunto.BackColor = SystemColors.ScrollBar;
            buttonPunto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPunto.Location = new Point(306, 498);
            buttonPunto.Name = "buttonPunto";
            buttonPunto.Size = new Size(60, 60);
            buttonPunto.TabIndex = 17;
            buttonPunto.Text = ".";
            buttonPunto.UseVisualStyleBackColor = false;
            buttonPunto.Click += buttonPunto_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = SystemColors.ScrollBar;
            buttonDivision.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivision.Location = new Point(451, 220);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(60, 60);
            buttonDivision.TabIndex = 18;
            buttonDivision.Tag = "/";
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += AgregarOperador;
            // 
            // buttonMultiplicar
            // 
            buttonMultiplicar.BackColor = SystemColors.ScrollBar;
            buttonMultiplicar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMultiplicar.Location = new Point(563, 220);
            buttonMultiplicar.Name = "buttonMultiplicar";
            buttonMultiplicar.Size = new Size(60, 60);
            buttonMultiplicar.TabIndex = 19;
            buttonMultiplicar.Tag = "x";
            buttonMultiplicar.Text = "x";
            buttonMultiplicar.UseVisualStyleBackColor = false;
            buttonMultiplicar.Click += AgregarOperador;
            // 
            // buttonMas
            // 
            buttonMas.BackColor = SystemColors.ScrollBar;
            buttonMas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMas.Location = new Point(451, 312);
            buttonMas.Name = "buttonMas";
            buttonMas.Size = new Size(60, 60);
            buttonMas.TabIndex = 20;
            buttonMas.Tag = "+";
            buttonMas.Text = "+";
            buttonMas.UseVisualStyleBackColor = false;
            buttonMas.Click += AgregarOperador;
            // 
            // buttonMenos
            // 
            buttonMenos.BackColor = SystemColors.ScrollBar;
            buttonMenos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMenos.Location = new Point(563, 312);
            buttonMenos.Name = "buttonMenos";
            buttonMenos.Size = new Size(60, 60);
            buttonMenos.TabIndex = 21;
            buttonMenos.Tag = "-";
            buttonMenos.Text = "-";
            buttonMenos.UseVisualStyleBackColor = false;
            buttonMenos.Click += AgregarOperador;
            // 
            // buttonIgual
            // 
            buttonIgual.BackColor = SystemColors.ScrollBar;
            buttonIgual.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIgual.Location = new Point(451, 405);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(172, 60);
            buttonIgual.TabIndex = 22;
            buttonIgual.Tag = "=";
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = false;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(635, 565);
            Controls.Add(buttonIgual);
            Controls.Add(buttonMenos);
            Controls.Add(buttonMas);
            Controls.Add(buttonMultiplicar);
            Controls.Add(buttonDivision);
            Controls.Add(buttonPunto);
            Controls.Add(buttonCero);
            Controls.Add(buttonSigno);
            Controls.Add(buttonTres);
            Controls.Add(buttonDos);
            Controls.Add(buttonUno);
            Controls.Add(buttonSeis);
            Controls.Add(buttonCuatro);
            Controls.Add(buttonCinco);
            Controls.Add(buttonOcho);
            Controls.Add(buttonNueve);
            Controls.Add(buttonSiete);
            Controls.Add(buttonElevarCuadrado);
            Controls.Add(buttonRaizCuadrada);
            Controls.Add(buttonRecorrer);
            Controls.Add(buttonBorrarTodo);
            Controls.Add(buttonBorrarUltimo);
            Controls.Add(textBoxResultado);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResultado;
        private Button buttonBorrarUltimo;
        private Button buttonBorrarTodo;
        private Button buttonRecorrer;
        private Button buttonRaizCuadrada;
        private Button buttonElevarCuadrado;
        private Button buttonSiete;
        private Button buttonNueve;
        private Button buttonOcho;
        private Button buttonCinco;
        private Button buttonCuatro;
        private Button buttonSeis;
        private Button buttonUno;
        private Button buttonDos;
        private Button buttonTres;
        private Button buttonSigno;
        private Button buttonCero;
        private Button buttonPunto;
        private Button buttonDivision;
        private Button buttonMultiplicar;
        private Button buttonMas;
        private Button buttonMenos;
        private Button buttonIgual;
    }
}
