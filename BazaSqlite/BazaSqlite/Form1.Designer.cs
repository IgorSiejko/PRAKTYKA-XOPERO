
namespace BazaSqlite
{
    partial class ConnSQLite
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
            this.ConnSql = new System.Windows.Forms.Button();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Lastname1 = new System.Windows.Forms.TextBox();
            this.When = new System.Windows.Forms.TextBox();
            this.Phonenmbr1 = new System.Windows.Forms.TextBox();
            this.Email1 = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Adres3 = new System.Windows.Forms.TextBox();
            this.NIP1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Clear1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.REGON = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Adres4 = new System.Windows.Forms.Label();
            this.Koszt = new System.Windows.Forms.Label();
            this.Adresship = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwaFirmy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGON1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnSql
            // 
            this.ConnSql.Location = new System.Drawing.Point(1001, 42);
            this.ConnSql.Name = "ConnSql";
            this.ConnSql.Size = new System.Drawing.Size(114, 42);
            this.ConnSql.TabIndex = 0;
            this.ConnSql.Text = "Dodaj Dane";
            this.ConnSql.UseVisualStyleBackColor = true;
            this.ConnSql.Click += new System.EventHandler(this.ConnSql_Click);
            // 
            // Name1
            // 
            this.Name1.Location = new System.Drawing.Point(240, 37);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(100, 23);
            this.Name1.TabIndex = 1;
            // 
            // Lastname1
            // 
            this.Lastname1.Location = new System.Drawing.Point(240, 66);
            this.Lastname1.Name = "Lastname1";
            this.Lastname1.Size = new System.Drawing.Size(100, 23);
            this.Lastname1.TabIndex = 2;
            this.Lastname1.TextChanged += new System.EventHandler(this.Lastname1_TextChanged);
            // 
            // When
            // 
            this.When.Location = new System.Drawing.Point(780, 66);
            this.When.Name = "When";
            this.When.Size = new System.Drawing.Size(166, 23);
            this.When.TabIndex = 3;
            // 
            // Phonenmbr1
            // 
            this.Phonenmbr1.Location = new System.Drawing.Point(240, 132);
            this.Phonenmbr1.Name = "Phonenmbr1";
            this.Phonenmbr1.Size = new System.Drawing.Size(100, 23);
            this.Phonenmbr1.TabIndex = 4;
            // 
            // Email1
            // 
            this.Email1.Location = new System.Drawing.Point(240, 95);
            this.Email1.Name = "Email1";
            this.Email1.Size = new System.Drawing.Size(100, 23);
            this.Email1.TabIndex = 5;
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(780, 34);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(166, 23);
            this.Product.TabIndex = 7;
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(32, 69);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(57, 15);
            this.Lastname.TabIndex = 9;
            this.Lastname.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number tel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nazwa Firmy";
            // 
            // Adres3
            // 
            this.Adres3.Location = new System.Drawing.Point(468, 66);
            this.Adres3.Name = "Adres3";
            this.Adres3.Size = new System.Drawing.Size(166, 23);
            this.Adres3.TabIndex = 15;
            // 
            // NIP1
            // 
            this.NIP1.Location = new System.Drawing.Point(468, 98);
            this.NIP1.Name = "NIP1";
            this.NIP1.Size = new System.Drawing.Size(166, 23);
            this.NIP1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Imie";
            // 
            // Clear1
            // 
            this.Clear1.Location = new System.Drawing.Point(1001, 103);
            this.Clear1.Name = "Clear1";
            this.Clear1.Size = new System.Drawing.Size(114, 39);
            this.Clear1.TabIndex = 18;
            this.Clear1.Text = "Wyczyść";
            this.Clear1.UseVisualStyleBackColor = true;
            this.Clear1.Click += new System.EventHandler(this.Clear1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "NIP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "REGON";
            // 
            // REGON
            // 
            this.REGON.Location = new System.Drawing.Point(468, 129);
            this.REGON.Name = "REGON";
            this.REGON.Size = new System.Drawing.Size(166, 23);
            this.REGON.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(706, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(677, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Data dostawy";
            // 
            // Adres4
            // 
            this.Adres4.AutoSize = true;
            this.Adres4.Location = new System.Drawing.Point(718, 106);
            this.Adres4.Name = "Adres4";
            this.Adres4.Size = new System.Drawing.Size(37, 15);
            this.Adres4.TabIndex = 25;
            this.Adres4.Text = "Adres";
            // 
            // Koszt
            // 
            this.Koszt.AutoSize = true;
            this.Koszt.Location = new System.Drawing.Point(724, 132);
            this.Koszt.Name = "Koszt";
            this.Koszt.Size = new System.Drawing.Size(31, 15);
            this.Koszt.TabIndex = 26;
            this.Koszt.Text = "Cost";
            // 
            // Adresship
            // 
            this.Adresship.Location = new System.Drawing.Point(780, 95);
            this.Adresship.Name = "Adresship";
            this.Adresship.Size = new System.Drawing.Size(166, 23);
            this.Adresship.TabIndex = 27;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(780, 127);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(166, 23);
            this.Cost.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imie,
            this.Nazwisko,
            this.Email,
            this.Numer,
            this.NazwaFirmy,
            this.Adres,
            this.NIP,
            this.REGON1,
            this.Product1,
            this.ShipDate,
            this.ShipAdres,
            this.Cost1});
            this.dataGridView1.Location = new System.Drawing.Point(82, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 143);
            this.dataGridView1.TabIndex = 29;
            // 
            // Imie
            // 
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Numer
            // 
            this.Numer.HeaderText = "Numer";
            this.Numer.Name = "Numer";
            // 
            // NazwaFirmy
            // 
            this.NazwaFirmy.HeaderText = "NazwaFirmy";
            this.NazwaFirmy.Name = "NazwaFirmy";
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            // 
            // NIP
            // 
            this.NIP.HeaderText = "NIP";
            this.NIP.Name = "NIP";
            // 
            // REGON1
            // 
            this.REGON1.HeaderText = "REGON1";
            this.REGON1.Name = "REGON1";
            // 
            // Product1
            // 
            this.Product1.HeaderText = "Produkt";
            this.Product1.Name = "Product1";
            // 
            // ShipDate
            // 
            this.ShipDate.HeaderText = "DataDostawy";
            this.ShipDate.Name = "ShipDate";
            // 
            // ShipAdres
            // 
            this.ShipAdres.HeaderText = "AdresDostawy";
            this.ShipAdres.Name = "ShipAdres";
            // 
            // Cost1
            // 
            this.Cost1.HeaderText = "Koszt";
            this.Cost1.Name = "Cost1";
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(468, 37);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(166, 23);
            this.CompanyName.TabIndex = 30;
            // 
            // ConnSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 450);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Adresship);
            this.Controls.Add(this.Koszt);
            this.Controls.Add(this.Adres4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.REGON);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clear1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NIP1);
            this.Controls.Add(this.Adres3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Email1);
            this.Controls.Add(this.Phonenmbr1);
            this.Controls.Add(this.When);
            this.Controls.Add(this.Lastname1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.ConnSql);
            this.Name = "ConnSQLite";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnSql;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox Lastname1;
        private System.Windows.Forms.TextBox When;
        private System.Windows.Forms.TextBox Phonenmbr1;
        private System.Windows.Forms.TextBox Email1;
  
        private System.Windows.Forms.TextBox Product;

        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adres3;
        private System.Windows.Forms.TextBox NIP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Clear1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox REGON;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Adres4;
        private System.Windows.Forms.Label Koszt;
        private System.Windows.Forms.TextBox Adresship;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaFirmy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGON1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost1;
        private System.Windows.Forms.TextBox CompanyName;
    }
}

