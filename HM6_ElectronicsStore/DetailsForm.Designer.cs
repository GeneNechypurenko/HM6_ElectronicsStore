namespace HM6_ElectronicsStore
{
    partial class DetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            SuspendLayout();
            // 
            // productGridView
            // 
            productGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.Location = new Point(10, 30);
            productGridView.Name = "productGridView";
            productGridView.RowHeadersWidth = 51;
            productGridView.RowTemplate.Height = 29;
            productGridView.Size = new Size(860, 335);
            productGridView.TabIndex = 0;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(882, 395);
            Controls.Add(productGridView);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DetailsForm";
            Text = "Product Details";
            FormClosing += DetailsForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productGridView;
    }
}