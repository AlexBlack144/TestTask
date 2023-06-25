using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.model
{
    internal class Order
    {
        public int Id { get; set; }
        public int Client_id { get; set; }
        public string Date { get; set; }

        public Order(int _id, int _client_id, string _date)
        {
            this.Id = _id;
            this.Client_id = _client_id;
            this.Date = _date;
        }
    }
}
