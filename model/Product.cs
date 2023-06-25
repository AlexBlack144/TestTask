using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.model
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name_product { get; set; }


        public Product(int _id, string _name)
        {
            this.Id = _id;
            this.Name_product = _name;
        }
    }
}
