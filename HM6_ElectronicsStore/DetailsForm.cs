using HM6_ElectronicsStore.Models;

namespace HM6_ElectronicsStore
{
    public partial class DetailsForm : Form
    {
        event EventHandler DetailsFormClosed;
        public DetailsForm(Product[] products)
        {
            Load += (s, e) =>
            {
                productGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                productGridView.DataSource = products;
            };

            InitializeComponent();
        }
        private void DetailsForm_FormClosing(object sender, FormClosingEventArgs e) => DetailsFormClosed?.Invoke(this, e);
    }
}