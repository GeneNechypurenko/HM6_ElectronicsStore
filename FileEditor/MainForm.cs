using HM7_TextEditor;

namespace FileEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Load += (s, e) =>
            {
                editorTextBox.ReadOnly = true;
                editorTextBox.WordWrap = true;
                editButton.Enabled = false;
                editorTextBox.ScrollBars = ScrollBars.Vertical;
            };

            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|Word Documents (*.doc)|*.doc|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = ofd.FileName;
                string content = File.ReadAllText(selectedFilePath);
                editorTextBox.Text = content;
                editButton.Enabled = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            TextEditorForm editorForm = new TextEditorForm();
            editorForm.Show();
            editorForm.EditorTextBox.Text = editorTextBox.Text;
        }
    }
}