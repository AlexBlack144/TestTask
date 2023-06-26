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
    public partial class Form_add_order_lines : Form
    {
        public int id_client;
        Controller controller = new Controller();
        public Form_add_order_lines()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
               
                int id_product = controller.SelectProductById(comboBox_product.SelectedItem.ToString()).Id;
                double price = Convert.ToDouble(textBox_price.Text.Replace(".",","));
                int count = Convert.ToInt32(textBox_count.Text);
                 controller.InsertOrder(id_client, DateTime.Now.ToString());
                int id_order = controller.SelectOrder().Select(x => x.Id).Max();
                controller.InsertOrderLines(id_order, id_product, price, count);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Form_add_order_lines_Load(object sender, EventArgs e)
        {
            comboBox_product.Items.Clear();
            List<string> lines = new List<string>();
            foreach (var line in controller.SelectProduct())
            {
                lines.Add(line.Name_product);
            }
            comboBox_product.Items.AddRange(lines.ToArray());
            comboBox_product.SelectedIndex = 0;
        }

        private void textBox_price_Enter(object sender, EventArgs e)
        {
            textBox_price.Text = "";
            textBox_price.ForeColor = Color.Black;
        }

        private void textBox_count_Enter(object sender, EventArgs e)
        {
            textBox_count.Text = "";
            textBox_count.ForeColor = Color.Black;
        }
    }
}
