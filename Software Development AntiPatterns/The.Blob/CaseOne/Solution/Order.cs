using System;
using System.Collections.Generic;
using System.Linq;

namespace The.Blob.CaseOne.Solution
{
    public class Order
    {
        public int Id { get; set; }

        public decimal TotalPrice { get; set; }

        public IList<OrderItem> Items { get; set; }

        public User Owner { get; set; }

        public void AddProduct(Product product)
        {
            if (Items.Select(it => it.Product).Any(it => it.Id == product.Id))
                throw new InvalidOperationException("Product is already in order");
            Items.Add(new OrderItem
            {
                Product = product,
                Price = CalculateProductPrice(product),
            });
        }

        public void RemoveProduct(Problem.Product product)
        {
            var correspondingOrderItem = Items.FirstOrDefault(it => it.Product.Id == product.Id);
            if (correspondingOrderItem == null)
                throw new InvalidOperationException("Product is not in order");
            Items.Remove(correspondingOrderItem);
        }

        public decimal CalculateProductPrice(Product product)
        {
            //give VIP users 15 percent discount
            if (Owner.Type == UserType.Vip)
                return product.Price / 100 * 85;
            return product.Price;
        }
    }
}