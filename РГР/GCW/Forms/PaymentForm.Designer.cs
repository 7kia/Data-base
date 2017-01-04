namespace GCW.Forms
{
    partial class PaymentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxApartment = new System.Windows.Forms.ComboBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Номер платежа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id квартиры";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxApartment
            // 
            this.comboBoxApartment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxApartment.FormattingEnabled = true;
            this.comboBoxApartment.Location = new System.Drawing.Point(42, 42);
            this.comboBoxApartment.Name = "comboBoxApartment";
            this.comboBoxApartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxApartment.TabIndex = 23;
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(42, 108);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(121, 20);
            this.textNumber.TabIndex = 24;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 207);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.comboBoxApartment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxApartment;
        private System.Windows.Forms.TextBox textNumber;
    }
}