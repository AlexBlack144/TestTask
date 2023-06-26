namespace TestTask.view
{
    partial class Form_add_order_lines
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
            this.label_Connect_to_form_add_order_lines = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label_count = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label_product = new System.Windows.Forms.Label();
            this.comboBox_product = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_Connect_to_form_add_order_lines
            // 
            this.label_Connect_to_form_add_order_lines.AutoSize = true;
            this.label_Connect_to_form_add_order_lines.Font = new System.Drawing.Font("Aileron Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Connect_to_form_add_order_lines.Location = new System.Drawing.Point(81, 36);
            this.label_Connect_to_form_add_order_lines.Name = "label_Connect_to_form_add_order_lines";
            this.label_Connect_to_form_add_order_lines.Size = new System.Drawing.Size(188, 58);
            this.label_Connect_to_form_add_order_lines.TabIndex = 14;
            this.label_Connect_to_form_add_order_lines.Text = "  Добавление \r\nнового заказа\r\n";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(121, 309);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(110, 42);
            this.button_add.TabIndex = 15;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(98, 177);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(45, 13);
            this.label_price.TabIndex = 17;
            this.label_price.Text = "Цена $:";
            // 
            // textBox_price
            // 
            this.textBox_price.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_price.Location = new System.Drawing.Point(101, 193);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(121, 20);
            this.textBox_price.TabIndex = 16;
            this.textBox_price.Text = "10000";
            this.textBox_price.Enter += new System.EventHandler(this.textBox_price_Enter);
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_price_KeyPress);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(98, 231);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(69, 13);
            this.label_count.TabIndex = 19;
            this.label_count.Text = "Количество:";
            // 
            // textBox_count
            // 
            this.textBox_count.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_count.Location = new System.Drawing.Point(101, 247);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(66, 20);
            this.textBox_count.TabIndex = 18;
            this.textBox_count.Text = "1";
            this.textBox_count.Enter += new System.EventHandler(this.textBox_count_Enter);
            this.textBox_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_count_KeyPress);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Location = new System.Drawing.Point(98, 127);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(52, 13);
            this.label_product.TabIndex = 20;
            this.label_product.Text = "Продукт:";
            // 
            // comboBox_product
            // 
            this.comboBox_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_product.Location = new System.Drawing.Point(101, 143);
            this.comboBox_product.Name = "comboBox_product";
            this.comboBox_product.Size = new System.Drawing.Size(155, 21);
            this.comboBox_product.TabIndex = 21;
            // 
            // Form_add_order_lines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 376);
            this.Controls.Add(this.comboBox_product);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_Connect_to_form_add_order_lines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_add_order_lines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_add_order_lines";
            this.Load += new System.EventHandler(this.Form_add_order_lines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Connect_to_form_add_order_lines;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.ComboBox comboBox_product;
    }
}