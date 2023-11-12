using HM6_ElectronicsStore.Models;
using System.Text;

namespace HM6_ElectronicsStore
{
    public partial class CustomerCartForm : Form
    {
        public event EventHandler CustomerFormClosed;

        private Cart cart;
        public decimal TotalPrice { get; set; }
        public CustomerCartForm(Cart cart)
        {
            Load += (s, e) =>
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

                CustomerFormClosed?.Invoke(this, EventArgs.Empty);

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
                    product.Available -= product.Reserved;
                    product.Reserved = 0;
                }

                MessageBox.Show($"Your order details:\n\n{order.ToString()}\nTotal: {TotalPrice:C}", "Order Details");

                cart.GetCartItems().Clear();
                TotalPrice = 0;
                UpdatePriceLabel();

                CustomerFormClosed?.Invoke(this, EventArgs.Empty);
                Close();
            }
        }
        private void CustomerCartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TotalPrice = 0;
            while (cart.GetCartItems().Count > 0) { cart.RemoveFromCart(cart.GetCartItems().Count - 1); }
            CustomerFormClosed?.Invoke(this, EventArgs.Empty);
        }
        private void UpdatePriceLabel() => priceLabel.Text = $"TOTAL PRICE:   {TotalPrice:C}";
    }
}