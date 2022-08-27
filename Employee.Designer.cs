namespace SalesRep
{
    partial class EMPLOYEES
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMPLOYEES));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Home = new System.Windows.Forms.LinkLabel();
            this.transBtn = new System.Windows.Forms.Button();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GivenNameBox = new System.Windows.Forms.TextBox();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.BDaybox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RoleBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SurNameBox = new System.Windows.Forms.TextBox();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.MiddleBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Home, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.transBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ProductBtn, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(142, 128);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Home.LinkColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(4, 1);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(134, 28);
            this.Home.TabIndex = 19;
            this.Home.TabStop = true;
            this.Home.Text = "SALES REP";
            this.Home.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Home_LinkClicked);
            // 
            // transBtn
            // 
            this.transBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transBtn.Location = new System.Drawing.Point(4, 86);
            this.transBtn.Name = "transBtn";
            this.transBtn.Size = new System.Drawing.Size(134, 34);
            this.transBtn.TabIndex = 2;
            this.transBtn.Text = "TRANSACTIONS";
            this.transBtn.UseVisualStyleBackColor = true;
            this.transBtn.Click += new System.EventHandler(this.transBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductBtn.Location = new System.Drawing.Point(4, 45);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(134, 34);
            this.ProductBtn.TabIndex = 3;
            this.ProductBtn.Text = "PRODUCTS";
            this.ProductBtn.UseVisualStyleBackColor = true;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.GivenNameBox);
            this.panel1.Controls.Add(this.ClrBtn);
            this.panel1.Controls.Add(this.AddEmployeeBtn);
            this.panel1.Controls.Add(this.BDaybox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.RoleBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmailBox);
            this.panel1.Controls.Add(this.GenderBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PhoneNoBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SurNameBox);
            this.panel1.Location = new System.Drawing.Point(203, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 209);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(267, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "EMPLOYEES";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(113, 175);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(164, 23);
            this.passwordBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "PASSWORD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "GIVEN NAMES";
            // 
            // GivenNameBox
            // 
            this.GivenNameBox.Location = new System.Drawing.Point(372, 45);
            this.GivenNameBox.Name = "GivenNameBox";
            this.GivenNameBox.PlaceholderText = "JOHN KWABENA";
            this.GivenNameBox.Size = new System.Drawing.Size(164, 23);
            this.GivenNameBox.TabIndex = 20;
            this.GivenNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClrBtn
            // 
            this.ClrBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ClrBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClrBtn.Location = new System.Drawing.Point(451, 175);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(85, 27);
            this.ClrBtn.TabIndex = 18;
            this.ClrBtn.Text = "CLEAR";
            this.ClrBtn.UseVisualStyleBackColor = false;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmployeeBtn.Location = new System.Drawing.Point(360, 175);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(85, 27);
            this.AddEmployeeBtn.TabIndex = 17;
            this.AddEmployeeBtn.Text = "ADD ";
            this.AddEmployeeBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // BDaybox
            // 
            this.BDaybox.Location = new System.Drawing.Point(113, 139);
            this.BDaybox.Name = "BDaybox";
            this.BDaybox.PlaceholderText = "YYYY/MM/DD";
            this.BDaybox.Size = new System.Drawing.Size(164, 23);
            this.BDaybox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "BIRTH DATE";
            // 
            // RoleBox
            // 
            this.RoleBox.Location = new System.Drawing.Point(373, 142);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.PlaceholderText = "USER OR ADMIN";
            this.RoleBox.Size = new System.Drawing.Size(163, 23);
            this.RoleBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "ROLE PLAYED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "EMAIL";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(113, 108);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.PlaceholderText = "123@example.com";
            this.EmailBox.Size = new System.Drawing.Size(423, 23);
            this.EmailBox.TabIndex = 7;
            // 
            // GenderBox
            // 
            this.GenderBox.Location = new System.Drawing.Point(373, 76);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.PlaceholderText = "M = MALE __F = FEMALE";
            this.GenderBox.Size = new System.Drawing.Size(163, 23);
            this.GenderBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "GENDER (M/F)";
            // 
            // PhoneNoBox
            // 
            this.PhoneNoBox.Location = new System.Drawing.Point(113, 79);
            this.PhoneNoBox.Name = "PhoneNoBox";
            this.PhoneNoBox.PlaceholderText = "233";
            this.PhoneNoBox.Size = new System.Drawing.Size(164, 23);
            this.PhoneNoBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "PHONE NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "LAST NAME";
            // 
            // SurNameBox
            // 
            this.SurNameBox.Location = new System.Drawing.Point(113, 45);
            this.SurNameBox.Name = "SurNameBox";
            this.SurNameBox.PlaceholderText = "DOE";
            this.SurNameBox.Size = new System.Drawing.Size(164, 23);
            this.SurNameBox.TabIndex = 4;
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(203, 227);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.RowTemplate.Height = 25;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(990, 447);
            this.EmployeeDataGridView.TabIndex = 6;
            this.EmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDataGridView_CellContentClick);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Brown;
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.logOutBtn.Location = new System.Drawing.Point(16, 680);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(134, 37);
            this.logOutBtn.TabIndex = 15;
            this.logOutBtn.Text = "LOG OUT";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Brown;
            this.DelBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DelBtn.Location = new System.Drawing.Point(741, 682);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(119, 35);
            this.DelBtn.TabIndex = 18;
            this.DelBtn.Text = "DELETE";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.Location = new System.Drawing.Point(470, 682);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(119, 35);
            this.UpdateBtn.TabIndex = 17;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // MiddleBox
            // 
            this.MiddleBox.Location = new System.Drawing.Point(617, 689);
            this.MiddleBox.Name = "MiddleBox";
            this.MiddleBox.Size = new System.Drawing.Size(100, 23);
            this.MiddleBox.TabIndex = 19;
            // 
            // EMPLOYEES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.MiddleBox);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "EMPLOYEES";
            this.Text = "EMPLOYEE";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button ProductBtn;
        private Button transBtn;
        private Panel panel1;
        private Button ClrBtn;
        private Button AddEmployeeBtn;
        private TextBox BDaybox;
        private Label label8;
        private TextBox RoleBox;
        private Label label7;
        private Label label5;
        private TextBox EmailBox;
        private TextBox GenderBox;
        private Label label4;
        private TextBox PhoneNoBox;
        private Label label3;
        private Label label1;
        private TextBox SurNameBox;
        private DataGridView EmployeeDataGridView;
        private Label label9;
        private TextBox GivenNameBox;
        private TextBox passwordBox;
        private Label label6;
        private Button logOutBtn;
        private Button DelBtn;
        private Button UpdateBtn;
        private LinkLabel Home;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox MiddleBox;
    }
}