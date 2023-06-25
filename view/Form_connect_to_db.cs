using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.controller;
using TestTask.view;

namespace TestTask
{
    public partial class Form_connect_to_db : Form
    {
        Controller controller = new Controller();
        public Form_connect_to_db()
        {
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            Form_main form_main = new Form_main();
            if (textBox_login_or_user_name.Enabled == false)
            {
                controller.ConnectToDB(textBox_Server_name.Text, "", "", form_main, this);
            }
            else
            {
                controller.ConnectToDB(textBox_Server_name.Text, textBox_login_or_user_name.Text, textBox_password.Text, form_main, this);
            }
        }

        private void textBox_login_or_user_name_Enter(object sender, EventArgs e)
        {
            textBox_login_or_user_name.Text = "";
            textBox_login_or_user_name.ForeColor = Color.Black;
        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
             checkBox_password.Checked = false;
            textBox_login_or_user_name.ForeColor = Color.Black;
        }

        private void checkBox_login_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_login.Checked == true)
            {
                textBox_login_or_user_name.Enabled = true;
                textBox_password.Enabled = true;
                checkBox_password.Enabled = true;
                label_see.ForeColor = Color.Black;
            }
            else
            {
                textBox_login_or_user_name.Enabled = false;
                textBox_password.Enabled = false;
                checkBox_password.Enabled = false;
                label_see.ForeColor = Color.Gray;
            }
        }

        private void checkBox_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_password.Checked == true)
            {
                textBox_password.PasswordChar = '\0';
            }
            else
            {
                textBox_password.PasswordChar = '*';
            }
        }

        private void textBox_Server_name_Enter(object sender, EventArgs e)
        {
            textBox_Server_name.Text = "";
            textBox_Server_name.ForeColor = Color.Black;
        }
    }
}
