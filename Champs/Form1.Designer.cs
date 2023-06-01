namespace Champs
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
            this.NameTxt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.YearCmboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputLabel2 = new System.Windows.Forms.Label();
            this.NameTxt2 = new System.Windows.Forms.TextBox();
            this.YearCmboBox2 = new System.Windows.Forms.ComboBox();
            this.SearchBtn1 = new System.Windows.Forms.Button();
            this.SearchBtn2 = new System.Windows.Forms.Button();
            this.DefLabel = new System.Windows.Forms.Label();
            this.DefinitionTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTxt1
            // 
            this.NameTxt1.Location = new System.Drawing.Point(133, 14);
            this.NameTxt1.Name = "NameTxt1";
            this.NameTxt1.Size = new System.Drawing.Size(283, 31);
            this.NameTxt1.TabIndex = 1;
            this.NameTxt1.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Name:";
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.Location = new System.Drawing.Point(21, 48);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(135, 25);
            this.outputLabel1.TabIndex = 3;
            this.outputLabel1.Text = "Individual Data:";
            // 
            // YearCmboBox1
            // 
            this.YearCmboBox1.FormattingEnabled = true;
            this.YearCmboBox1.Location = new System.Drawing.Point(411, 14);
            this.YearCmboBox1.Name = "YearCmboBox1";
            this.YearCmboBox1.Size = new System.Drawing.Size(86, 33);
            this.YearCmboBox1.TabIndex = 4;
            this.YearCmboBox1.Text = "    Year";
            this.YearCmboBox1.SelectedIndexChanged += new System.EventHandler(this.YearCmboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Name:";
            // 
            // outputLabel2
            // 
            this.outputLabel2.AutoSize = true;
            this.outputLabel2.Location = new System.Drawing.Point(503, 54);
            this.outputLabel2.Name = "outputLabel2";
            this.outputLabel2.Size = new System.Drawing.Size(135, 25);
            this.outputLabel2.TabIndex = 6;
            this.outputLabel2.Text = "Individual Data:";
            // 
            // NameTxt2
            // 
            this.NameTxt2.Location = new System.Drawing.Point(624, 20);
            this.NameTxt2.Name = "NameTxt2";
            this.NameTxt2.Size = new System.Drawing.Size(283, 31);
            this.NameTxt2.TabIndex = 7;
            // 
            // YearCmboBox2
            // 
            this.YearCmboBox2.FormattingEnabled = true;
            this.YearCmboBox2.Location = new System.Drawing.Point(904, 20);
            this.YearCmboBox2.Name = "YearCmboBox2";
            this.YearCmboBox2.Size = new System.Drawing.Size(86, 33);
            this.YearCmboBox2.TabIndex = 8;
            this.YearCmboBox2.Text = "    Year";
            // 
            // SearchBtn1
            // 
            this.SearchBtn1.Location = new System.Drawing.Point(411, 48);
            this.SearchBtn1.Name = "SearchBtn1";
            this.SearchBtn1.Size = new System.Drawing.Size(86, 36);
            this.SearchBtn1.TabIndex = 0;
            this.SearchBtn1.Text = "Search";
            this.SearchBtn1.UseVisualStyleBackColor = true;
            this.SearchBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBtn2
            // 
            this.SearchBtn2.Location = new System.Drawing.Point(904, 54);
            this.SearchBtn2.Name = "SearchBtn2";
            this.SearchBtn2.Size = new System.Drawing.Size(86, 36);
            this.SearchBtn2.TabIndex = 9;
            this.SearchBtn2.Text = "Search";
            this.SearchBtn2.UseVisualStyleBackColor = true;
            this.SearchBtn2.Click += new System.EventHandler(this.SearchBtn2_Click);
            // 
            // DefLabel
            // 
            this.DefLabel.AutoSize = true;
            this.DefLabel.Location = new System.Drawing.Point(4, 690);
            this.DefLabel.Name = "DefLabel";
            this.DefLabel.Size = new System.Drawing.Size(132, 25);
            this.DefLabel.TabIndex = 11;
            this.DefLabel.Text = "Define Statistic:";
            // 
            // DefinitionTxt
            // 
            this.DefinitionTxt.Location = new System.Drawing.Point(133, 690);
            this.DefinitionTxt.Name = "DefinitionTxt";
            this.DefinitionTxt.Size = new System.Drawing.Size(283, 31);
            this.DefinitionTxt.TabIndex = 12;
            // 
            // SearchBtn3
            // 
            this.SearchBtn3.Location = new System.Drawing.Point(411, 690);
            this.SearchBtn3.Name = "SearchBtn3";
            this.SearchBtn3.Size = new System.Drawing.Size(86, 36);
            this.SearchBtn3.TabIndex = 13;
            this.SearchBtn3.Text = "Search";
            this.SearchBtn3.UseVisualStyleBackColor = true;
            this.SearchBtn3.Click += new System.EventHandler(this.SearchBtn3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 835);
            this.Controls.Add(this.SearchBtn3);
            this.Controls.Add(this.DefinitionTxt);
            this.Controls.Add(this.DefLabel);
            this.Controls.Add(this.SearchBtn2);
            this.Controls.Add(this.YearCmboBox2);
            this.Controls.Add(this.NameTxt2);
            this.Controls.Add(this.outputLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YearCmboBox1);
            this.Controls.Add(this.outputLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTxt1);
            this.Controls.Add(this.SearchBtn1);
            this.Name = "Form1";
            this.Text = "NBA Playoff Stats";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox NameTxt1;
        private Label label1;
        private Label outputLabel1;
        private ComboBox YearCmboBox1;
        private Label label2;
        private Label outputLabel2;
        private TextBox NameTxt2;
        private ComboBox YearCmboBox2;
        private Button SearchBtn1;
        private Button SearchBtn2;
        private Label DefLabel;
        private TextBox DefinitionTxt;
        private Button SearchBtn3;
    }
}