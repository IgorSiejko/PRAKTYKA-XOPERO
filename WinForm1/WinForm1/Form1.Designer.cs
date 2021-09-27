
namespace WinForm1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxToInput = new System.Windows.Forms.TextBox();
            this.TextBoxToInput2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.CopyButton1 = new System.Windows.Forms.Button();
            this.ClearButton1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ClearButton2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.OpenFile2 = new System.Windows.Forms.Button();
            this.compressedbase64 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Base64 = new System.Windows.Forms.Label();
            this.CompressedButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.compressed1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(211, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "konwertuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(211, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 41);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Otwórz plik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 93);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(528, 41);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input na base64";
            // 
            // TextBoxToInput
            // 
            this.TextBoxToInput.Location = new System.Drawing.Point(211, 286);
            this.TextBoxToInput.Multiline = true;
            this.TextBoxToInput.Name = "TextBoxToInput";
            this.TextBoxToInput.Size = new System.Drawing.Size(529, 41);
            this.TextBoxToInput.TabIndex = 5;
            // 
            // TextBoxToInput2
            // 
            this.TextBoxToInput2.Location = new System.Drawing.Point(211, 333);
            this.TextBoxToInput2.Multiline = true;
            this.TextBoxToInput2.Name = "TextBoxToInput2";
            this.TextBoxToInput2.ReadOnly = true;
            this.TextBoxToInput2.Size = new System.Drawing.Size(529, 41);
            this.TextBoxToInput2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(211, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 41);
            this.button3.TabIndex = 7;
            this.button3.Text = "konwertuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(390, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "base64 na input";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(491, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 41);
            this.button4.TabIndex = 22;
            this.button4.Text = "Stwórz plik";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CopyButton1
            // 
            this.CopyButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CopyButton1.Location = new System.Drawing.Point(361, 152);
            this.CopyButton1.Name = "CopyButton1";
            this.CopyButton1.Size = new System.Drawing.Size(49, 40);
            this.CopyButton1.TabIndex = 23;
            this.CopyButton1.Text = "kopiuj";
            this.CopyButton1.UseVisualStyleBackColor = true;
            this.CopyButton1.Click += new System.EventHandler(this.CopyButton1_Click);
            // 
            // ClearButton1
            // 
            this.ClearButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton1.Location = new System.Drawing.Point(416, 151);
            this.ClearButton1.Name = "ClearButton1";
            this.ClearButton1.Size = new System.Drawing.Size(69, 40);
            this.ClearButton1.TabIndex = 25;
            this.ClearButton1.Text = "wyczyść";
            this.ClearButton1.UseVisualStyleBackColor = true;
            this.ClearButton1.Click += new System.EventHandler(this.CopyButton2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(361, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 41);
            this.button5.TabIndex = 26;
            this.button5.Text = "kopiuj";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ClearButton2
            // 
            this.ClearButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton2.Location = new System.Drawing.Point(416, 397);
            this.ClearButton2.Name = "ClearButton2";
            this.ClearButton2.Size = new System.Drawing.Size(69, 41);
            this.ClearButton2.TabIndex = 27;
            this.ClearButton2.Text = "wyczyść";
            this.ClearButton2.UseVisualStyleBackColor = true;
            this.ClearButton2.Click += new System.EventHandler(this.ClearButton2_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(491, 397);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 41);
            this.button6.TabIndex = 28;
            this.button6.Text = "Swórz plik";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // OpenFile2
            // 
            this.OpenFile2.Location = new System.Drawing.Point(619, 397);
            this.OpenFile2.Name = "OpenFile2";
            this.OpenFile2.Size = new System.Drawing.Size(120, 41);
            this.OpenFile2.TabIndex = 29;
            this.OpenFile2.Text = "button7";
            this.OpenFile2.UseVisualStyleBackColor = true;
            this.OpenFile2.Click += new System.EventHandler(this.OpenFile2_Click);
            // 
            // compressedbase64
            // 
            this.compressedbase64.Location = new System.Drawing.Point(928, 46);
            this.compressedbase64.Multiline = true;
            this.compressedbase64.Name = "compressedbase64";
            this.compressedbase64.ReadOnly = true;
            this.compressedbase64.Size = new System.Drawing.Size(179, 41);
            this.compressedbase64.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(167, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tekst";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(158, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Base64";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(167, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tekst";
            // 
            // Base64
            // 
            this.Base64.AutoSize = true;
            this.Base64.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Base64.Location = new System.Drawing.Point(157, 108);
            this.Base64.Name = "Base64";
            this.Base64.Size = new System.Drawing.Size(47, 15);
            this.Base64.TabIndex = 35;
            this.Base64.Text = "Base64";
            // 
            // CompressedButton
            // 
            this.CompressedButton.Location = new System.Drawing.Point(928, 150);
            this.CompressedButton.Name = "CompressedButton";
            this.CompressedButton.Size = new System.Drawing.Size(179, 41);
            this.CompressedButton.TabIndex = 36;
            this.CompressedButton.Text = "kompresuj tekst i utwórz plik";
            this.CompressedButton.UseVisualStyleBackColor = true;
            this.CompressedButton.Click += new System.EventHandler(this.CompressedButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(928, 286);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(179, 41);
            this.textBox3.TabIndex = 37;
            // 
            // compressed1
            // 
            this.compressed1.Location = new System.Drawing.Point(928, 93);
            this.compressed1.Multiline = true;
            this.compressed1.Name = "compressed1";
            this.compressed1.Size = new System.Drawing.Size(179, 41);
            this.compressed1.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(928, 333);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 40);
            this.textBox4.TabIndex = 41;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(928, 397);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 41);
            this.button7.TabIndex = 42;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(782, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "skompresowany base64";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(769, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "zdekompresowany base64";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(862, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1374, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.compressed1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.CompressedButton);
            this.Controls.Add(this.Base64);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.compressedbase64);
            this.Controls.Add(this.OpenFile2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ClearButton2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ClearButton1);
            this.Controls.Add(this.CopyButton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TextBoxToInput2);
            this.Controls.Add(this.TextBoxToInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxToInput;
        private System.Windows.Forms.TextBox TextBoxToInput2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button CopyButton1;
        private System.Windows.Forms.Button ClearButton1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ClearButton2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button OpenFile2;
        private System.Windows.Forms.TextBox compressedbase64;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Base64;
        private System.Windows.Forms.Button CompressedButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox compressed1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

