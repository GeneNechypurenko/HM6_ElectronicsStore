namespace HM6_ElectronicsStore
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productListBox = new ListBox();
            categoryComboBox = new ComboBox();
            label1 = new Label();
            addToCartButton = new Button();
            detailsButton = new Button();
            openCartButton = new Button();
            priceLabel = new Label();
            SuspendLayout();
            // 
            // productListBox
            // 
            productListBox.BackColor = Color.Ivory;
            productListBox.BorderStyle = BorderStyle.FixedSingle;
            productListBox.FormattingEnabled = true;
            productListBox.ItemHeight = 20;
            productListBox.Location = new Point(12, 88);
            productListBox.Name = "productListBox";
            productListBox.Size = new Size(445, 442);
            productListBox.TabIndex = 0;
            // 
            // categoryComboBox
            // 
            categoryComboBox.BackColor = Color.Ivory;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 40);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(445, 28);
            categoryComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 2;
            label1.Text = "Select Category";
            // 
            // addToCartButton
            // 
            addToCartButton.FlatStyle = FlatStyle.Popup;
            addToCartButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addToCartButton.ForeColor = Color.Ivory;
            addToCartButton.Location = new Point(282, 594);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(175, 60);
            addToCartButton.TabIndex = 3;
            addToCartButton.Text = "ADD TO CART";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // detailsButton
            // 
            detailsButton.FlatStyle = FlatStyle.Popup;
            detailsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            detailsButton.ForeColor = Color.Ivory;
            detailsButton.Location = new Point(176, 594);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(100, 60);
            detailsButton.TabIndex = 4;
            detailsButton.Text = "DETAILS";
            detailsButton.UseVisualStyleBackColor = true;
            detailsButton.Click += detailsButton_Click;
            // 
            // openCartButton
            // 
            openCartButton.BackColor = Color.SteelBlue;
            openCartButton.FlatStyle = FlatStyle.Popup;
            openCartButton.Font = new Font("Segoe UI Black", 40.2F, FontStyle.Bold, GraphicsUnit.Point);
            openCartButton.ForeColor = Color.Ivory;
            openCartButton.Location = new Point(12, 555);
            openCartButton.Name = "openCartButton";
            openCartButton.RightToLeft = RightToLeft.No;
            openCartButton.Size = new Size(137, 100);
            openCartButton.TabIndex = 5;
            openCartButton.Text = "\U0001f6d2";
            openCartButton.UseVisualStyleBackColor = false;
            openCartButton.Click += openCartButton_Click;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.ForeColor = Color.PaleGoldenrod;
            priceLabel.Location = new Point(176, 555);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(107, 20);
            priceLabel.TabIndex = 6;
            priceLabel.Text = "TOTAL PRICE: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(469, 680);
            Controls.Add(priceLabel);
            Controls.Add(openCartButton);
            Controls.Add(detailsButton);
            Controls.Add(addToCartButton);
            Controls.Add(label1);
            Controls.Add(categoryComboBox);
            Controls.Add(productListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox productListBox;
        private ComboBox categoryComboBox;
        private Label label1;
        private Button addToCartButton;
        private Button detailsButton;
        private Button openCartButton;
        private Label priceLabel;
    }
}