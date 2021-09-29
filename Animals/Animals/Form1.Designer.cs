
namespace Animals
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
            this.Hippo = new System.Windows.Forms.Label();
            this.Wolf = new System.Windows.Forms.Label();
            this.Dog = new System.Windows.Forms.Label();
            this.Lion = new System.Windows.Forms.Label();
            this.Cat = new System.Windows.Forms.Label();
            this.Tiger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hippo
            // 
            this.Hippo.AutoSize = true;
            this.Hippo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hippo.Location = new System.Drawing.Point(68, 148);
            this.Hippo.Name = "Hippo";
            this.Hippo.Size = new System.Drawing.Size(40, 15);
            this.Hippo.TabIndex = 0;
            this.Hippo.Text = "Hippo";
            // 
            // Wolf
            // 
            this.Wolf.AutoSize = true;
            this.Wolf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Wolf.Location = new System.Drawing.Point(296, 148);
            this.Wolf.Name = "Wolf";
            this.Wolf.Size = new System.Drawing.Size(34, 15);
            this.Wolf.TabIndex = 1;
            this.Wolf.Tag = "label2";
            this.Wolf.Text = "Wolf";
            // 
            // Dog
            // 
            this.Dog.AutoSize = true;
            this.Dog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dog.Location = new System.Drawing.Point(184, 148);
            this.Dog.Name = "Dog";
            this.Dog.Size = new System.Drawing.Size(30, 15);
            this.Dog.TabIndex = 2;
            this.Dog.Text = "Dog";
            // 
            // Lion
            // 
            this.Lion.AutoSize = true;
            this.Lion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lion.Location = new System.Drawing.Point(414, 148);
            this.Lion.Name = "Lion";
            this.Lion.Size = new System.Drawing.Size(30, 15);
            this.Lion.TabIndex = 3;
            this.Lion.Text = "Lion";
            // 
            // Cat
            // 
            this.Cat.AutoSize = true;
            this.Cat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cat.Location = new System.Drawing.Point(558, 148);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(25, 15);
            this.Cat.TabIndex = 4;
            this.Cat.Text = "Cat";
            // 
            // Tiger
            // 
            this.Tiger.AutoSize = true;
            this.Tiger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tiger.Location = new System.Drawing.Point(673, 148);
            this.Tiger.Name = "Tiger";
            this.Tiger.Size = new System.Drawing.Size(36, 15);
            this.Tiger.TabIndex = 5;
            this.Tiger.Text = "Tiger";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tiger);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.Lion);
            this.Controls.Add(this.Dog);
            this.Controls.Add(this.Wolf);
            this.Controls.Add(this.Hippo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hippo;
        private System.Windows.Forms.Label Wolf;
        private System.Windows.Forms.Label Dog;
        private System.Windows.Forms.Label Lion;
        private System.Windows.Forms.Label Cat;
        private System.Windows.Forms.Label Tiger;
    }
}

