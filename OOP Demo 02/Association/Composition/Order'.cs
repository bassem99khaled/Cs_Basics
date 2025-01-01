using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_02.Association.Composition
{

    // Association RelationShip[Comosition] : has a
    //                                      : Order Has A Item
    internal class Order
    {
        public int Id { get; set; }
        public  string UserEmail { get; set; }

        public decimal SubTotal { get; set; }

        public List<OrderItem> Items { get; set; }

        public Order(string userEmail, List<OrderItem> items)
        {
            UserEmail = userEmail;
            Items = items;
        }
    }
}
