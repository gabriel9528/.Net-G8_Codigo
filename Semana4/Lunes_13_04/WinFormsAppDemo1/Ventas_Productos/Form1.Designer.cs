namespace Ventas_Productos
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
            groupBox1 = new GroupBox();
            textBox_cliente = new TextBox();
            label2 = new Label();
            label_fecha = new Label();
            label4 = new Label();
            label_hora = new Label();
            groupBox2 = new GroupBox();
            button_registrar = new Button();
            button_cancelar = new Button();
            label_precio = new Label();
            label6 = new Label();
            textBox_cantidad = new TextBox();
            label5 = new Label();
            comboBox_productos = new ComboBox();
            label3 = new Label();
            listViewRegistro = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label7 = new Label();
            label_total_neto = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 14);
            label1.Name = "label1";
            label1.Size = new Size(461, 41);
            label1.TabIndex = 0;
            label1.Text = "Control de Ventas de Productos";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_cliente);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(32, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 133);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del cliente";
            // 
            // textBox_cliente
            // 
            textBox_cliente.Location = new Point(15, 48);
            textBox_cliente.Name = "textBox_cliente";
            textBox_cliente.Size = new Size(492, 34);
            textBox_cliente.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(883, 102);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 3;
            label2.Text = "HORA";
            // 
            // label_fecha
            // 
            label_fecha.AutoSize = true;
            label_fecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_fecha.Location = new Point(680, 169);
            label_fecha.Name = "label_fecha";
            label_fecha.Size = new Size(0, 28);
            label_fecha.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(680, 102);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 5;
            label4.Text = "FECHA";
            // 
            // label_hora
            // 
            label_hora.AutoSize = true;
            label_hora.Location = new Point(883, 181);
            label_hora.Name = "label_hora";
            label_hora.Size = new Size(0, 20);
            label_hora.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_registrar);
            groupBox2.Controls.Add(button_cancelar);
            groupBox2.Controls.Add(label_precio);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox_cantidad);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox_productos);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(32, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1022, 178);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Venta";
            // 
            // button_registrar
            // 
            button_registrar.BackColor = Color.Yellow;
            button_registrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_registrar.Location = new Point(893, 116);
            button_registrar.Name = "button_registrar";
            button_registrar.Size = new Size(101, 38);
            button_registrar.TabIndex = 7;
            button_registrar.Text = "Registrar";
            button_registrar.UseVisualStyleBackColor = false;
            button_registrar.Click += button_registrar_Click;
            // 
            // button_cancelar
            // 
            button_cancelar.BackColor = Color.FromArgb(255, 192, 128);
            button_cancelar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_cancelar.Location = new Point(893, 43);
            button_cancelar.Name = "button_cancelar";
            button_cancelar.Size = new Size(94, 38);
            button_cancelar.TabIndex = 6;
            button_cancelar.Text = "Cancelar";
            button_cancelar.UseVisualStyleBackColor = false;
            button_cancelar.Click += button_cancelar_Click;
            // 
            // label_precio
            // 
            label_precio.AutoSize = true;
            label_precio.Location = new Point(769, 105);
            label_precio.Name = "label_precio";
            label_precio.Size = new Size(0, 28);
            label_precio.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(768, 43);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 4;
            label6.Text = "Precio";
            // 
            // textBox_cantidad
            // 
            textBox_cantidad.Location = new Point(594, 107);
            textBox_cantidad.Name = "textBox_cantidad";
            textBox_cantidad.Size = new Size(125, 34);
            textBox_cantidad.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(607, 43);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 2;
            label5.Text = "Cantidad";
            // 
            // comboBox_productos
            // 
            comboBox_productos.FormattingEnabled = true;
            comboBox_productos.Location = new Point(15, 105);
            comboBox_productos.Name = "comboBox_productos";
            comboBox_productos.Size = new Size(492, 36);
            comboBox_productos.TabIndex = 1;
            comboBox_productos.SelectedIndexChanged += comboBox_productos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 60);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 0;
            label3.Text = "Producto";
            // 
            // listViewRegistro
            // 
            listViewRegistro.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewRegistro.Location = new Point(32, 446);
            listViewRegistro.Name = "listViewRegistro";
            listViewRegistro.Size = new Size(1022, 277);
            listViewRegistro.TabIndex = 8;
            listViewRegistro.UseCompatibleStateImageBehavior = false;
            listViewRegistro.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Sub-Total";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Descuento";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Neto";
            columnHeader6.Width = 100;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(801, 774);
            label7.Name = "label7";
            label7.Size = new Size(112, 28);
            label7.TabIndex = 9;
            label7.Text = "Total Neto";
            // 
            // label_total_neto
            // 
            label_total_neto.AutoSize = true;
            label_total_neto.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_total_neto.Location = new Point(955, 781);
            label_total_neto.Name = "label_total_neto";
            label_total_neto.Size = new Size(0, 31);
            label_total_neto.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1083, 839);
            Controls.Add(label_total_neto);
            Controls.Add(label7);
            Controls.Add(listViewRegistro);
            Controls.Add(groupBox2);
            Controls.Add(label_hora);
            Controls.Add(label4);
            Controls.Add(label_fecha);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox_cliente;
        private Label label2;
        private Label label_fecha;
        private Label label4;
        private Label label_hora;
        private GroupBox groupBox2;
        private Button button_registrar;
        private Button button_cancelar;
        private Label label_precio;
        private Label label6;
        private TextBox textBox_cantidad;
        private Label label5;
        private ComboBox comboBox_productos;
        private Label label3;
        private ListView listViewRegistro;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label7;
        private Label label_total_neto;
    }
}
