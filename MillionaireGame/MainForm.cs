namespace MillionaireGame
{
    public partial class MainForm : Form
    {
        QuizForm quizForm;
        public MainForm()
        {
            Load += (s, e) =>
            {
                Width = 530;
                Height = 600;

                InitializeMainMenu();
            };

            InitializeComponent();

            quizForm = new QuizForm();
        }

        private void InitializeMainMenu()
        {
            Label titleLabel = new Label
            {
                Text = "Who Wants to Be a Millionaire",
                Font = new Font(Font.FontFamily, 20, FontStyle.Bold),
                ForeColor = Color.Black,
                Dock = DockStyle.Top,
                AutoSize = true
            };

            Button startButton = new Button
            {
                Text = "Start Game",
                Font = new Font(Font.FontFamily, 16),
                AutoSize = true,
            };

            startButton.Size = new Size(startButton.PreferredSize.Width + 20, startButton.PreferredSize.Height + 10);
            startButton.Location = new Point((Width - startButton.Width) / 2, (Height - startButton.Height) / 2);

            startButton.Click += (sender, e) =>
            {
                if (quizForm == null || quizForm.IsDisposed)
                {
                    quizForm = new QuizForm();
                }
                quizForm.Show(this);
            };

            Controls.Add(titleLabel);
            Controls.Add(startButton);
        }
    }
}