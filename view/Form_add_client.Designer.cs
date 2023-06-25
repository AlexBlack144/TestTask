namespace TestTask.view
{
    partial class Form_add_client
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
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_client_name = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label_Connect_to_form_add_client = new System.Windows.Forms.Label();
            this.label_client_name = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(138, 199);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(110, 42);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_client_name
            // 
            this.textBox_client_name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_client_name.Location = new System.Drawing.Point(103, 96);
            this.textBox_client_name.Name = "textBox_client_name";
            this.textBox_client_name.Size = new System.Drawing.Size(188, 20);
            this.textBox_client_name.TabIndex = 11;
            this.textBox_client_name.Text = "Вася...";
            this.textBox_client_name.Enter += new System.EventHandler(this.textBox_client_name_Enter);
            // 
            // textBox_address
            // 
            this.textBox_address.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_address.Location = new System.Drawing.Point(103, 152);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(188, 20);
            this.textBox_address.TabIndex = 12;
            this.textBox_address.Text = "Из Голивуда...";
            this.textBox_address.Enter += new System.EventHandler(this.textBox_address_Enter);
            // 
            // label_Connect_to_form_add_client
            // 
            this.label_Connect_to_form_add_client.AutoSize = true;
            this.label_Connect_to_form_add_client.Font = new System.Drawing.Font("Aileron Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Connect_to_form_add_client.Location = new System.Drawing.Point(28, 30);
            this.label_Connect_to_form_add_client.Name = "label_Connect_to_form_add_client";
            this.label_Connect_to_form_add_client.Size = new System.Drawing.Size(366, 29);
            this.label_Connect_to_form_add_client.TabIndex = 13;
            this.label_Connect_to_form_add_client.Text = "Добавление нового клиента";
            // 
            // label_client_name
            // 
            this.label_client_name.AutoSize = true;
            this.label_client_name.Location = new System.Drawing.Point(100, 80);
            this.label_client_name.Name = "label_client_name";
            this.label_client_name.Size = new System.Drawing.Size(76, 13);
            this.label_client_name.TabIndex = 14;
            this.label_client_name.Text = "Имя клиента:";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(100, 136);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(91, 13);
            this.label_address.TabIndex = 15;
            this.label_address.Text = "Адресс клиента:";
            // 
            // Form_add_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 255);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_client_name);
            this.Controls.Add(this.label_Connect_to_form_add_client);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_client_name);
            this.Controls.Add(this.button_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_add_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_client_name;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label_Connect_to_form_add_client;
        private System.Windows.Forms.Label label_client_name;
        private System.Windows.Forms.Label label_address;
    }
}