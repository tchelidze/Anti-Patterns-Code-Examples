namespace The.Blob.CaseOne.Solution
{
    public class OrderItem
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public Product Product { get; set; }
    }
}