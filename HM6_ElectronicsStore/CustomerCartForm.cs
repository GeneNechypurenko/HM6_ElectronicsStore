using HM6_ElectronicsStore.Models;
using System.Text;

namespace HM6_ElectronicsStore
{
    public partial class CustomerCartForm : Form
    {
        public event EventHandler FormClosed;

        private Cart cart;
        public decimal TotalPrice { get; set; }
        public CustomerCartForm(Cart cart)
        {
            this.Load += (s, e) =>
            {
                cartListBox.DataSource = cart.GetCartItems();
                UpdatePriceLabel();
            };

            InitializeComponent();
            this.cart = cart;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.Items.Count > 0)
            {
                TotalPrice -= cartListBox.SelectedItems
                    .OfType<Product>()
                    .Sum(e => e.Price);

                cart.RemoveFromCart(cartListBox.SelectedIndex);

                UpdatePriceLabel();
            }
        }
        private void orderButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.Items.Count > 0)
            {
                StringBuilder order = new StringBuilder();

                foreach (Product product in cart.GetCartItems())
                {
                    order.AppendLine($"Product: {product.Name}, Price: {product.Price:C}");
                    product.Quantity -= product.InCart;
                    product.InCart = 0;
                }

                MessageBox.Show($"Your order details:\n\n{order.ToString()}\nTotal: {TotalPrice:C}", "Order Details");

                cart.GetCartItems().Clear();
                TotalPrice = 0;
                priceLabel.Text = $"TOTAL PRICE:   {TotalPrice:C}";

                this.FormClosed?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }
        private void UpdatePriceLabel() => priceLabel.Text = $"TOTAL PRICE:   {TotalPrice:C}";
    }
}
