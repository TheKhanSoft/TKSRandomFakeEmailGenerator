namespace TKSRandomFakeEmailGenerator
{
    partial class FormRandomEmailGenerator
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
            panel1 = new Panel();
            lblClose = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            numEmailCount = new NumericUpDown();
            txtGeneratedEmails = new TextBox();
            btnGenerate = new Button();
            linkCopyEmail = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEmailCount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(lblClose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 54);
            panel1.TabIndex = 0;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.BackColor = Color.FromArgb(192, 0, 0);
            lblClose.ForeColor = Color.White;
            lblClose.Location = new Point(669, 18);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(19, 18);
            lblClose.TabIndex = 3;
            lblClose.Text = "X";
            lblClose.Click += lblClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 17);
            label1.Name = "label1";
            label1.Size = new Size(315, 21);
            label1.TabIndex = 2;
            label1.Text = "TKS Gandom Fake Emails Generator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TKS_EmailGenerator_Logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.TKS_EmailGenerator_Logo;
            pictureBox2.Location = new Point(12, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(240, 240);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 71);
            label3.Name = "label3";
            label3.Size = new Size(129, 18);
            label3.TabIndex = 4;
            label3.Text = "Number of Emails:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 100);
            label4.Name = "label4";
            label4.Size = new Size(144, 18);
            label4.TabIndex = 5;
            label4.Text = "Generated Email List";
            // 
            // numEmailCount
            // 
            numEmailCount.BackColor = Color.FromArgb(255, 128, 0);
            numEmailCount.BorderStyle = BorderStyle.FixedSingle;
            numEmailCount.ForeColor = Color.White;
            numEmailCount.Location = new Point(393, 69);
            numEmailCount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numEmailCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numEmailCount.Name = "numEmailCount";
            numEmailCount.Size = new Size(123, 25);
            numEmailCount.TabIndex = 6;
            numEmailCount.TextAlign = HorizontalAlignment.Center;
            numEmailCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // txtGeneratedEmails
            // 
            txtGeneratedEmails.Font = new Font("Garamond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGeneratedEmails.Location = new Point(258, 121);
            txtGeneratedEmails.Multiline = true;
            txtGeneratedEmails.Name = "txtGeneratedEmails";
            txtGeneratedEmails.ScrollBars = ScrollBars.Vertical;
            txtGeneratedEmails.Size = new Size(430, 367);
            txtGeneratedEmails.TabIndex = 7;
            txtGeneratedEmails.TextChanged += txtGeneratedEmails_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(255, 128, 0);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(522, 69);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(155, 44);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // linkCopyEmail
            // 
            linkCopyEmail.AutoSize = true;
            linkCopyEmail.Location = new Point(579, 469);
            linkCopyEmail.Name = "linkCopyEmail";
            linkCopyEmail.Size = new Size(89, 18);
            linkCopyEmail.TabIndex = 9;
            linkCopyEmail.TabStop = true;
            linkCopyEmail.Text = "Copy Emails";
            linkCopyEmail.Visible = false;
            linkCopyEmail.VisitedLinkColor = Color.Blue;
            linkCopyEmail.LinkClicked += linkCopyEmail_LinkClicked;
            // 
            // FormRandomEmailGenerator
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(700, 500);
            Controls.Add(linkCopyEmail);
            Controls.Add(btnGenerate);
            Controls.Add(txtGeneratedEmails);
            Controls.Add(numEmailCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Font = new Font("Garamond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormRandomEmailGenerator";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TKS Random Fake Emails Generator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEmailCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblClose;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private NumericUpDown numEmailCount;
        private TextBox txtGeneratedEmails;
        private Button btnGenerate;
        private LinkLabel linkCopyEmail;
    }
}
