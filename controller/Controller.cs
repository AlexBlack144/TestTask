using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTask.model;
using TestTask.model.Singleton;
using TestTask.view;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestTask.controller
{
    internal class Controller
    {
        Singleton singleton = new Singleton();

        public void ConnectToDB (string server_name, string login, string password, Form_main form_main, Form_connect_to_db form_Connect_To_Db)
        {
            singleton._server_name = server_name;
            singleton._user_name = login;
            singleton._password = password;
            try
            {
                string commStr = "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'db_work_test') BEGIN  CREATE DATABASE db_work_test END";
                using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Connection done!");
                }
                singleton.GetInstance().Close();
                CreateTables();
                form_Connect_To_Db.Hide();
                form_main.ShowDialog();
               
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Cannot conected to DB");
                singleton._connState = "bad";
            }
           
        }
        public void CreateTables() 
        {
            try
            {
                string commStr = "IF NOT EXISTS(SELECT TABLE_NAME FROM db_work_test.INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Client')\r\n" +
                    "BEGIN \r\n" +
                        "CREATE TABLE [db_work_test].[dbo].[Client]\r\n" +
                        "(\r\n\t" +
                            "[Id] INT IDENTITY PRIMARY KEY,\r\n\t" +
                            "[Name_client] NVARCHAR(35) NOT NULL,\r\n\t" +
                            "[Address] NVARCHAR(MAX) NOT NULL,\r\n" +
                        ");\r\n" +
                        "CREATE TABLE [db_work_test].[dbo].[Product]\r\n" +
                        "(\r\n\t" +
                            "[Id] INT IDENTITY PRIMARY KEY,\r\n\t" +
                            "[Name_product] NVARCHAR(35) NOT NULL,\r\n" +
                        ");\r\n" +
                        "CREATE TABLE [db_work_test].[dbo].[Order]\r\n" +
                        "(\r\n\t" +
                            "[Id] INT IDENTITY PRIMARY KEY,\r\n\t" +
                            "[Client_id] INT FOREIGN KEY REFERENCES [db_work_test].[dbo].Client([Id]) NOT NULL,\r\n\t" +
                            "[Date] NVARCHAR(MAX) NOT NULL,\r\n" +
                        ");\r\n" +
                        "CREATE TABLE [db_work_test].[dbo].[OrderLines]\r\n" +
                        "(\r\n\t" +
                            "[Id] INT IDENTITY PRIMARY KEY,\r\n\t" +
                            "[Order_id] INT FOREIGN KEY REFERENCES [db_work_test].[dbo].[Order]([Id]) NOT NULL,\r\n\t" +
                            "[Product_id] INT FOREIGN KEY REFERENCES [db_work_test].[dbo].Product([Id]) NOT NULL,\r\n\t" +
                            "[Price] FLOAT NOT NULL,\r\n\t" +
                            "[Count] INT NOT NULL, \r\n\t" +
                            "[Sum] FLOAT NOT NULL,\r\n" +
                        ");\r\n" +
                    "END";

                using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Tables created!");
                }
                singleton.GetInstance().Close();
            }
            catch { MessageBox.Show("Cannot created tables"); }
        }

        public void InsertClient(string name, string address) 
        {
            try
            {
                bool isNumberName = double.TryParse(name, out double numericValue);
                bool isNumberAddress = double.TryParse(address, out double numericValue2);
                if (name.ToLower().Contains("insert") ||
                    name.ToLower().Contains("drop") ||
                    name.ToLower().Contains("delete") ||
                    name.ToLower().Contains("update") ||
                    name.ToLower().Contains("select")|| isNumberName)
                {
                    MessageBox.Show("Not correct client name!");
                }
                else if (address.ToLower().Contains("insert") ||
                    address.ToLower().Contains("drop") ||
                    address.ToLower().Contains("delete") ||
                    address.ToLower().Contains("update") ||
                    address.ToLower().Contains("select") || isNumberAddress)
                {
                    MessageBox.Show("Not correct address!");
                }
                else
                {
                    string commStr = $"INSERT INTO [db_work_test].[dbo].[Client] ([Name_client], [Address]) VALUES('{name}','{address}');";
                    using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Inserted in table 'Client'!");
                        }

                        else
                        {
                            MessageBox.Show("Not inserted!");
                        }
                    }
                    singleton.GetInstance().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertProduct(string name)
        {
            try { 
                string commStr = $"INSERT INTO [db_work_test].[dbo].[Product] ([Name_product]) VALUES('{name}');";
                using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Inserted in table 'Product'!");
                    }

                    else
                    {
                        MessageBox.Show("Not inserted!");
                    }
                }
                singleton.GetInstance().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        public void InsertOrder(int client_id, string date)
        {
            try 
            {
                string commStr = $"INSERT INTO [db_work_test].[dbo].[Order] ([Client_id], [Date]) VALUES({client_id}, '{date}');";
                using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Inserted in table 'Order'!");
                    }

                    else
                    {
                        MessageBox.Show("Not inserted!");
                    }
                }
                singleton.GetInstance().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void InsertOrderLines(int order_id, int product_id, double price, int count)
        {
            try 
            {
                double sum = count * price;
                string commStr = $"INSERT INTO [db_work_test].[dbo].[OrderLines] ([Order_id], [Product_id],[Price],[Count],[Sum]) VALUES({order_id}, {product_id},@price,{count},@sum);";
                using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                {
                    command.Parameters.Add("@price", SqlDbType.Float).Value = Math.Round((float)price,2);
                    command.Parameters.Add("@sum", SqlDbType.Float).Value = Math.Round((float)sum,2);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Inserted in table 'OrderLines'!");
                    }

                    else
                    {
                        MessageBox.Show("Not inserted!");
                    }
                }
                singleton.GetInstance().Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void InsertTestData()
        {
            DateTime localDate = DateTime.Now;

            InsertClient("Alex", "Dnipro str Bazova 22");
            InsertClient("Kirill", "Dnipro str Kalinova 10");
            InsertClient("Ruslan", "Kiev str Test 12");
            InsertClient("Oleg", "Odessa str Test 24");


            InsertProduct("iPhone 12 PRO MAX");
            InsertProduct("Samsung Galaxy 11");
            InsertProduct("Redmi note 9 pro");
            InsertProduct("Nokia 5");

            InsertOrder(1, localDate.ToString());
            InsertOrder(1, localDate.ToString());
            InsertOrder(2, localDate.ToString());
            InsertOrder(4, localDate.ToString());

            InsertOrderLines(1, 1, 12000, 1);
            InsertOrderLines(2, 3, 5000, 2);
            InsertOrderLines(3, 2, 8000, 1);
            InsertOrderLines(4, 4, 200, 5);

        }

        public void UpdateClient(int id,string name_client, string address, DataGridView dataGridView)
        {
            try
            {
                if (name_client.ToLower().Contains("insert") ||
                    name_client.ToLower().Contains("drop") ||
                    name_client.ToLower().Contains("delete") ||
                    name_client.ToLower().Contains("update") ||
                    name_client.ToLower().Contains("select"))
                {
                    MessageBox.Show("Not correct client name!");
                }
                else if(address.ToLower().Contains("insert") ||
                    address.ToLower().Contains("drop") ||
                    address.ToLower().Contains("delete") ||
                    address.ToLower().Contains("update") ||
                    address.ToLower().Contains("select")) 
                {
                    MessageBox.Show("Not correct address!");
                }
                else
                {
                    string commStr = $"UPDATE [db_work_test].[dbo].[Client] SET [Name_client] = '{name_client}', [Address] = '{address}' WHERE  [db_work_test].[dbo].[Client].[Id] = {id};";
                    using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                    {
                        if (command.ExecuteNonQuery() > 0)
                            MessageBox.Show("Измененно!", "Сообщение", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("Not update in DB!");
                    }
                    singleton.GetInstance().Close();
                    ShowMainTable(dataGridView);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateOrderLines(int id, int id_product, double price, int count ,DataGridView dataGridView, int id_client) 
        {
            try
            {
                double sum = price * count;
                string commStr = $"UPDATE [db_work_test].[dbo].[OrderLines] SET [Product_id] = {id_product}, [Price] = @price, [Count] = {count}, [Sum] = @sum WHERE  [db_work_test].[dbo].[OrderLines].[Id] = {id};";
                using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                {
                    command.Parameters.Add("@price", SqlDbType.Float).Value = Math.Round((float)price,2);
                    command.Parameters.Add("@sum", SqlDbType.Float).Value = Math.Round((float)sum,2);
                    if (command.ExecuteNonQuery() > 0)
                        MessageBox.Show("Измененно!", "Сообщение", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Not update in DB!");
                }
                singleton.GetInstance().Close();
                ShowMoreTable(dataGridView, id_client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteOrderLines(int id_order, int id_client, DataGridView dataGridView)
        {
            try
            {
                string commStr = $"DELETE FROM [db_work_test].[dbo].[OrderLines] WHERE  [db_work_test].[dbo].[OrderLines].[Id] = {id_order};";
                using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                {
                    if (command.ExecuteNonQuery() > 0)
                        MessageBox.Show("Deleted in OrderLines!");
                    else
                        MessageBox.Show("Not deleted in DB!");
                }
                singleton.GetInstance().Close();

                commStr = $"DELETE FROM [db_work_test].[dbo].[Order] WHERE  [db_work_test].[dbo].[Order].[Id] = {id_order};";
                using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                {
                    if (command.ExecuteNonQuery() > 0)
                        MessageBox.Show("Deleted in Order!");
                    else
                        MessageBox.Show("Not deleted in DB!");
                }
                singleton.GetInstance().Close();
                ShowMoreTable(dataGridView, id_client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteClient(int id, DataGridView dataGridView) 
        {
            try
            {
                string commStr = $"DELETE FROM [db_work_test].[dbo].[Client] WHERE  [db_work_test].[dbo].[Client].[Id] = {id};";
                using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
                {
                    if (command.ExecuteNonQuery() > 0)
                        MessageBox.Show("Deleted!");
                    else
                        MessageBox.Show("Not deleted in DB!");
                }
                singleton.GetInstance().Close();
                ShowMainTable(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        public List<Client> SelectClient()
        {
            List<Client> clients = new List<Client>();
            string commStr = "SELECT * FROM [db_work_test].[dbo].[Client]";
            using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance())) 
            {

                SqlDataReader sqlData = command.ExecuteReader();
                while (sqlData.Read())
                {
                    clients.Add(new Client((int)sqlData["Id"], (string)sqlData["Name_client"], (string)sqlData["Address"]));
                }
                singleton.GetInstance().Close();
                return clients;
            }
        }
        public List<Product> SelectProduct()
        {
            List<Product> products = new List<Product>();
            string commStr = "SELECT * FROM [db_work_test].[dbo].[Product]";
            using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
            {

                SqlDataReader sqlData = command.ExecuteReader();
                while (sqlData.Read())
                {
                    products.Add(new Product((int)sqlData["Id"], (string)sqlData["Name_product"]));
                }
                singleton.GetInstance().Close();
                return products;
            }
        }
        public List<Order> SelectOrder() 
        {
            List<Order> orders = new List<Order>();
            string commStr = "SELECT * FROM [db_work_test].[dbo].[Order]";
            using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
            {

                SqlDataReader sqlData = command.ExecuteReader();
                while (sqlData.Read())
                {
                    orders.Add(new Order((int)sqlData["Id"], (int)sqlData["Client_id"], (string)sqlData["Date"]));
                }
                singleton.GetInstance().Close();
                return orders;
            }
        }
        public Product SelectProductById(string name_product)
        {
            Product products = new Product(0,"");
            string commStr = $"SELECT * FROM [db_work_test].[dbo].[Product] WHERE [db_work_test].[dbo].[Product].[Name_product] = '{name_product}'";
            using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
            {

                SqlDataReader sqlData = command.ExecuteReader();
                while (sqlData.Read())
                {
                    products.Id = (int)sqlData["Id"];
                    products.Name_product = (string)sqlData["Name_product"];
                }
                singleton.GetInstance().Close();
                return products;
            }
        }
        public List<OrderLinesInnerJoin> SelectOrderLinesInnerJoin(int client_id)
        {
            List<OrderLinesInnerJoin> orderLines = new List<OrderLinesInnerJoin>();
            string commStr = "SELECT " +
                "[db_work_test].[dbo].[Order].Id, " +
                "[db_work_test].[dbo].[Order].[Date], " +
                "[db_work_test].[dbo].[Client].[Name_client], " +
                "[db_work_test].[dbo].[Product].[Name_product], " +
                "[db_work_test].[dbo].[OrderLines].[Price],  " +
                "[db_work_test].[dbo].[OrderLines].[Count], " +
                "[db_work_test].[dbo].[OrderLines].[Sum]\r\n" +
                "FROM [db_work_test].[dbo].[OrderLines] \r\n" +
                "INNER JOIN [db_work_test].[dbo].[Product] ON [db_work_test].[dbo].[OrderLines].Product_id = [db_work_test].[dbo].[Product].Id\r\n" +
                "INNER JOIN [db_work_test].[dbo].[Order] ON [db_work_test].[dbo].[OrderLines].Order_id = [db_work_test].[dbo].[Order].Id\r\n" +
                "INNER JOIN [db_work_test].[dbo].[Client] ON [db_work_test].[dbo].[Client].Id = [db_work_test].[dbo].[Order].Client_id\r\n" +
                $"WHERE [db_work_test].[dbo].[Client].[Id] = {client_id}";
            using (SqlCommand command = new SqlCommand(commStr, singleton.GetInstance()))
            {

                SqlDataReader sqlData = command.ExecuteReader();
                while (sqlData.Read())
                {
                    orderLines.Add(new OrderLinesInnerJoin(
                        (int)sqlData["Id"], 
                        (string)sqlData["Date"], 
                        (string)sqlData["Name_client"], 
                        (string)sqlData["Name_product"], 
                        (double)sqlData["Price"],
                        (int)sqlData["Count"],
                        (double)sqlData["Sum"]
                        ));
                }
                singleton.GetInstance().Close();
                return orderLines;
            }

        }

        public void ShowMainTable(DataGridView dataGridView_main)
        {
            try {
                if (SelectProduct().Count == 0)
                {
                    InsertTestData();
                }
                DataTable dt = new DataTable();
                dt.Columns.Add("Код клиента");
                dt.Columns.Add("Наименование клиента");
                dt.Columns.Add("Адресс");
                dt.Columns.Add("Общая сумма по заказам");
                dt.Columns.Add("Удалить");
                dt.Columns.Add("Изменить");

                foreach (var item in SelectClient())
                {
                    DataRow row = dt.NewRow();
                    double sum = 0;
                    row["Код клиента"] = item.Id;
                    row["Наименование клиента"] = item.Name_client;
                    row["Адресс"] = item.Address;
                    foreach (var item2 in SelectOrderLinesInnerJoin(item.Id))
                    {
                        sum += item2.Sum;
                    }
                    row["Общая сумма по заказам"] = sum;
                    row["Удалить"] = "Удалить";
                    row["Изменить"] = "Изменить";
                    dt.Rows.Add(row);
                }
                dataGridView_main.DataSource = dt;
                for (int i = 0; i < dataGridView_main.Rows.Count; i++)
                {
                    DataGridViewButtonCell delete = new DataGridViewButtonCell();
                    DataGridViewButtonCell update = new DataGridViewButtonCell();
                    dataGridView_main[4, i] = delete;
                    dataGridView_main[5, i] = update;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ShowMoreTable(DataGridView dataGridView_more, int client_id)
        {
            try
            {
                dataGridView_more.Rows.Clear();
 
                for (int i = 0; i < SelectOrderLinesInnerJoin(client_id).Count; i++)
                {
                    dataGridView_more.Rows.Add();
                    dataGridView_more.Rows[i].Cells[0].Value = SelectOrderLinesInnerJoin(client_id)[i].Id;
                    dataGridView_more.Rows[i].Cells[1].Value = SelectOrderLinesInnerJoin(client_id)[i].Date;
                    DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();

                    List<string> product_name = new List<string>();
                    foreach (var item in SelectProduct()) 
                    {
                        product_name.Add(item.Name_product);
                    }
                    comboBoxCell.Items.AddRange(product_name.ToArray());
                    dataGridView_more[2, i] = comboBoxCell;
                    dataGridView_more.Rows[i].Cells[2].Value = SelectOrderLinesInnerJoin(client_id)[i].Name_product;

                    dataGridView_more.Rows[i].Cells[3].Value = SelectOrderLinesInnerJoin(client_id)[i].Price;
                    dataGridView_more.Rows[i].Cells[4].Value = SelectOrderLinesInnerJoin(client_id)[i].Count;
                    dataGridView_more.Rows[i].Cells[5].Value = SelectOrderLinesInnerJoin(client_id)[i].Sum;
                    dataGridView_more.Rows[i].Cells[6].Value = "Удалить";
                    dataGridView_more.Rows[i].Cells[7].Value = "Изминить";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
