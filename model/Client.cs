using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.model
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name_client { get; set; }
        public string Address { get; set; }

        public Client(int _id, string _name, string _address) 
        { 
            this.Id = _id;
            this.Name_client = _name;
            this.Address = _address;
        }
    }
}
