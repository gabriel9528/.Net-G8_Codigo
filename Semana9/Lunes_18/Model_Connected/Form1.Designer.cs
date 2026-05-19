namespace Model_Connected
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_airline = new System.Windows.Forms.TextBox();
            this.textBox_destination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_flight_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_air_plane_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_select = new System.Windows.Forms.ComboBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airline";
            // 
            // textBox_airline
            // 
            this.textBox_airline.Location = new System.Drawing.Point(174, 61);
            this.textBox_airline.Name = "textBox_airline";
            this.textBox_airline.Size = new System.Drawing.Size(219, 22);
            this.textBox_airline.TabIndex = 1;
            // 
            // textBox_destination
            // 
            this.textBox_destination.Location = new System.Drawing.Point(174, 183);
            this.textBox_destination.Name = "textBox_destination";
            this.textBox_destination.Size = new System.Drawing.Size(219, 22);
            this.textBox_destination.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination";
            // 
            // textBox_flight_number
            // 
            this.textBox_flight_number.Location = new System.Drawing.Point(174, 118);
            this.textBox_flight_number.Name = "textBox_flight_number";
            this.textBox_flight_number.Size = new System.Drawing.Size(219, 22);
            this.textBox_flight_number.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Flight Number";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(646, 59);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(294, 36);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // comboBox_air_plane_type
            // 
            this.comboBox_air_plane_type.FormattingEnabled = true;
            this.comboBox_air_plane_type.Items.AddRange(new object[] {
            "AirBus 320",
            "Boeing 777",
            "Boeing 737",
            "Boeing 747",
            "Boeing 787"});
            this.comboBox_air_plane_type.Location = new System.Drawing.Point(174, 255);
            this.comboBox_air_plane_type.Name = "comboBox_air_plane_type";
            this.comboBox_air_plane_type.Size = new System.Drawing.Size(219, 24);
            this.comboBox_air_plane_type.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Air Plane Type";
            // 
            // comboBox_select
            // 
            this.comboBox_select.FormattingEnabled = true;
            this.comboBox_select.Location = new System.Drawing.Point(646, 150);
            this.comboBox_select.Name = "comboBox_select";
            this.comboBox_select.Size = new System.Drawing.Size(294, 24);
            this.comboBox_select.TabIndex = 9;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(630, 250);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(159, 32);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(826, 250);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(135, 32);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(781, 692);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(159, 32);
            this.button_refresh.TabIndex = 12;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 323);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 757);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.comboBox_select);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_air_plane_type);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_flight_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_destination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_airline);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_airline;
        private System.Windows.Forms.TextBox textBox_destination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_flight_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_air_plane_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_select;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

