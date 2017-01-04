namespace GCW.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip_MainMenu = new System.Windows.Forms.MenuStrip();
            this.выборТаблицыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квартирыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифВПлатежеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типНаселённогоПунктаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_MainTable = new System.Windows.Forms.DataGridView();
            this.dataGridView_DependentTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripDependent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MainTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DependentTable)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.contextMenuStripDependent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_MainMenu
            // 
            this.menuStrip_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборТаблицыToolStripMenuItem1,
            this.редактированиеToolStripMenuItem});
            this.menuStrip_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainMenu.Name = "menuStrip_MainMenu";
            this.menuStrip_MainMenu.Size = new System.Drawing.Size(843, 24);
            this.menuStrip_MainMenu.TabIndex = 6;
            this.menuStrip_MainMenu.Text = "menuStrip_MainMenu";
            // 
            // выборТаблицыToolStripMenuItem1
            // 
            this.выборТаблицыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectTableToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.выборТаблицыToolStripMenuItem1.Name = "выборТаблицыToolStripMenuItem1";
            this.выборТаблицыToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.выборТаблицыToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.выборТаблицыToolStripMenuItem1.Text = "Меню";
            // 
            // SelectTableToolStripMenuItem
            // 
            this.SelectTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квартирыToolStripMenuItem,
            this.оплатаToolStripMenuItem,
            this.тарифToolStripMenuItem,
            this.тарифВПлатежеToolStripMenuItem,
            this.типНаселённогоПунктаToolStripMenuItem,
            this.услугиToolStripMenuItem});
            this.SelectTableToolStripMenuItem.Name = "SelectTableToolStripMenuItem";
            this.SelectTableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.SelectTableToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.SelectTableToolStripMenuItem.Text = "Выбор таблицы";
            // 
            // квартирыToolStripMenuItem
            // 
            this.квартирыToolStripMenuItem.Name = "квартирыToolStripMenuItem";
            this.квартирыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.квартирыToolStripMenuItem.Text = "Квартиры";
            this.квартирыToolStripMenuItem.Click += new System.EventHandler(this.квартирыToolStripMenuItem_Click);
            // 
            // оплатаToolStripMenuItem
            // 
            this.оплатаToolStripMenuItem.Name = "оплатаToolStripMenuItem";
            this.оплатаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.оплатаToolStripMenuItem.Text = "Оплата";
            this.оплатаToolStripMenuItem.Click += new System.EventHandler(this.оплатаToolStripMenuItem_Click);
            // 
            // тарифToolStripMenuItem
            // 
            this.тарифToolStripMenuItem.Name = "тарифToolStripMenuItem";
            this.тарифToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.тарифToolStripMenuItem.Text = "Тариф";
            this.тарифToolStripMenuItem.Click += new System.EventHandler(this.тарифToolStripMenuItem_Click);
            // 
            // тарифВПлатежеToolStripMenuItem
            // 
            this.тарифВПлатежеToolStripMenuItem.Name = "тарифВПлатежеToolStripMenuItem";
            this.тарифВПлатежеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.тарифВПлатежеToolStripMenuItem.Text = "Тариф в платеже";
            this.тарифВПлатежеToolStripMenuItem.Click += new System.EventHandler(this.тарифВПлатежеToolStripMenuItem_Click);
            // 
            // типНаселённогоПунктаToolStripMenuItem
            // 
            this.типНаселённогоПунктаToolStripMenuItem.Name = "типНаселённогоПунктаToolStripMenuItem";
            this.типНаселённогоПунктаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.типНаселённогоПунктаToolStripMenuItem.Text = "Тип населённого пункта";
            this.типНаселённогоПунктаToolStripMenuItem.Click += new System.EventHandler(this.типНаселённогоПунктаToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // dataGridView_MainTable
            // 
            this.dataGridView_MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MainTable.Location = new System.Drawing.Point(22, 76);
            this.dataGridView_MainTable.Name = "dataGridView_MainTable";
            this.dataGridView_MainTable.Size = new System.Drawing.Size(789, 205);
            this.dataGridView_MainTable.TabIndex = 7;
            // 
            // dataGridView_DependentTable
            // 
            this.dataGridView_DependentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DependentTable.Location = new System.Drawing.Point(22, 322);
            this.dataGridView_DependentTable.Name = "dataGridView_DependentTable";
            this.dataGridView_DependentTable.Size = new System.Drawing.Size(789, 265);
            this.dataGridView_DependentTable.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Основная таблица";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Зависимая таблица";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1,
            this.поискToolStripMenuItem1,
            this.сортировкаToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(141, 114);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.изменитьToolStripMenuItem1.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            // 
            // поискToolStripMenuItem1
            // 
            this.поискToolStripMenuItem1.Name = "поискToolStripMenuItem1";
            this.поискToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.поискToolStripMenuItem1.Text = "Поиск";
            // 
            // сортировкаToolStripMenuItem1
            // 
            this.сортировкаToolStripMenuItem1.Name = "сортировкаToolStripMenuItem1";
            this.сортировкаToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.сортировкаToolStripMenuItem1.Text = "Сортировка";
            // 
            // contextMenuStripDependent
            // 
            this.contextMenuStripDependent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2,
            this.изменитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem2,
            this.поискToolStripMenuItem2,
            this.сортировкаToolStripMenuItem2});
            this.contextMenuStripDependent.Name = "contextMenuStripDependent";
            this.contextMenuStripDependent.Size = new System.Drawing.Size(141, 114);
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            // 
            // изменитьToolStripMenuItem2
            // 
            this.изменитьToolStripMenuItem2.Name = "изменитьToolStripMenuItem2";
            this.изменитьToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.изменитьToolStripMenuItem2.Text = "Изменить";
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.удалитьToolStripMenuItem2.Text = "Удалить";
            // 
            // поискToolStripMenuItem2
            // 
            this.поискToolStripMenuItem2.Name = "поискToolStripMenuItem2";
            this.поискToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.поискToolStripMenuItem2.Text = "Поиск";
            // 
            // сортировкаToolStripMenuItem2
            // 
            this.сортировкаToolStripMenuItem2.Name = "сортировкаToolStripMenuItem2";
            this.сортировкаToolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.сортировкаToolStripMenuItem2.Text = "Сортировка";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_DependentTable);
            this.Controls.Add(this.dataGridView_MainTable);
            this.Controls.Add(this.menuStrip_MainMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip_MainMenu.ResumeLayout(false);
            this.menuStrip_MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MainTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DependentTable)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.contextMenuStripDependent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem выборТаблицыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SelectTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квартирыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тарифToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тарифВПлатежеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типНаселённогоПунктаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_MainTable;
        private System.Windows.Forms.DataGridView dataGridView_DependentTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDependent;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem2;
    }
}