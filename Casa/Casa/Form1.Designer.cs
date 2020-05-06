namespace Casa
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dolar3 = new System.Windows.Forms.TextBox();
            this.dolar2 = new System.Windows.Forms.TextBox();
            this.dolar1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.euro3 = new System.Windows.Forms.TextBox();
            this.euro2 = new System.Windows.Forms.TextBox();
            this.euro1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.libra3 = new System.Windows.Forms.TextBox();
            this.libra2 = new System.Windows.Forms.TextBox();
            this.libra1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.peso1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.euro4 = new System.Windows.Forms.TextBox();
            this.dolar4 = new System.Windows.Forms.TextBox();
            this.peso2 = new System.Windows.Forms.TextBox();
            this.libra4 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnoperacion = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbOperacion = new System.Windows.Forms.ComboBox();
            this.cbDivisa = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dolar3);
            this.groupBox1.Controls.Add(this.dolar2);
            this.groupBox1.Controls.Add(this.dolar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "$  Dolares";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Venta    $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Compra $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // dolar3
            // 
            this.dolar3.Location = new System.Drawing.Point(92, 105);
            this.dolar3.Name = "dolar3";
            this.dolar3.Size = new System.Drawing.Size(94, 26);
            this.dolar3.TabIndex = 2;
            this.dolar3.Text = "0";
            this.dolar3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dolar3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dolar3_KeyPress);
            // 
            // dolar2
            // 
            this.dolar2.Location = new System.Drawing.Point(92, 72);
            this.dolar2.Name = "dolar2";
            this.dolar2.Size = new System.Drawing.Size(94, 26);
            this.dolar2.TabIndex = 1;
            this.dolar2.Text = "0";
            this.dolar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dolar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dolar2_KeyPress);
            // 
            // dolar1
            // 
            this.dolar1.Location = new System.Drawing.Point(92, 40);
            this.dolar1.Name = "dolar1";
            this.dolar1.Size = new System.Drawing.Size(94, 26);
            this.dolar1.TabIndex = 0;
            this.dolar1.Text = "0";
            this.dolar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dolar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dolar1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.euro3);
            this.groupBox2.Controls.Add(this.euro2);
            this.groupBox2.Controls.Add(this.euro1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 155);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "€  Euros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Venta    $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Compra $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cantidad";
            // 
            // euro3
            // 
            this.euro3.Location = new System.Drawing.Point(92, 105);
            this.euro3.Name = "euro3";
            this.euro3.Size = new System.Drawing.Size(94, 26);
            this.euro3.TabIndex = 2;
            this.euro3.Text = "0";
            this.euro3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.euro3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.euro3_KeyPress);
            // 
            // euro2
            // 
            this.euro2.Location = new System.Drawing.Point(92, 72);
            this.euro2.Name = "euro2";
            this.euro2.Size = new System.Drawing.Size(94, 26);
            this.euro2.TabIndex = 1;
            this.euro2.Text = "0";
            this.euro2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.euro2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.euro2_KeyPress);
            // 
            // euro1
            // 
            this.euro1.Location = new System.Drawing.Point(92, 40);
            this.euro1.Name = "euro1";
            this.euro1.Size = new System.Drawing.Size(94, 26);
            this.euro1.TabIndex = 0;
            this.euro1.Text = "0";
            this.euro1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.euro1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.euro1_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.libra3);
            this.groupBox3.Controls.Add(this.libra2);
            this.groupBox3.Controls.Add(this.libra1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 155);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "£  Libras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Venta    $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Compra $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cantidad";
            // 
            // libra3
            // 
            this.libra3.Location = new System.Drawing.Point(92, 105);
            this.libra3.Name = "libra3";
            this.libra3.Size = new System.Drawing.Size(94, 26);
            this.libra3.TabIndex = 2;
            this.libra3.Text = "0";
            this.libra3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.libra3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.libra3_KeyPress);
            // 
            // libra2
            // 
            this.libra2.Location = new System.Drawing.Point(92, 72);
            this.libra2.Name = "libra2";
            this.libra2.Size = new System.Drawing.Size(94, 26);
            this.libra2.TabIndex = 1;
            this.libra2.Text = "0";
            this.libra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.libra2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.libra2_KeyPress);
            // 
            // libra1
            // 
            this.libra1.Location = new System.Drawing.Point(92, 40);
            this.libra1.Name = "libra1";
            this.libra1.Size = new System.Drawing.Size(94, 26);
            this.libra1.TabIndex = 0;
            this.libra1.Text = "0";
            this.libra1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.libra1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.libra1_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardar);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.peso1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(218, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 155);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "$  Pesos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(34, 92);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 38);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Cantidad";
            // 
            // peso1
            // 
            this.peso1.Location = new System.Drawing.Point(92, 40);
            this.peso1.Name = "peso1";
            this.peso1.Size = new System.Drawing.Size(94, 26);
            this.peso1.TabIndex = 0;
            this.peso1.Text = "0";
            this.peso1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.peso1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.peso1_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.euro4);
            this.groupBox5.Controls.Add(this.dolar4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(11, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(408, 56);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Disponible";
            // 
            // euro4
            // 
            this.euro4.Location = new System.Drawing.Point(299, 23);
            this.euro4.Name = "euro4";
            this.euro4.Size = new System.Drawing.Size(94, 24);
            this.euro4.TabIndex = 2;
            this.euro4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dolar4
            // 
            this.dolar4.Location = new System.Drawing.Point(92, 23);
            this.dolar4.Name = "dolar4";
            this.dolar4.Size = new System.Drawing.Size(94, 24);
            this.dolar4.TabIndex = 1;
            this.dolar4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // peso2
            // 
            this.peso2.Location = new System.Drawing.Point(295, 23);
            this.peso2.Name = "peso2";
            this.peso2.Size = new System.Drawing.Size(94, 24);
            this.peso2.TabIndex = 4;
            this.peso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // libra4
            // 
            this.libra4.Location = new System.Drawing.Point(88, 23);
            this.libra4.Name = "libra4";
            this.libra4.Size = new System.Drawing.Size(94, 24);
            this.libra4.TabIndex = 3;
            this.libra4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnoperacion);
            this.groupBox6.Controls.Add(this.resultado);
            this.groupBox6.Controls.Add(this.cantidad);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.cbOperacion);
            this.groupBox6.Controls.Add(this.cbDivisa);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(505, 97);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 278);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Operaciones";
            // 
            // btnoperacion
            // 
            this.btnoperacion.Location = new System.Drawing.Point(61, 128);
            this.btnoperacion.Name = "btnoperacion";
            this.btnoperacion.Size = new System.Drawing.Size(198, 44);
            this.btnoperacion.TabIndex = 4;
            this.btnoperacion.Text = "Realizar Operacion";
            this.btnoperacion.UseVisualStyleBackColor = true;
            this.btnoperacion.Click += new System.EventHandler(this.btnoperacion_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(32, 184);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(257, 81);
            this.resultado.TabIndex = 5;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(134, 86);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(137, 26);
            this.cantidad.TabIndex = 3;
            this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cantidad";
            // 
            // cbOperacion
            // 
            this.cbOperacion.FormattingEnabled = true;
            this.cbOperacion.Items.AddRange(new object[] {
            "Comprar",
            "Vender"});
            this.cbOperacion.Location = new System.Drawing.Point(161, 35);
            this.cbOperacion.Name = "cbOperacion";
            this.cbOperacion.Size = new System.Drawing.Size(128, 28);
            this.cbOperacion.TabIndex = 1;
            this.cbOperacion.Text = "OPERACION";
            this.cbOperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbOperacion_KeyPress);
            // 
            // cbDivisa
            // 
            this.cbDivisa.FormattingEnabled = true;
            this.cbDivisa.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Libra Esterlina"});
            this.cbDivisa.Location = new System.Drawing.Point(12, 35);
            this.cbDivisa.Name = "cbDivisa";
            this.cbDivisa.Size = new System.Drawing.Size(128, 28);
            this.cbDivisa.TabIndex = 0;
            this.cbDivisa.Text = "DIVISA";
            this.cbDivisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDivisa_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(591, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 44);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.libra4);
            this.groupBox7.Controls.Add(this.peso2);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(15, 387);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(404, 56);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Disponible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(724, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Hora";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 462);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dolar3;
        private System.Windows.Forms.TextBox dolar2;
        private System.Windows.Forms.TextBox dolar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox euro3;
        private System.Windows.Forms.TextBox euro2;
        private System.Windows.Forms.TextBox euro1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox libra3;
        private System.Windows.Forms.TextBox libra2;
        private System.Windows.Forms.TextBox libra1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox peso1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox peso2;
        private System.Windows.Forms.TextBox libra4;
        private System.Windows.Forms.TextBox euro4;
        private System.Windows.Forms.TextBox dolar4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button btnoperacion;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbOperacion;
        private System.Windows.Forms.ComboBox cbDivisa;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer1;
    }
}

