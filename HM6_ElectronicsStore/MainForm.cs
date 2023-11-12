using HM6_ElectronicsStore.Models;
using System.Collections.ObjectModel;

namespace HM6_ElectronicsStore
{
    public partial class MainForm : Form
    {
        Category[] categories;
        ObservableCollection<Product> products;
        Cart cart;
        public decimal TotalPrice { get; set; }
        public MainForm()
        {
            InitializeComponent();

            categories = Data.InitializeCategories();
            products = Data.InitializeProducts(categories);

            cart = new();

            productListBox.SelectionMode = SelectionMode.MultiExtended;

            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";

            UpdatePriceLabel();

            InitializeProductListBox();

            categoryComboBox.SelectedIndexChanged += (s, e) => InitializeProductListBox();
        }
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (productListBox.SelectedItems.OfType<Product>().Any(e => e.Quantity > e.InCart))
            {
                TotalPrice += productListBox.SelectedItems
                .OfType<Product>()
                .Sum(e => e.Price);

                UpdatePriceLabel();

                foreach (var product in productListBox.SelectedItems.OfType<Product>())
                {
                    cart.AddToCart(product);
                    product.InCart++;
                }
            }
            else
            {
                MessageBox.Show
                    ($"The Product you selected: \n" +
                    $"\n{productListBox?.SelectedItems?.OfType<Product>()?.FirstOrDefault()?.ToString()}\n" +
                    $"\nis currently out of stock.", "Out Of Stock");
            }
        }
        private void openCartButton_Click(object sender, EventArgs e)
        {
            CustomerCartForm customerCart = new CustomerCartForm(cart);
            customerCart.TotalPrice = this.TotalPrice;
            customerCart.Location = new Point(this.Location.X + 20, this.Location.Y + 130);
            customerCart.FormClosed += (s, e) =>
            {
                TotalPrice = customerCart.TotalPrice;
                UpdatePriceLabel();
            };
            customerCart.ShowDialog(this);
        }
        private void detailsButton_Click(object sender, EventArgs e)
        {
            Product[] selectedProduct = productListBox.SelectedItems.OfType<Product>().ToArray();
            if (selectedProduct is not null)
            {
                DetailsForm detailsForm = new DetailsForm(selectedProduct);
                detailsForm.ShowDialog(this);
                InitializeProductListBox();
            }
        }
        private void InitializeProductListBox() => productListBox.DataSource = products.Where(e => e.Category.Equals(categoryComboBox.SelectedValue)).ToList();
        private void UpdatePriceLabel() => priceLabel.Text = $"TOTAL PRICE:   {TotalPrice:C}";
    }
}