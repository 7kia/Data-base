namespace GCW.Forms
{
    partial class RateFiltrationForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.radioSearchRateButton = new System.Windows.Forms.RadioButton();
            this.radioSearchNameRateButton = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioRateButton = new System.Windows.Forms.RadioButton();
            this.radioNameRateButton = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.radioSearchRateButton);
            this.groupBox2.Controls.Add(this.radioSearchNameRateButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(24, 62);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(218, 20);
            this.textBoxSearch.TabIndex = 8;
            // 
            // radioSearchRateButton
            // 
            this.radioSearchRateButton.AutoSize = true;
            this.radioSearchRateButton.Location = new System.Drawing.Point(171, 28);
            this.radioSearchRateButton.Name = "radioSearchRateButton";
            this.radioSearchRateButton.Size = new System.Drawing.Size(58, 17);
            this.radioSearchRateButton.TabIndex = 7;
            this.radioSearchRateButton.TabStop = true;
            this.radioSearchRateButton.Text = "Тариф";
            this.radioSearchRateButton.UseVisualStyleBackColor = true;
            this.radioSearchRateButton.CheckedChanged += new System.EventHandler(this.radioSearchRateButton_CheckedChanged);
            // 
            // radioSearchNameRateButton
            // 
            this.radioSearchNameRateButton.AutoSize = true;
            this.radioSearchNameRateButton.Location = new System.Drawing.Point(24, 28);
            this.radioSearchNameRateButton.Name = "radioSearchNameRateButton";
            this.radioSearchNameRateButton.Size = new System.Drawing.Size(115, 17);
            this.radioSearchNameRateButton.TabIndex = 6;
            this.radioSearchNameRateButton.TabStop = true;
            this.radioSearchNameRateButton.Text = "Название тарифа";
            this.radioSearchNameRateButton.UseVisualStyleBackColor = true;
            this.radioSearchNameRateButton.CheckedChanged += new System.EventHandler(this.radioSearchNameRateButton_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(103, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioRateButton);
            this.groupBox1.Controls.Add(this.radioNameRateButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioRateButton
            // 
            this.radioRateButton.AutoSize = true;
            this.radioRateButton.Location = new System.Drawing.Point(171, 43);
            this.radioRateButton.Name = "radioRateButton";
            this.radioRateButton.Size = new System.Drawing.Size(58, 17);
            this.radioRateButton.TabIndex = 7;
            this.radioRateButton.TabStop = true;
            this.radioRateButton.Text = "Тариф";
            this.radioRateButton.UseVisualStyleBackColor = true;
            this.radioRateButton.CheckedChanged += new System.EventHandler(this.radioRateButton_CheckedChanged);
            // 
            // radioNameRateButton
            // 
            this.radioNameRateButton.AutoSize = true;
            this.radioNameRateButton.Location = new System.Drawing.Point(24, 43);
            this.radioNameRateButton.Name = "radioNameRateButton";
            this.radioNameRateButton.Size = new System.Drawing.Size(115, 17);
            this.radioNameRateButton.TabIndex = 6;
            this.radioNameRateButton.TabStop = true;
            this.radioNameRateButton.Text = "Название тарифа";
            this.radioNameRateButton.UseVisualStyleBackColor = true;
            this.radioNameRateButton.CheckedChanged += new System.EventHandler(this.radioNameRateButton_CheckedChanged);
            // 
            // RateFiltrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "RateFiltrationForm";
            this.Text = "RateFiltrationForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton radioSearchRateButton;
        private System.Windows.Forms.RadioButton radioSearchNameRateButton;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioRateButton;
        private System.Windows.Forms.RadioButton radioNameRateButton;
    }
}