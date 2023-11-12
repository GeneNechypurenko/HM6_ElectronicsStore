using System.ComponentModel;

namespace HM6_ElectronicsStore.Models
{
    public class Cart
    {
        BindingList<Product> cart;
        public Cart() => cart = new BindingList<Product>();
        public void AddToCart(Product product) => cart.Add(product);
        public void RemoveFromCart(int index)
        {
            cart.ElementAt(index).Reserved--;
            cart.RemoveAt(index);
        }
        public BindingList<Product> GetCartItems() => cart;
    }
}