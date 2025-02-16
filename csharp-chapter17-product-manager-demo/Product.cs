namespace csharp_chapter17_product_manager_demo
{
    internal class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public Product(string code, string Description, decimal price)
        {
            this.Code = code;
            this.Description = Description;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Product: ({Code}) - {Description} @ {Price:c}";
        }
    }
}
