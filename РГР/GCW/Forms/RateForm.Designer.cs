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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.comboBoxSetlement = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id услуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id типа населённого пункта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Тариф";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(28, 174);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(142, 20);
            this.textBoxRate.TabIndex = 14;
            // 
            // comboBoxService
            // 
            this.comboBoxService.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(38, 40);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(121, 21);
            this.comboBoxService.TabIndex = 22;
            // 
            // comboBoxSetlement
            // 
            this.comboBoxSetlement.FormattingEnabled = true;
            this.comboBoxSetlement.Location = new System.Drawing.Point(38, 106);
            this.comboBoxSetlement.Name = "comboBoxSetlement";
            this.comboBoxSetlement.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSetlement.TabIndex = 23;
            // 
            // RateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 261);
            this.Controls.Add(this.comboBoxSetlement);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "RateForm";
            this.Text = "RateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.ComboBox comboBoxSetlement;
    }
}