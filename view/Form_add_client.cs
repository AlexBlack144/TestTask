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

namespace TestTask.view
{
    public partial class Form_add_client : Form
    {
        Controller controller = new Controller();
        public Form_add_client()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            controller.InsertClient(textBox_client_name.Text, textBox_address.Text);
            this.Close();
        }

        private void textBox_client_name_Enter(object sender, EventArgs e)
        {
            textBox_client_name.Text = "";
            textBox_client_name.ForeColor = Color.Black;
        }

        private void textBox_address_Enter(object sender, EventArgs e)
        {
            textBox_address.Text = "";
            textBox_address.ForeColor = Color.Black;
        }
    }
}
