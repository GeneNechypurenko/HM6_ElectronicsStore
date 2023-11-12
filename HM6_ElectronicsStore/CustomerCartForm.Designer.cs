namespace HM6_ElectronicsStore
{
    partial class CustomerCartForm
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
            priceLabel = new Label();
            cartListBox = new ListBox();
            removeButton = new Button();
            orderButton = new Button();
            SuspendLayout();
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.ForeColor = Color.LightGoldenrodYellow;
            priceLabel.Location = new Point(15, 15);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(107, 20);
            priceLabel.TabIndex = 0;
            priceLabel.Text = "TOTAL PRICE: ";
            // 
            // cartListBox
            // 
            cartListBox.BackColor = Color.Ivory;
            cartListBox.BorderStyle = BorderStyle.FixedSingle;
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 20;
            cartListBox.Location = new Point(10, 45);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(405, 262);
            cartListBox.TabIndex = 1;
            // 
            // removeButton
            // 
            removeButton.FlatStyle = FlatStyle.Popup;
            removeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeButton.ForeColor = Color.FromArgb(255, 128, 128);
            removeButton.Location = new Point(10, 320);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(200, 60);
            removeButton.TabIndex = 2;
            removeButton.Text = "REMOVE";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // orderButton
            // 
            orderButton.FlatStyle = FlatStyle.Popup;
            orderButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderButton.ForeColor = Color.Chartreuse;
            orderButton.Location = new Point(216, 320);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(200, 60);
            orderButton.TabIndex = 4;
            orderButton.Text = "ORDER";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // CustomerCartForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(427, 395);
            Controls.Add(orderButton);
            Controls.Add(removeButton);
            Controls.Add(cartListBox);
            Controls.Add(priceLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomerCartForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Your Cart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label priceLabel;
        private ListBox cartListBox;
        private Button removeButton;
        private Button orderButton;
    }
}