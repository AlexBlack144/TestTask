namespace TestTask
{
    partial class Form_connect_to_db
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Connect_to_Data_Base = new System.Windows.Forms.Label();
            this.label_login_or_user_name = new System.Windows.Forms.Label();
            this.textBox_login_or_user_name = new System.Windows.Forms.TextBox();
            this.label_Server_name = new System.Windows.Forms.Label();
            this.textBox_Server_name = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.checkBox_login = new System.Windows.Forms.CheckBox();
            this.checkBox_password = new System.Windows.Forms.CheckBox();
            this.label_see = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Connect_to_Data_Base
            // 
            this.label_Connect_to_Data_Base.AutoSize = true;
            this.label_Connect_to_Data_Base.Font = new System.Drawing.Font("Aileron Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Connect_to_Data_Base.Location = new System.Drawing.Point(55, 26);
            this.label_Connect_to_Data_Base.Name = "label_Connect_to_Data_Base";
            this.label_Connect_to_Data_Base.Size = new System.Drawing.Size(269, 29);
            this.label_Connect_to_Data_Base.TabIndex = 6;
            this.label_Connect_to_Data_Base.Text = "Connect to SQL Server";
            // 
            // label_login_or_user_name
            // 
            this.label_login_or_user_name.AutoSize = true;
            this.label_login_or_user_name.Location = new System.Drawing.Point(57, 142);
            this.label_login_or_user_name.Name = "label_login_or_user_name";
            this.label_login_or_user_name.Size = new System.Drawing.Size(100, 13);
            this.label_login_or_user_name.TabIndex = 11;
            this.label_login_or_user_name.Text = "Login \\ User Name:";
            // 
            // textBox_login_or_user_name
            // 
            this.textBox_login_or_user_name.Enabled = false;
            this.textBox_login_or_user_name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_login_or_user_name.Location = new System.Drawing.Point(60, 158);
            this.textBox_login_or_user_name.Name = "textBox_login_or_user_name";
            this.textBox_login_or_user_name.Size = new System.Drawing.Size(188, 20);
            this.textBox_login_or_user_name.TabIndex = 10;
            this.textBox_login_or_user_name.Text = "DESKTOP-06T59HG\\Alex";
            this.textBox_login_or_user_name.Enter += new System.EventHandler(this.textBox_login_or_user_name_Enter);
            // 
            // label_Server_name
            // 
            this.label_Server_name.AutoSize = true;
            this.label_Server_name.Location = new System.Drawing.Point(57, 92);
            this.label_Server_name.Name = "label_Server_name";
            this.label_Server_name.Size = new System.Drawing.Size(70, 13);
            this.label_Server_name.TabIndex = 9;
            this.label_Server_name.Text = "Server name:";
            // 
            // textBox_Server_name
            // 
            this.textBox_Server_name.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Server_name.Location = new System.Drawing.Point(60, 108);
            this.textBox_Server_name.Name = "textBox_Server_name";
            this.textBox_Server_name.Size = new System.Drawing.Size(296, 20);
            this.textBox_Server_name.TabIndex = 8;
            this.textBox_Server_name.Text = "DESKTOP-06T59HG\\SQLEXPRESS";
            this.textBox_Server_name.Enter += new System.EventHandler(this.textBox_Server_name_Enter);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(133, 265);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(132, 43);
            this.button_Connect.TabIndex = 7;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(57, 191);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(56, 13);
            this.label_password.TabIndex = 13;
            this.label_password.Text = "Password:";
            // 
            // textBox_password
            // 
            this.textBox_password.Enabled = false;
            this.textBox_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_password.Location = new System.Drawing.Point(60, 207);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(188, 20);
            this.textBox_password.TabIndex = 12;
            this.textBox_password.Enter += new System.EventHandler(this.textBox_password_Enter);
            // 
            // checkBox_login
            // 
            this.checkBox_login.AutoSize = true;
            this.checkBox_login.Location = new System.Drawing.Point(268, 160);
            this.checkBox_login.Name = "checkBox_login";
            this.checkBox_login.Size = new System.Drawing.Size(15, 14);
            this.checkBox_login.TabIndex = 14;
            this.checkBox_login.UseVisualStyleBackColor = true;
            this.checkBox_login.CheckedChanged += new System.EventHandler(this.checkBox_login_CheckedChanged);
            // 
            // checkBox_password
            // 
            this.checkBox_password.AutoSize = true;
            this.checkBox_password.Enabled = false;
            this.checkBox_password.Location = new System.Drawing.Point(268, 210);
            this.checkBox_password.Name = "checkBox_password";
            this.checkBox_password.Size = new System.Drawing.Size(15, 14);
            this.checkBox_password.TabIndex = 15;
            this.checkBox_password.UseVisualStyleBackColor = true;
            this.checkBox_password.CheckedChanged += new System.EventHandler(this.checkBox_password_CheckedChanged);
            // 
            // label_see
            // 
            this.label_see.AutoSize = true;
            this.label_see.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_see.Location = new System.Drawing.Point(289, 210);
            this.label_see.Name = "label_see";
            this.label_see.Size = new System.Drawing.Size(26, 13);
            this.label_see.TabIndex = 16;
            this.label_see.Text = "See";
            // 
            // Form_connect_to_db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 334);
            this.Controls.Add(this.label_see);
            this.Controls.Add(this.checkBox_password);
            this.Controls.Add(this.checkBox_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_login_or_user_name);
            this.Controls.Add(this.textBox_login_or_user_name);
            this.Controls.Add(this.label_Server_name);
            this.Controls.Add(this.textBox_Server_name);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.label_Connect_to_Data_Base);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_connect_to_db";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_connect_to_db";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Connect_to_Data_Base;
        private System.Windows.Forms.Label label_login_or_user_name;
        private System.Windows.Forms.TextBox textBox_login_or_user_name;
        private System.Windows.Forms.Label label_Server_name;
        private System.Windows.Forms.TextBox textBox_Server_name;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.CheckBox checkBox_login;
        private System.Windows.Forms.CheckBox checkBox_password;
        private System.Windows.Forms.Label label_see;
    }
}

