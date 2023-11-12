namespace HM6_ElectronicsStore.Models
{
    public struct Category
    {
        public string Name { get; set; }
        public override string ToString() => $"{Name}";
    }
}