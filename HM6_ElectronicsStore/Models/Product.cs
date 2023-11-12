namespace HM6_ElectronicsStore.Models
{
    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int InCart { get; set; }
        public override string ToString() => $"{Name}, {Price:C}";
    }
}