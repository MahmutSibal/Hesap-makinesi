namespace Hesap_makinesi
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(574, 34);
            label1.Name = "label1";
            label1.Size = new Size(295, 50);
            label1.TabIndex = 0;
            label1.Text = "Hesap Makinesi";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(268, 450);
            button1.Name = "button1";
            button1.Size = new Size(211, 64);
            button1.TabIndex = 1;
            button1.Text = "Toplama";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(508, 450);
            button2.Name = "button2";
            button2.Size = new Size(189, 68);
            button2.TabIndex = 2;
            button2.Text = "Çıkarma";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 162);
            button3.Location = new Point(734, 456);
            button3.Name = "button3";
            button3.Size = new Size(187, 62);
            button3.TabIndex = 3;
            button3.Text = "Çarpma";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            button4.Location = new Point(981, 456);
            button4.Name = "button4";
            button4.Size = new Size(186, 64);
            button4.TabIndex = 4;
            button4.Text = "Bölme";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(423, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(423, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(196, 134);
            label2.Name = "label2";
            label2.Size = new Size(221, 41);
            label2.TabIndex = 7;
            label2.Text = "1.Sayıya Giriniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(196, 205);
            label3.Name = "label3";
            label3.Size = new Size(221, 41);
            label3.TabIndex = 8;
            label3.Text = "2.Sayıya Giriniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(474, 293);
            label4.Name = "label4";
            label4.Size = new Size(96, 41);
            label4.TabIndex = 9;
            label4.Text = "Sonuç";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(612, 293);
            label5.Name = "label5";
            label5.Size = new Size(50, 41);
            label5.TabIndex = 10;
            label5.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1740, 594);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
