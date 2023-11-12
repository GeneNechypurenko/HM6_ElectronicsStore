using HM6_ElectronicsStore.Models;

namespace HM6_ElectronicsStore
{
    public partial class DetailsForm : Form
    {
        public DetailsForm(Product[] products)
        {
            InitializeComponent();
            productGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productGridView.DataSource = products;
        }
    }
}