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
            this.textSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // textSum
            // 
            this.textSum.Location = new System.Drawing.Point(28, 124);
            this.textSum.Name = "textSum";
            this.textSum.Size = new System.Drawing.Size(121, 20);
            this.textSum.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Сумма";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(27, 72);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(121, 20);
            this.textNumber.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Номер платежа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Выберете дату";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(174, 38);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 33;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 259);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
    }
}