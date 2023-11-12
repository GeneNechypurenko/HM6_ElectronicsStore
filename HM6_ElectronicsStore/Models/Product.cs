namespace HM6_ElectronicsStore.Models
{
    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public int Available { get; set; }
        public int Reserved { get; set; }
        public override string ToString() => $"{Name}, {Price:C}";
    }
}