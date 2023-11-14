namespace FileEditor
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
            editorTextBox = new TextBox();
            buttonsPanel = new Panel();
            openButton = new Button();
            editButton = new Button();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // editorTextBox
            // 
            editorTextBox.Dock = DockStyle.Fill;
            editorTextBox.Location = new Point(0, 0);
            editorTextBox.Multiline = true;
            editorTextBox.Name = "editorTextBox";
            editorTextBox.Size = new Size(538, 240);
            editorTextBox.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(openButton);
            buttonsPanel.Controls.Add(editButton);
            buttonsPanel.Dock = DockStyle.Right;
            buttonsPanel.Location = new Point(418, 0);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(120, 240);
            buttonsPanel.TabIndex = 1;
            // 
            // openButton
            // 
            openButton.Dock = DockStyle.Top;
            openButton.Location = new Point(0, 0);
            openButton.Name = "openButton";
            openButton.Size = new Size(120, 120);
            openButton.TabIndex = 1;
            openButton.Text = "OPEN FILE";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // editButton
            // 
            editButton.Dock = DockStyle.Bottom;
            editButton.Location = new Point(0, 120);
            editButton.Name = "editButton";
            editButton.Size = new Size(120, 120);
            editButton.TabIndex = 0;
            editButton.Text = "EDIT";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 240);
            Controls.Add(buttonsPanel);
            Controls.Add(editorTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "File Editor";
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox editorTextBox;
        private Panel buttonsPanel;
        private Button editButton;
        private Button openButton;
    }
}