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
    public partial class Form_main : Form
    {
        Controller controller = new Controller();
        public int id_client;

        public Form_main()
        {
            InitializeComponent();
            dataGridView_more.DataError += null;
        }

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form_add_client form_Add_Client = new Form_add_client();
            form_Add_Client.ShowDialog();

            controller.ShowMainTable(dataGridView_main);

        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            controller.ShowMainTable(dataGridView_main);
            this.dataGridView_main.Columns["Удалить"].ReadOnly = false;
        }

        private void dataGridView_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView_main.Columns[0].ReadOnly = true;
                dataGridView_main.Columns[3].ReadOnly = true;
                if (dataGridView_main.Columns[e.ColumnIndex].Name == "Удалить")
                {
                    if (MessageBox.Show("Уверен,что хочешь удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string str_id = dataGridView_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int id = Convert.ToInt32(str_id);
                        controller.DeleteClient(id, dataGridView_main);
                    }
                }
                else if (dataGridView_main.Columns[e.ColumnIndex].Name == "Изменить")
                {
                    string str_id = dataGridView_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string str_name_client = dataGridView_main.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string str_address = dataGridView_main.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int id = Convert.ToInt32(str_id);
                    controller.UpdateClient(id, str_name_client, str_address, dataGridView_main);
                   
                }
                
            }
            catch
            {
                controller.ShowMainTable(dataGridView_main);
            }
           
        }

        private void dataGridView_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_main.Columns[e.ColumnIndex].Name == "Общая сумма по заказам")
            {
                MessageBox.Show("Чтобы изминить сумму заказов выберете 'Код клиента' и двойным щелчком на него, откроется вкладка 'Подробнее' и там вы сможете изменить");
            }
            else if (dataGridView_main.Columns[e.ColumnIndex].Name == "Код клиента")
            {
                string str_id = dataGridView_main.Rows[e.RowIndex].Cells[0].Value.ToString();
                id_client = Convert.ToInt32(str_id);
                tabControl1.SelectedTab = tabPage_more;
                controller.ShowMoreTable(dataGridView_more, id_client);
            }
        }

        private void button_add2_Click(object sender, EventArgs e)
        {
            Form_add_order_lines form_Add_Order = new Form_add_order_lines();
            form_Add_Order.id_client = id_client;
            form_Add_Order.ShowDialog();
            controller.ShowMoreTable(dataGridView_more, id_client);
        }

        private void dataGridView_more_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView_more.Columns[e.ColumnIndex].Name == "Delete")
                {
                    if (MessageBox.Show("Уверен,что хочешь удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string str_id = dataGridView_more.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int id_order = Convert.ToInt32(str_id);
                        controller.DeleteOrderLines(id_order, id_client, dataGridView_more);
                    }
                }
                else if (dataGridView_more.Columns[e.ColumnIndex].Name == "Update")
                {
                    string str_id = dataGridView_more.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int id = Convert.ToInt32(str_id);
                    
                    int id_product = controller.SelectProductById(dataGridView_more.Rows[e.RowIndex].Cells[2].Value.ToString()).Id;
                    double price_full = Convert.ToDouble(dataGridView_more.Rows[e.RowIndex].Cells[3].Value.ToString());
                    double price = Math.Round(price_full, 2);
                    if(price<0){ price = price * -1; }
                    int count = Convert.ToInt32(dataGridView_more.Rows[e.RowIndex].Cells[4].Value.ToString());
                    if (count < 0) { count = count * -1; }
                    controller.UpdateOrderLines(id, id_product, price, count, dataGridView_more, id_client);

                }
            }
            catch
            {
                MessageBox.Show("Not corect!");
            }
        }

        private void dataGridView_more_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_more.Columns[e.ColumnIndex].Name == "Date")
            {
                MessageBox.Show("Дату заказа менять нельзя, можете сделать новый заказ или удалить старый");
            }
            else if (dataGridView_more.Columns[e.ColumnIndex].Name == "Sum")
            {
                MessageBox.Show("'Общая сумма' меняeтся только за счёт 'Количество' и 'Цена $'");
            }
        }

        private void dataGridView_more_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try 
            {
                if (e.ColumnIndex == 5 && e.RowIndex != this.dataGridView_more.NewRowIndex)
                {
                    if (dataGridView_more.Rows[e.RowIndex].Cells[5].Value != null)
                    {
                        float val3 = float.Parse(e.Value.ToString());
                        e.Value = val3.ToString("N2");
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Not corect!");
                controller.ShowMoreTable(dataGridView_more, id_client);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            controller.ShowMoreTable(dataGridView_more, id_client);
        }

        private void button_update1_Click(object sender, EventArgs e)
        {
            controller.ShowMainTable(dataGridView_main);
        }

        private void dataGridView_main_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != this.dataGridView_main.NewRowIndex)
            {
                if (dataGridView_main.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    float val3 = float.Parse(e.Value.ToString());
                    e.Value = val3.ToString("N2");
                }
            }
        }
    }
}
