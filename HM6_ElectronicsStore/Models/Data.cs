using System.Collections.ObjectModel;

namespace HM6_ElectronicsStore.Models
{
    public class Data
    {
        public static Category[] InitializeCategories()
        {
            return new[]
            {
                new Category{ Name = "All"},
                new Category{ Name = "Laptops" },
                new Category{ Name = "Smatphones"},
                new Category{ Name = "TV"}
            };
        }
        public static ObservableCollection<Product> InitializeProducts(Category[] categories)
        {
            return new ObservableCollection<Product>()
            {
                new Product { Name = "Lenovo IdeaPad Slim 3 16ABR8", Category = categories[1], Price = 26_999, Available = 21},
                new Product { Name = "Acer Aspire 7 A715-43G-R92H", Category = categories[1], Price = 30_999, Available = 17},
                new Product { Name = "ASUS Vivobook 15 X1500EA-BQ3733", Category = categories[1], Price = 17_499, Available = 37},
                new Product { Name = "Apple MacBook Air 13\" M1 8/256GB 2020", Category = categories[1], Price = 40_999, Available = 17},
                new Product { Name = "ASUS TUF Gaming F15 FX506HF-HN038", Category = categories[1], Price = 32_999, Available = 19},

                new Product { Name = "Apple iPhone 15 128GB", Category = categories[2], Price = 42_499, Available = 29},
                new Product { Name = "Samsung Galaxy S23 8/256GB", Category = categories[2], Price = 35_899, Available = 23},
                new Product { Name = "Samsung Galaxy S22 8/256 GB", Category = categories[2], Price = 24_5999, Available = 39},
                new Product { Name = "Xiaomi 13T 8/256GB", Category = categories[2], Price = 22_999, Available = 33},
                new Product { Name = "Xiaomi Redmi Note 12 Pro 4G 8/256GB", Category = categories[2], Price = 9_999, Available = 42},

                new Product { Name = "Samsung UE43CU7100UXUA", Category = categories[3], Price = 17_499, Available = 22},
                new Product { Name = "Samsung UE50CU7100UXUA", Category = categories[3], Price = 21_499, Available = 13},
                new Product { Name = "LG OLED55C36LC", Category = categories[3], Price = 72_999, Available = 7},
                new Product { Name = "LG 50UR81006LJ", Category = categories[3], Price = 21_999, Available = 21},
                new Product { Name = "Xiaomi TV P1E 65", Category = categories[3], Price = 24_999, Available = 28}
            };
        }
    }
}
