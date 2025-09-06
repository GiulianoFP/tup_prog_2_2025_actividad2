namespace Ejercicio1
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
            gBox1 = new GroupBox();
            btnComisaria = new Button();
            btnListar = new Button();
            gpAgente = new GroupBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label11 = new Label();
            gBox1.SuspendLayout();
            gpAgente.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gBox1
            // 
            gBox1.Controls.Add(btnListar);
            gBox1.Controls.Add(btnComisaria);
            gBox1.Location = new Point(36, 13);
            gBox1.Name = "gBox1";
            gBox1.Size = new Size(481, 85);
            gBox1.TabIndex = 0;
            gBox1.TabStop = false;
            gBox1.Text = "Administración Comisaría";
            // 
            // btnComisaria
            // 
            btnComisaria.Location = new Point(266, 22);
            btnComisaria.Name = "btnComisaria";
            btnComisaria.Size = new Size(91, 47);
            btnComisaria.TabIndex = 0;
            btnComisaria.Text = "Crear Comisaría(1)";
            btnComisaria.UseVisualStyleBackColor = true;
            btnComisaria.Click += btnComisaria_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(378, 22);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(91, 47);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar Incidentes(4)";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // gpAgente
            // 
            gpAgente.Controls.Add(label11);
            gpAgente.Controls.Add(comboBox1);
            gpAgente.Controls.Add(groupBox2);
            gpAgente.Controls.Add(groupBox1);
            gpAgente.Location = new Point(32, 107);
            gpAgente.Name = "gpAgente";
            gpAgente.Size = new Size(485, 405);
            gpAgente.TabIndex = 1;
            gpAgente.TabStop = false;
            gpAgente.Text = "Operaciones Sobre El Agente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(25, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 114);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administración de Guardias";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(37, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 51);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(37, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(109, 80);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(357, 38);
            button1.Name = "button1";
            button1.Size = new Size(91, 47);
            button1.TabIndex = 3;
            button1.Text = "Asignacion de Guardia (2)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 30);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "Nro Guardia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 59);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 88);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "Duracion en M";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 54);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 7;
            label4.Text = ":";

            // 
            // textBox5
            // 
            textBox5.Location = new Point(109, 32);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Location = new Point(25, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 220);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Administración de Incidentes";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(109, 61);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(37, 23);
            textBox6.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(172, 61);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(37, 23);
            textBox7.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 64);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 8;
            label5.Text = ":";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(109, 90);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(245, 90);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 10;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(109, 129);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(236, 85);
            textBox10.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 93);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 8;
            label6.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 160);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 12;
            label7.Text = "Motivo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 64);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 13;
            label8.Text = "Hora";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 35);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 14;
            label9.Text = "Tipo de Incidente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 93);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 15;
            label10.Text = "Persona";
            // 
            // button2
            // 
            button2.Location = new Point(357, 144);
            button2.Name = "button2";
            button2.Size = new Size(91, 47);
            button2.TabIndex = 16;
            button2.Text = "Registrar Incidente(3)";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(229, 536);
            button3.Name = "button3";
            button3.Size = new Size(91, 47);
            button3.TabIndex = 17;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 25);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 9;
            label11.Text = "Placa de Agente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 595);
            Controls.Add(button3);
            Controls.Add(gpAgente);
            Controls.Add(gBox1);
            Name = "Form1";
            Text = "l";
            gBox1.ResumeLayout(false);
            gpAgente.ResumeLayout(false);
            gpAgente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBox1;
        private Button btnListar;
        private Button btnComisaria;
        private GroupBox gpAgente;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private GroupBox groupBox2;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label5;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button2;
        private Button button3;
        private Label label11;
        private ComboBox comboBox1;
    }
}
