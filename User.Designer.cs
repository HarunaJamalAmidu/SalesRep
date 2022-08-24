namespace SmartToll1._0
{
    partial class User
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ReceiptBtn = new System.Windows.Forms.Button();
            this.ReportsGenPanel = new System.Windows.Forms.Panel();
            this.DBcomboBoxSelector = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportGenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ReportsGenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(687, 35);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(627, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(627, 354);
            this.dataGridView1.TabIndex = 2;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(687, 73);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "REMOVE";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // ReceiptBtn
            // 
            this.ReceiptBtn.Location = new System.Drawing.Point(687, 118);
            this.ReceiptBtn.Name = "ReceiptBtn";
            this.ReceiptBtn.Size = new System.Drawing.Size(75, 23);
            this.ReceiptBtn.TabIndex = 4;
            this.ReceiptBtn.Text = "RECEIPT";
            this.ReceiptBtn.UseVisualStyleBackColor = true;
            // 
            // ReportsGenPanel
            // 
            this.ReportsGenPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ReportsGenPanel.Controls.Add(this.DBcomboBoxSelector);
            this.ReportsGenPanel.Controls.Add(this.label12);
            this.ReportsGenPanel.Controls.Add(this.dateTimePicker2);
            this.ReportsGenPanel.Controls.Add(this.label3);
            this.ReportsGenPanel.Controls.Add(this.label2);
            this.ReportsGenPanel.Controls.Add(this.dateTimePicker1);
            this.ReportsGenPanel.Controls.Add(this.label1);
            this.ReportsGenPanel.Controls.Add(this.ReportGenBtn);
            this.ReportsGenPanel.Location = new System.Drawing.Point(254, 153);
            this.ReportsGenPanel.Name = "ReportsGenPanel";
            this.ReportsGenPanel.Size = new System.Drawing.Size(335, 194);
            this.ReportsGenPanel.TabIndex = 5;
            // 
            // DBcomboBoxSelector
            // 
            this.DBcomboBoxSelector.FormattingEnabled = true;
            this.DBcomboBoxSelector.Location = new System.Drawing.Point(84, 43);
            this.DBcomboBoxSelector.Name = "DBcomboBoxSelector";
            this.DBcomboBoxSelector.Size = new System.Drawing.Size(184, 23);
            this.DBcomboBoxSelector.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(5, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "DATABASE";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(80, 112);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 23);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "FROM";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "REPORTS";
            // 
            // ReportGenBtn
            // 
            this.ReportGenBtn.Location = new System.Drawing.Point(93, 141);
            this.ReportGenBtn.Name = "ReportGenBtn";
            this.ReportGenBtn.Size = new System.Drawing.Size(119, 35);
            this.ReportGenBtn.TabIndex = 2;
            this.ReportGenBtn.Text = "GENERATE";
            this.ReportGenBtn.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(843, 501);
            this.Controls.Add(this.ReportsGenPanel);
            this.Controls.Add(this.ReceiptBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddBtn);
            this.Name = "User";
            this.Text = "SALES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ReportsGenPanel.ResumeLayout(false);
            this.ReportsGenPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddBtn;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button RemoveBtn;
        private Button ReceiptBtn;
        private Panel ReportsGenPanel;
        private ComboBox DBcomboBoxSelector;
        private Label label12;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button ReportGenBtn;
    }
}