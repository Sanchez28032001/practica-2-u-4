namespace practica_2_u_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label2 = new Label();
            txtTotal = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtHamburguesa = new TextBox();
            label4 = new Label();
            txtHotDog = new TextBox();
            txtSandwich = new TextBox();
            txtTe = new TextBox();
            txtRefresco = new TextBox();
            txtPapas = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccion por pedido";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 81);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(247, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "No 1.(Hamburguesa,Refresco,Papas fritas)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(37, 106);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(216, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "No 2.(Hot dog,Refresco,Papas fritas)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(37, 131);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(223, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "No 3.(Sandwich,Refresco,Papas fritas)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(37, 156);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(89, 19);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "Otro pedido";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 207);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 5;
            label2.Text = "Total a cobrar";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(48, 225);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(56, 293);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(185, 293);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Salida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 186);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 62);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 44);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 10;
            label3.Text = "Alimentos seleccionados";
            // 
            // txtHamburguesa
            // 
            txtHamburguesa.Location = new Point(366, 102);
            txtHamburguesa.Name = "txtHamburguesa";
            txtHamburguesa.Size = new Size(100, 23);
            txtHamburguesa.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(388, 88);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 12;
            label4.Text = "Cantidad:";
            // 
            // txtHotDog
            // 
            txtHotDog.Location = new Point(366, 131);
            txtHotDog.Name = "txtHotDog";
            txtHotDog.Size = new Size(100, 23);
            txtHotDog.TabIndex = 13;
            // 
            // txtSandwich
            // 
            txtSandwich.Location = new Point(366, 160);
            txtSandwich.Name = "txtSandwich";
            txtSandwich.Size = new Size(100, 23);
            txtSandwich.TabIndex = 14;
            // 
            // txtTe
            // 
            txtTe.Location = new Point(366, 189);
            txtTe.Name = "txtTe";
            txtTe.Size = new Size(100, 23);
            txtTe.TabIndex = 15;
            // 
            // txtRefresco
            // 
            txtRefresco.Location = new Point(366, 218);
            txtRefresco.Name = "txtRefresco";
            txtRefresco.Size = new Size(100, 23);
            txtRefresco.TabIndex = 16;
            // 
            // txtPapas
            // 
            txtPapas.Location = new Point(366, 247);
            txtPapas.Name = "txtPapas";
            txtPapas.Size = new Size(100, 23);
            txtPapas.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 105);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 18;
            label5.Text = "Hamburguesa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 134);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 19;
            label6.Text = "Hot dog";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 163);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 20;
            label7.Text = "Sandwich";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(472, 192);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 21;
            label8.Text = "Te";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(472, 221);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 22;
            label9.Text = "Refresco";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(472, 250);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 23;
            label10.Text = "Papas fritas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 330);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtPapas);
            Controls.Add(txtRefresco);
            Controls.Add(txtTe);
            Controls.Add(txtSandwich);
            Controls.Add(txtHotDog);
            Controls.Add(label4);
            Controls.Add(txtHamburguesa);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label2;
        private TextBox txtTotal;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtHamburguesa;
        private Label label4;
        private TextBox txtHotDog;
        private TextBox txtSandwich;
        private TextBox txtTe;
        private TextBox txtRefresco;
        private TextBox txtPapas;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}