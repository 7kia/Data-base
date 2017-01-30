namespace GCW.Forms
{
    partial class ServiceToApartmentFiltrarion
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
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.radioSearchIdServiceButton = new System.Windows.Forms.RadioButton();
            this.radioSearchIdApartmentButton = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioIdServiceButton = new System.Windows.Forms.RadioButton();
            this.radioIdApartmentButton = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textSearchBox);
            this.groupBox2.Controls.Add(this.radioSearchIdServiceButton);
            this.groupBox2.Controls.Add(this.radioSearchIdApartmentButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // textSearchBox
            // 
            this.textSearchBox.Location = new System.Drawing.Point(24, 61);
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(217, 20);
            this.textSearchBox.TabIndex = 15;
            // 
            // radioSearchIdServiceButton
            // 
            this.radioSearchIdServiceButton.AutoSize = true;
            this.radioSearchIdServiceButton.Location = new System.Drawing.Point(171, 28);
            this.radioSearchIdServiceButton.Name = "radioSearchIdServiceButton";
            this.radioSearchIdServiceButton.Size = new System.Drawing.Size(70, 17);
            this.radioSearchIdServiceButton.TabIndex = 7;
            this.radioSearchIdServiceButton.TabStop = true;
            this.radioSearchIdServiceButton.Text = "Id услуги";
            this.radioSearchIdServiceButton.UseVisualStyleBackColor = true;
            this.radioSearchIdServiceButton.CheckedChanged += new System.EventHandler(this.radioSearchIdServiceButton_CheckedChanged);
            // 
            // radioSearchIdApartmentButton
            // 
            this.radioSearchIdApartmentButton.AutoSize = true;
            this.radioSearchIdApartmentButton.Location = new System.Drawing.Point(24, 28);
            this.radioSearchIdApartmentButton.Name = "radioSearchIdApartmentButton";
            this.radioSearchIdApartmentButton.Size = new System.Drawing.Size(86, 17);
            this.radioSearchIdApartmentButton.TabIndex = 6;
            this.radioSearchIdApartmentButton.TabStop = true;
            this.radioSearchIdApartmentButton.Text = "Id квартиры";
            this.radioSearchIdApartmentButton.UseVisualStyleBackColor = true;
            this.radioSearchIdApartmentButton.CheckedChanged += new System.EventHandler(this.radioSearchIdApartmentButton_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(108, 226);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 13;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioIdServiceButton);
            this.groupBox1.Controls.Add(this.radioIdApartmentButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // radioIdServiceButton
            // 
            this.radioIdServiceButton.AutoSize = true;
            this.radioIdServiceButton.Location = new System.Drawing.Point(171, 43);
            this.radioIdServiceButton.Name = "radioIdServiceButton";
            this.radioIdServiceButton.Size = new System.Drawing.Size(70, 17);
            this.radioIdServiceButton.TabIndex = 7;
            this.radioIdServiceButton.TabStop = true;
            this.radioIdServiceButton.Text = "Id услуги";
            this.radioIdServiceButton.UseVisualStyleBackColor = true;
            this.radioIdServiceButton.CheckedChanged += new System.EventHandler(this.radioIdServiceButton_CheckedChanged);
            // 
            // radioIdApartmentButton
            // 
            this.radioIdApartmentButton.AutoSize = true;
            this.radioIdApartmentButton.Location = new System.Drawing.Point(24, 43);
            this.radioIdApartmentButton.Name = "radioIdApartmentButton";
            this.radioIdApartmentButton.Size = new System.Drawing.Size(86, 17);
            this.radioIdApartmentButton.TabIndex = 6;
            this.radioIdApartmentButton.TabStop = true;
            this.radioIdApartmentButton.Text = "Id квартиры";
            this.radioIdApartmentButton.UseVisualStyleBackColor = true;
            this.radioIdApartmentButton.CheckedChanged += new System.EventHandler(this.radioIdApartmentButton_CheckedChanged);
            // 
            // ServiceToApartmentFiltrarion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.Name = "ServiceToApartmentFiltrarion";
            this.Text = "ServiceToApartmentFiltrario";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSearchIdServiceButton;
        private System.Windows.Forms.RadioButton radioSearchIdApartmentButton;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioIdServiceButton;
        private System.Windows.Forms.RadioButton radioIdApartmentButton;
        private System.Windows.Forms.TextBox textSearchBox;
    }
}