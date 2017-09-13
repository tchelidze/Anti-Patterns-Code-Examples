using System;
using System.Linq;

namespace The.Blob.CaseOne.Problem
{
    /// <summary>
    /// The Blob
    /// class incorporates logic related to other entities
    ///ex: in AddProductToOrder method, it  applies rule "Two Product with the same id should not exists in Order", that logic is part of "Order" object's knowledge. 
    /// </summary>
    public class ApplicationController
    {
        public User User { get; set; }

        public Order Order { get; set; }

        public bool CheckUserPassword(string password) => User.Password == password;

        // ApplicationController applies rules to password that naturally is part of `User`
        public void ChangeUserPassword(string oldPassword, string newPassword)
        {
            var isValidPassword = CheckUserPassword(oldPassword);
            if (!isValidPassword)
                throw new InvalidOperationException("Incorrect old password");
            if (string.IsNullOrEmpty(newPassword))
                throw new InvalidOperationException("Password must not be empty");
            User.Password = newPassword;
        }

        public decimal CalculateProductPrice(Product product)
        {
            //give VIP users 15 percent discount
            if (Order.Owner.Type == UserType.Vip)
                return product.Price / 100 * 85;
            return product.Price;
        }

        public void AddProductToOrder(Product product)
        {
            if (Order.Items.Select(it => it.Product).Any(it => it.Id == product.Id))
                throw new InvalidOperationException("Product is already in order");
            Order.Items.Add(new OrderItem
            {
                Product = product,
                Price = CalculateProductPrice(product),
            });
        }

        public void RemoveProductFromOrder(Product product)
        {
            var correspondingOrderItem = Order.Items.FirstOrDefault(it => it.Product.Id == product.Id);
            if (correspondingOrderItem == null)
                throw new InvalidOperationException("Product is not in order");
            Order.Items.Remove(correspondingOrderItem);
        }

        public decimal CalculateOrderPrice(Order order)
            => order.Items.Sum(it => it.Price);
    }
}