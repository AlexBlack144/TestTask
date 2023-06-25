using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.model
{
    internal class OrderLinesInnerJoin
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Name_client { get; set; }
        public string Name_product { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double Sum { get; set; }

        public OrderLinesInnerJoin(int _id, string _date, string _name_client, string _name_product, double _price, int _count, double _sum)
        {
            this.Id = _id;
            this.Date = _date;
             this.Name_client = _name_client;
            this.Name_product = _name_product;
            this.Price = _price;
            this.Count = _count;
            this.Sum = _sum;
        }
    }
}
