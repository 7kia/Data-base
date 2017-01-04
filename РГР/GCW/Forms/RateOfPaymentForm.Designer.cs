namespace GCW.Forms
{
    partial class RateOfPaymentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxIsPaid = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxIdRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id тарифа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id платежа";
            // 
            // checkBoxIsPaid
            // 
            this.checkBoxIsPaid.AutoSize = true;
            this.checkBoxIsPaid.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxIsPaid.Location = new System.Drawing.Point(115, 158);
            this.checkBoxIsPaid.Name = "checkBoxIsPaid";
            this.checkBoxIsPaid.Size = new System.Drawing.Size(60, 31);
            this.checkBoxIsPaid.TabIndex = 18;
            this.checkBoxIsPaid.Text = "Оплачено";
            this.checkBoxIsPaid.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxIdRate
            // 
            this.comboBoxIdRate.FormattingEnabled = true;
            this.comboBoxIdRate.Location = new System.Drawing.Point(89, 43);
            this.comboBoxIdRate.Name = "comboBoxIdRate";
            this.comboBoxIdRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdRate.TabIndex = 20;
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Location = new System.Drawing.Point(89, 109);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPayment.TabIndex = 21;
            // 
            // RateOfPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 261);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.comboBoxIdRate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxIsPaid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "RateOfPaymentForm";
            this.Text = "RateOfPaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxIsPaid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxIdRate;
        private System.Windows.Forms.ComboBox comboBoxPayment;
    }
}