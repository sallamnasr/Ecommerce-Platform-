namespace EcommerceProject
{
    partial class Ecommerce
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
            form = new TabControl();
            tabPage1 = new TabPage();
            category = new Label();
            comboBox1 = new ComboBox();
            btnSave = new Button();
            txtWeight = new TextBox();
            label6 = new Label();
            txtColor = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            label4 = new Label();
            txtPrand = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label12 = new Label();
            form.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // form
            // 
            form.Controls.Add(tabPage1);
            form.Controls.Add(tabPage2);
            form.Controls.Add(tabPage3);
            form.Controls.Add(tabPage4);
            form.Controls.Add(tabPage5);
            form.Controls.Add(tabPage6);
            form.Dock = DockStyle.Fill;
            form.Font = new Font("PT Bold Arch", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            form.Location = new Point(0, 0);
            form.Name = "form";
            form.SelectedIndex = 0;
            form.Size = new Size(1436, 760);
            form.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(category);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(txtWeight);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtColor);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtStock);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtPrand);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtPrice);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = SystemColors.ActiveCaption;
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1428, 712);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Product";
            // 
            // category
            // 
            category.AutoSize = true;
            category.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category.ForeColor = Color.White;
            category.Location = new Point(627, 82);
            category.Name = "category";
            category.Size = new Size(205, 36);
            category.TabIndex = 15;
            category.Text = "Categories";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(64, 64, 64);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(497, 139);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(468, 44);
            comboBox1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(497, 278);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(468, 42);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.FromArgb(64, 64, 64);
            txtWeight.Location = new Point(22, 355);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(237, 40);
            txtWeight.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(18, 317);
            label6.Name = "label6";
            label6.Size = new Size(129, 36);
            label6.TabIndex = 12;
            label6.Text = "Weight";
            label6.Click += label6_Click;
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.FromArgb(64, 64, 64);
            txtColor.Location = new Point(22, 278);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(237, 40);
            txtColor.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(22, 239);
            label5.Name = "label5";
            label5.Size = new Size(110, 36);
            label5.TabIndex = 10;
            label5.Text = "Color";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(64, 64, 64);
            txtStock.Location = new Point(22, 439);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(237, 40);
            txtStock.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 400);
            label4.Name = "label4";
            label4.Size = new Size(110, 36);
            label4.TabIndex = 8;
            label4.Text = "Stock";
            label4.Click += label4_Click;
            // 
            // txtPrand
            // 
            txtPrand.BackColor = Color.FromArgb(64, 64, 64);
            txtPrand.Location = new Point(22, 196);
            txtPrand.Name = "txtPrand";
            txtPrand.Size = new Size(237, 40);
            txtPrand.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 163);
            label3.Name = "label3";
            label3.Size = new Size(110, 36);
            label3.TabIndex = 6;
            label3.Text = "Prand";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(64, 64, 64);
            txtPrice.Location = new Point(22, 120);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(237, 40);
            txtPrice.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 82);
            label1.Name = "label1";
            label1.Size = new Size(110, 36);
            label1.TabIndex = 4;
            label1.Text = "Price";
            label1.Click += label1_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(64, 64, 64);
            txtName.Location = new Point(22, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 40);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 36);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 503);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1422, 206);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(label12);
            tabPage2.Location = new Point(4, 44);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1428, 712);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Order";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Black;
            tabPage3.Location = new Point(4, 44);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1428, 712);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Category";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 44);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1428, 712);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Customer";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 44);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1428, 712);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Payment";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 44);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1428, 712);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "OrderProduct";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(40, 409);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 43);
            textBox1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(36, 371);
            label7.Name = "label7";
            label7.Size = new Size(129, 36);
            label7.TabIndex = 24;
            label7.Text = "status";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(40, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 43);
            textBox2.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(40, 293);
            label8.Name = "label8";
            label8.Size = new Size(91, 36);
            label8.TabIndex = 22;
            label8.Text = "Year";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(64, 64, 64);
            textBox3.Location = new Point(40, 525);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 43);
            textBox3.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(40, 486);
            label9.Name = "label9";
            label9.Size = new Size(262, 36);
            label9.TabIndex = 20;
            label9.Text = "Total Amount ";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(64, 64, 64);
            textBox4.Location = new Point(40, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(237, 43);
            textBox4.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(40, 217);
            label10.Name = "label10";
            label10.Size = new Size(110, 36);
            label10.TabIndex = 18;
            label10.Text = "Month";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(64, 64, 64);
            textBox5.Location = new Point(40, 174);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(237, 43);
            textBox5.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(40, 136);
            label11.Name = "label11";
            label11.Size = new Size(72, 36);
            label11.TabIndex = 16;
            label11.Text = "Day";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(64, 64, 64);
            textBox6.Location = new Point(40, 93);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(237, 43);
            textBox6.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(40, 54);
            label12.Name = "label12";
            label12.Size = new Size(205, 36);
            label12.TabIndex = 14;
            label12.Text = "Product ID";
            // 
            // Ecommerce
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1436, 760);
            Controls.Add(form);
            Name = "Ecommerce";
            Text = "Ecommerce";
            FormClosed += Ecommerce_FormClosed;
            Load += Ecommerce_Load;
            form.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl form;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtWeight;
        private Label label6;
        private TextBox txtColor;
        private Label label5;
        private TextBox txtStock;
        private Label label4;
        private TextBox txtPrand;
        private Label label3;
        private TextBox txtPrice;
        private Label label1;
        private Button btnSave;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ComboBox comboBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Label category;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox6;
        private Label label12;
    }
}
