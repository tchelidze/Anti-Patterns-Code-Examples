using System.Collections.Generic;

namespace The.Blob.CaseOne.Problem
{
    public class Order
    {
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public IList<OrderItem> Items { get; set; }

        public User Owner { get; set; }
    }
}