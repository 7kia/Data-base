namespace GCW.Forms
{
    partial class PaymentFiltrationForm
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
            this.radioSearchDataButton = new System.Windows.Forms.RadioButton();
            this.radioSearchSumButton = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.radioSearchNumberPaymentButton = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDataButton = new System.Windows.Forms.RadioButton();
            this.radioNumberPaymentButton = new System.Windows.Forms.RadioButton();
            this.radioSumButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.radioSearchDataButton);
            this.groupBox2.Controls.Add(this.radioSearchSumButton);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.radioSearchNumberPaymentButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // radioSearchDataButton
            // 
            this.radioSearchDataButton.AutoSize = true;
            this.radioSearchDataButton.Location = new System.Drawing.Point(200, 28);
            this.radioSearchDataButton.Name = "radioSearchDataButton";
            this.radioSearchDataButton.Size = new System.Drawing.Size(51, 17);
            this.radioSearchDataButton.TabIndex = 9;
            this.radioSearchDataButton.TabStop = true;
            this.radioSearchDataButton.Text = "Дата";
            this.radioSearchDataButton.UseVisualStyleBackColor = true;
            this.radioSearchDataButton.CheckedChanged += new System.EventHandler(this.radioSearchDataButton_CheckedChanged);
            // 
            // radioSearchSumButton
            // 
            this.radioSearchSumButton.AutoSize = true;
            this.radioSearchSumButton.Location = new System.Drawing.Point(24, 28);
            this.radioSearchSumButton.Name = "radioSearchSumButton";
            this.radioSearchSumButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioSearchSumButton.Size = new System.Drawing.Size(59, 17);
            this.radioSearchSumButton.TabIndex = 9;
            this.radioSearchSumButton.TabStop = true;
            this.radioSearchSumButton.Text = "Сумма";
            this.radioSearchSumButton.UseVisualStyleBackColor = true;
            this.radioSearchSumButton.CheckedChanged += new System.EventHandler(this.radioSearchSumButton_CheckedChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(24, 62);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(256, 20);
            this.textBoxSearch.TabIndex = 8;
            // 
            // radioSearchNumberPaymentButton
            // 
            this.radioSearchNumberPaymentButton.AutoSize = true;
            this.radioSearchNumberPaymentButton.Location = new System.Drawing.Point(89, 28);
            this.radioSearchNumberPaymentButton.Name = "radioSearchNumberPaymentButton";
            this.radioSearchNumberPaymentButton.Size = new System.Drawing.Size(105, 17);
            this.radioSearchNumberPaymentButton.TabIndex = 7;
            this.radioSearchNumberPaymentButton.TabStop = true;
            this.radioSearchNumberPaymentButton.Text = "Номер платежа";
            this.radioSearchNumberPaymentButton.UseVisualStyleBackColor = true;
            this.radioSearchNumberPaymentButton.CheckedChanged += new System.EventHandler(this.radioSearchNumberPaymentButton_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(119, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDataButton);
            this.groupBox1.Controls.Add(this.radioNumberPaymentButton);
            this.groupBox1.Controls.Add(this.radioSumButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioDataButton
            // 
            this.radioDataButton.AutoSize = true;
            this.radioDataButton.Location = new System.Drawing.Point(200, 43);
            this.radioDataButton.Name = "radioDataButton";
            this.radioDataButton.Size = new System.Drawing.Size(51, 17);
            this.radioDataButton.TabIndex = 8;
            this.radioDataButton.TabStop = true;
            this.radioDataButton.Text = "Дата";
            this.radioDataButton.UseVisualStyleBackColor = true;
            this.radioDataButton.CheckedChanged += new System.EventHandler(this.radioDataButton_CheckedChanged);
            // 
            // radioNumberPaymentButton
            // 
            this.radioNumberPaymentButton.AutoSize = true;
            this.radioNumberPaymentButton.Location = new System.Drawing.Point(89, 43);
            this.radioNumberPaymentButton.Name = "radioNumberPaymentButton";
            this.radioNumberPaymentButton.Size = new System.Drawing.Size(105, 17);
            this.radioNumberPaymentButton.TabIndex = 7;
            this.radioNumberPaymentButton.TabStop = true;
            this.radioNumberPaymentButton.Text = "Номер платежа";
            this.radioNumberPaymentButton.UseVisualStyleBackColor = true;
            this.radioNumberPaymentButton.CheckedChanged += new System.EventHandler(this.radioNumberPaymentButton_CheckedChanged);
            // 
            // radioSumButton
            // 
            this.radioSumButton.AutoSize = true;
            this.radioSumButton.Location = new System.Drawing.Point(24, 43);
            this.radioSumButton.Name = "radioSumButton";
            this.radioSumButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioSumButton.Size = new System.Drawing.Size(59, 17);
            this.radioSumButton.TabIndex = 6;
            this.radioSumButton.TabStop = true;
            this.radioSumButton.Text = "Сумма";
            this.radioSumButton.UseVisualStyleBackColor = true;
            this.radioSumButton.CheckedChanged += new System.EventHandler(this.radioSumButton_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(24, 62);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker.TabIndex = 10;
            // 
            // PaymentFiltrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentFiltrationForm";
            this.Text = "PaymentFiltrationForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton radioSearchNumberPaymentButton;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNumberPaymentButton;
        private System.Windows.Forms.RadioButton radioSumButton;
        private System.Windows.Forms.RadioButton radioSearchSumButton;
        private System.Windows.Forms.RadioButton radioSearchDataButton;
        private System.Windows.Forms.RadioButton radioDataButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}