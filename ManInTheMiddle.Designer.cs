namespace SalesRep
{
    partial class ManInTheMiddle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManInTheMiddle));
            this.logOutBtn = new System.Windows.Forms.Button();
            this.ProceedBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Wheat;
            this.logOutBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logOutBtn.Location = new System.Drawing.Point(12, 452);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(134, 37);
            this.logOutBtn.TabIndex = 15;
            this.logOutBtn.Text = "LOG OUT";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // ProceedBtn
            // 
            this.ProceedBtn.BackColor = System.Drawing.Color.Wheat;
            this.ProceedBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProceedBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProceedBtn.Location = new System.Drawing.Point(697, 452);
            this.ProceedBtn.Name = "ProceedBtn";
            this.ProceedBtn.Size = new System.Drawing.Size(134, 37);
            this.ProceedBtn.TabIndex = 16;
            this.ProceedBtn.Text = "PROCEED";
            this.ProceedBtn.UseVisualStyleBackColor = false;
            this.ProceedBtn.Click += new System.EventHandler(this.ProceedBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(203, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "TAKE A BREAK WHEN NECESSARY \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(476, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "BUT KEEP MOVING FOWARD";
            // 
            // ManInTheMiddle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(843, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProceedBtn);
            this.Controls.Add(this.logOutBtn);
            this.Name = "ManInTheMiddle";
            this.Text = "ManInTheMiddle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button logOutBtn;
        private Button ProceedBtn;
        private Label label1;
        private Label label2;
    }
}