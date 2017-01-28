namespace GCW.Forms
{
    partial class ServiceToApartment
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxIdApartment = new System.Windows.Forms.ComboBox();
            this.comboBoxIdService = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id квартиры";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id услуги";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxIdApartment
            // 
            this.comboBoxIdApartment.FormattingEnabled = true;
            this.comboBoxIdApartment.Location = new System.Drawing.Point(79, 40);
            this.comboBoxIdApartment.Name = "comboBoxIdApartment";
            this.comboBoxIdApartment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdApartment.TabIndex = 20;
            this.comboBoxIdApartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdApartment_SelectedIndexChanged);
            // 
            // comboBoxIdService
            // 
            this.comboBoxIdService.FormattingEnabled = true;
            this.comboBoxIdService.Location = new System.Drawing.Point(79, 106);
            this.comboBoxIdService.Name = "comboBoxIdService";
            this.comboBoxIdService.Size = new System.Drawing.Size(121, 21);
            this.comboBoxIdService.TabIndex = 21;
            this.comboBoxIdService.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdService_SelectedIndexChanged);
            // 
            // ServiceToApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 201);
            this.Controls.Add(this.comboBoxIdService);
            this.Controls.Add(this.comboBoxIdApartment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ServiceToApartment";
            this.Text = "ServiceToApartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxIdApartment;
        private System.Windows.Forms.ComboBox comboBoxIdService;
    }
}