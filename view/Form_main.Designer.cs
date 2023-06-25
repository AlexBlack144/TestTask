namespace TestTask.view
{
    partial class Form_main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_main = new System.Windows.Forms.TabPage();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.tabPage_more = new System.Windows.Forms.TabPage();
            this.button_add2 = new System.Windows.Forms.Button();
            this.dataGridView_more = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_update = new System.Windows.Forms.Button();
            this.button_update1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            this.tabPage_more.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_more)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_main);
            this.tabControl1.Controls.Add(this.tabPage_more);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_main
            // 
            this.tabPage_main.Controls.Add(this.button_update1);
            this.tabPage_main.Controls.Add(this.button_add);
            this.tabPage_main.Controls.Add(this.dataGridView_main);
            this.tabPage_main.Location = new System.Drawing.Point(4, 22);
            this.tabPage_main.Name = "tabPage_main";
            this.tabPage_main.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main.Size = new System.Drawing.Size(645, 408);
            this.tabPage_main.TabIndex = 0;
            this.tabPage_main.Text = "Клиенты";
            this.tabPage_main.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(125, 353);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(110, 42);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Location = new System.Drawing.Point(3, 0);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.Size = new System.Drawing.Size(642, 336);
            this.dataGridView_main.TabIndex = 0;
            this.dataGridView_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_main_CellClick);
            this.dataGridView_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_main_CellDoubleClick);
            this.dataGridView_main.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_main_CellFormatting);
            // 
            // tabPage_more
            // 
            this.tabPage_more.Controls.Add(this.button_update);
            this.tabPage_more.Controls.Add(this.button_add2);
            this.tabPage_more.Controls.Add(this.dataGridView_more);
            this.tabPage_more.Location = new System.Drawing.Point(4, 22);
            this.tabPage_more.Name = "tabPage_more";
            this.tabPage_more.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_more.Size = new System.Drawing.Size(645, 408);
            this.tabPage_more.TabIndex = 1;
            this.tabPage_more.Text = "Подробнее";
            this.tabPage_more.UseVisualStyleBackColor = true;
            // 
            // button_add2
            // 
            this.button_add2.Location = new System.Drawing.Point(125, 353);
            this.button_add2.Name = "button_add2";
            this.button_add2.Size = new System.Drawing.Size(110, 42);
            this.button_add2.TabIndex = 2;
            this.button_add2.Text = "Добавить";
            this.button_add2.UseVisualStyleBackColor = true;
            this.button_add2.Click += new System.EventHandler(this.button_add2_Click);
            // 
            // dataGridView_more
            // 
            this.dataGridView_more.AllowUserToAddRows = false;
            this.dataGridView_more.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_more.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Name_product,
            this.Price,
            this.Count,
            this.Sum,
            this.Delete,
            this.Update});
            this.dataGridView_more.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_more.Name = "dataGridView_more";
            this.dataGridView_more.Size = new System.Drawing.Size(645, 336);
            this.dataGridView_more.TabIndex = 1;
            this.dataGridView_more.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_more_CellClick);
            this.dataGridView_more.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_more_CellDoubleClick);
            this.dataGridView_more.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_more_CellFormatting);
            // 
            // Id
            // 
            this.Id.HeaderText = "Код заказа";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Name_product
            // 
            this.Name_product.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Name_product.DisplayStyleForCurrentCellOnly = true;
            this.Name_product.HeaderText = "Продукт";
            this.Name_product.Name = "Name_product";
            this.Name_product.Width = 120;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена $";
            this.Price.Name = "Price";
            this.Price.Width = 70;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            this.Count.Width = 80;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Общая сумма $";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Удалить";
            this.Delete.Name = "Delete";
            this.Delete.Width = 80;
            // 
            // Update
            // 
            this.Update.HeaderText = "Изминить";
            this.Update.Name = "Update";
            this.Update.Width = 80;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(389, 353);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(110, 42);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_update1
            // 
            this.button_update1.Location = new System.Drawing.Point(390, 353);
            this.button_update1.Name = "button_update1";
            this.button_update1.Size = new System.Drawing.Size(110, 42);
            this.button_update1.TabIndex = 4;
            this.button_update1.Text = "Обновить";
            this.button_update1.UseVisualStyleBackColor = true;
            this.button_update1.Click += new System.EventHandler(this.button_update1_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 428);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosed);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.tabPage_more.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_more)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_main;
        private System.Windows.Forms.TabPage tabPage_more;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.Button button_add2;
        private System.Windows.Forms.DataGridView dataGridView_more;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewComboBoxColumn Name_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_update1;
    }
}