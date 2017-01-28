namespace GCW.Forms
{
    partial class ApartmentFiltrationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNumberPaymentButton = new System.Windows.Forms.RadioButton();
            this.radioAddressButton = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioSearchNumberPaymentButton = new System.Windows.Forms.RadioButton();
            this.radioSearchAddressButton = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNumberPaymentButton);
            this.groupBox1.Controls.Add(this.radioAddressButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioNumberPaymentButton
            // 
            this.radioNumberPaymentButton.AutoSize = true;
            this.radioNumberPaymentButton.Location = new System.Drawing.Point(137, 43);
            this.radioNumberPaymentButton.Name = "radioNumberPaymentButton";
            this.radioNumberPaymentButton.Size = new System.Drawing.Size(105, 17);
            this.radioNumberPaymentButton.TabIndex = 7;
            this.radioNumberPaymentButton.TabStop = true;
            this.radioNumberPaymentButton.Text = "Номер платежа";
            this.radioNumberPaymentButton.UseVisualStyleBackColor = true;
            this.radioNumberPaymentButton.CheckedChanged += new System.EventHandler(this.radioNumberPaymentButton_CheckedChanged);
            // 
            // radioAddressButton
            // 
            this.radioAddressButton.AutoSize = true;
            this.radioAddressButton.Location = new System.Drawing.Point(24, 43);
            this.radioAddressButton.Name = "radioAddressButton";
            this.radioAddressButton.Size = new System.Drawing.Size(56, 17);
            this.radioAddressButton.TabIndex = 6;
            this.radioAddressButton.TabStop = true;
            this.radioAddressButton.Text = "Адрес";
            this.radioAddressButton.UseVisualStyleBackColor = true;
            this.radioAddressButton.CheckedChanged += new System.EventHandler(this.radioAddressButton_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(103, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.radioSearchNumberPaymentButton);
            this.groupBox2.Controls.Add(this.radioSearchAddressButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // radioSearchNumberPaymentButton
            // 
            this.radioSearchNumberPaymentButton.AutoSize = true;
            this.radioSearchNumberPaymentButton.Location = new System.Drawing.Point(137, 28);
            this.radioSearchNumberPaymentButton.Name = "radioSearchNumberPaymentButton";
            this.radioSearchNumberPaymentButton.Size = new System.Drawing.Size(105, 17);
            this.radioSearchNumberPaymentButton.TabIndex = 7;
            this.radioSearchNumberPaymentButton.TabStop = true;
            this.radioSearchNumberPaymentButton.Text = "Номер платежа";
            this.radioSearchNumberPaymentButton.UseVisualStyleBackColor = true;
            this.radioSearchNumberPaymentButton.CheckedChanged += new System.EventHandler(this.radioSearchNumberPaymentButton_CheckedChanged);
            // 
            // radioSearchAddressButton
            // 
            this.radioSearchAddressButton.AutoSize = true;
            this.radioSearchAddressButton.Location = new System.Drawing.Point(24, 28);
            this.radioSearchAddressButton.Name = "radioSearchAddressButton";
            this.radioSearchAddressButton.Size = new System.Drawing.Size(56, 17);
            this.radioSearchAddressButton.TabIndex = 6;
            this.radioSearchAddressButton.TabStop = true;
            this.radioSearchAddressButton.Text = "Адрес";
            this.radioSearchAddressButton.UseVisualStyleBackColor = true;
            this.radioSearchAddressButton.CheckedChanged += new System.EventHandler(this.radioSearchAddressButton_CheckedChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(24, 62);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(218, 20);
            this.textBoxSearch.TabIndex = 8;
            // 
            // ApartmentFiltrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "ApartmentFiltrationForm";
            this.Text = "ApartmentFiltrationForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNumberPaymentButton;
        private System.Windows.Forms.RadioButton radioAddressButton;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSearchNumberPaymentButton;
        private System.Windows.Forms.RadioButton radioSearchAddressButton;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}