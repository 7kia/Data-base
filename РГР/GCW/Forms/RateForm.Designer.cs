namespace GCW.Forms
{
    partial class RateForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogoTextBox = new System.Windows.Forms.TextBox();
            this.SeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Тариф";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(48, 75);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(142, 20);
            this.textBoxRate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название тарифа";
            // 
            // textBoxNameRate
            // 
            this.textBoxNameRate.Location = new System.Drawing.Point(48, 36);
            this.textBoxNameRate.Name = "textBoxNameRate";
            this.textBoxNameRate.Size = new System.Drawing.Size(142, 20);
            this.textBoxNameRate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Logo кампании";
            // 
            // LogoTextBox
            // 
            this.LogoTextBox.Location = new System.Drawing.Point(48, 114);
            this.LogoTextBox.Name = "LogoTextBox";
            this.LogoTextBox.Size = new System.Drawing.Size(142, 20);
            this.LogoTextBox.TabIndex = 22;
            this.LogoTextBox.TextChanged += new System.EventHandler(this.LogoTextBox_TextChanged);
            this.LogoTextBox.DoubleClick += new System.EventHandler(this.LogoTextBox_Click);
            // 
            // SeeButton
            // 
            this.SeeButton.Location = new System.Drawing.Point(76, 140);
            this.SeeButton.Name = "SeeButton";
            this.SeeButton.Size = new System.Drawing.Size(88, 23);
            this.SeeButton.TabIndex = 23;
            this.SeeButton.Text = "Посмотреть";
            this.SeeButton.UseVisualStyleBackColor = true;
            this.SeeButton.Click += new System.EventHandler(this.seeButton_Click);
            // 
            // RateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 215);
            this.Controls.Add(this.SeeButton);
            this.Controls.Add(this.LogoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.button1);
            this.Name = "RateForm";
            this.Text = "RateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogoTextBox;
        private System.Windows.Forms.Button SeeButton;
    }
}