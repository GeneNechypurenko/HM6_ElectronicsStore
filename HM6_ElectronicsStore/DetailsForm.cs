using HM6_ElectronicsStore.Models;

namespace HM6_ElectronicsStore
{
    public partial class DetailsForm : Form
    {
        public DetailsForm(Product[] products)
        {
            this.Load += (s, e) =>
            {
                productGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                productGridView.DataSource = products;
            };

            InitializeComponent();
        }
    }
}