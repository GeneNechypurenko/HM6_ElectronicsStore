using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace MillionaireGame
{
    public partial class QuizForm : Form
    {
        private List<Question> questions;

        private int currentQuestionIndex = 0;
        private decimal currentMoney = 0;
        private int remainingTime = 15;

        private Timer answerTimer;
        private Label timeLabel;

        private Button[] answerButtons;

        private Button fiftyFiftyButton;
        private bool fiftyFiftyButtonCondition = true;

        private Button callFriendButton;
        private bool callFriendButtonCondition = true;
        public QuizForm()
        {
            Load += (s, e) =>
            {
                Width = Owner.Width;
                Height = Owner.Height;
                Location = new Point(Owner.Location.X, Owner.Location.Y);

                ShowQuestion();
            };

            InitializeComponent();

            currentMoney = 0;
            currentQuestionIndex = 0;

            questions = new List<Question>
            {
                new Question("What is the capital of France?", new List<string> {"London", "Berlin", "Paris", "Madrid"}, 2),
                new Question("Which planet is known as the Red Planet?", new List<string> {"Venus", "Mars", "Jupiter", "Saturn"}, 1),
                new Question("What river is often associated with Egypt?", new List<string> {"Nile", "Amazon", "Danube", "Yangtze"}, 0),
                new Question("Who wrote 'Romeo and Juliet'?", new List<string> {"Charles Dickens", "William Shakespeare", "Jane Austen", "Leo Tolstoy"}, 1),
                new Question("What is the chemical symbol for gold?", new List<string> {"Ag", "Au", "Al", "Fe"}, 1),
                new Question("In which year did the Great French Revolution take place?", new List<string> {"1789", "1812", "1848", "1765"}, 0),
                new Question("Who is the author of the 'Harry Potter' book series?", new List<string> {"George R.R. Martin", "Stephen King", "J.R.R. Tolkien", "J.K. Rowling", }, 3),
                new Question("What animal is a symbol of Australia?", new List<string> {"Kangaroo", "Koala", "Emu", "Crocodile"}, 0),
                new Question("Who is depicted in the painting 'Mona Lisa'?", new List<string> {"Leonardo da Vinci", "Michelangelo", "Raphael", "Vincent van Gogh"}, 0),
                new Question("Which scientist developed the theory of general relativity?", new List<string> {"Isaac Newton", "Niels Bohr", "Albert Einstein", "Galileo Galilei" }, 2),
            };
        }
        private void ShowQuestion()
        {
            ClearForm();

            Question currentQuestion = questions[currentQuestionIndex];
            int topLocation = 60;

            answerTimer = new Timer { Interval = 1000 };
            answerTimer.Start();
            answerTimer.Tick += AnswerTimer_Tick;

            AddTimeLabel();
            AddQuestionLabel(currentQuestion);
            AddAnswerButtons(currentQuestion, ref topLocation);
            AddHints(ref topLocation);
            AddGameConditionLabels(topLocation);
        }

        private void ClearForm()
        {
            foreach (Control item in Controls)
            {
                item.Dispose();
            }
            Controls.Clear();
        }

        private void AddGameConditionLabels(int topLocation)
        {
            Label moneyLabel = new Label
            {
                Text = $"money won: {currentMoney:C}",
                Font = new(Font.FontFamily, 12),
                Location = new Point(10, topLocation + 80),
                AutoSize = true
            };
            Controls.Add(moneyLabel);

            Label currentQuestionLabel = new Label
            {
                Text = $"current question: {currentQuestionIndex + 1}",
                Font = new(Font.FontFamily, 12),
                Location = new Point(10, topLocation + 110),
                AutoSize = true
            };
            Controls.Add(currentQuestionLabel);
        }

        private void AddHints(ref int topLocation)
        {
            topLocation += 30;

            Label hintsLabel = new Label
            {
                Text = "AVAILABLE HINTS:",
                Font = new Font(Font.FontFamily, 16, FontStyle.Bold),
                Location = new Point(10, topLocation),
                AutoSize = true
            };
            Controls.Add(hintsLabel);

            fiftyFiftyButton = new Button
            {
                Text = "50/50",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(Width / 2 + 20, topLocation),
                AutoSize = true,
            };
            fiftyFiftyButton.Enabled = fiftyFiftyButtonCondition ? true : false;
            fiftyFiftyButton.Click += FiftyFiftyButton_Click;
            Controls.Add(fiftyFiftyButton);

            callFriendButton = new Button
            {
                Text = "Call a Friend",
                Font = new Font(Font.FontFamily, 12),
                Location = new Point(Width / 2 + fiftyFiftyButton.Width + 25, topLocation),
                AutoSize = true
            };
            callFriendButton.Enabled = callFriendButtonCondition ? true : false;
            callFriendButton.Click += CallFriendButton_Click;
            Controls.Add(callFriendButton);
        }

        private void AddAnswerButtons(Question currentQuestion, ref int topLocation)
        {
            answerButtons = new Button[4];

            for (int i = 0; i < currentQuestion.Answers.Count; i++)
            {
                answerButtons[i] = new Button
                {
                    Text = currentQuestion.Answers[i],
                    Font = new Font(Font.FontFamily, 16),
                    Location = new Point(10, topLocation),
                    Size = new Size(490, 60),
                    Tag = i
                };
                answerButtons[i].Click += AnswerButton_Click;
                Controls.Add(answerButtons[i]);

                topLocation += answerButtons[i].Height;
            }
        }

        private void AddQuestionLabel(Question currentQuestion)
        {
            Label questionLabel = new Label
            {
                Text = currentQuestion.Text,
                Font = new Font(Font.FontFamily, 20, FontStyle.Bold),
                Dock = DockStyle.Top,
                AutoSize = true
            };
            while (questionLabel.PreferredSize.Width > Width)
            {
                questionLabel.Font = new Font(Font.FontFamily, questionLabel.Font.Size - 1, FontStyle.Bold);
            }
            Controls.Add(questionLabel);
        }

        private void AddTimeLabel()
        {
            timeLabel = new Label
            {
                Text = "Time Left: 15 seconds",
                Font = new Font(Font.FontFamily, 12),
                Dock = DockStyle.Bottom,
                AutoSize = true
            };
            Controls.Add(timeLabel);
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            answerTimer.Stop();
            int selectedAnswerIndex = (int)((Button)sender).Tag;
            HandleAnswer(selectedAnswerIndex);
        }
        private void FiftyFiftyButton_Click(object sender, EventArgs e)
        {
            answerTimer.Stop();

            var wrongAnswerButtons = answerButtons.Where(e => (int)e.Tag != questions[currentQuestionIndex].CorrectAnswerIndex).ToList();
            var rnd = new Random();
            var toDisableButtons = wrongAnswerButtons.OrderBy(b => rnd.Next()).Take(2);

            foreach (var button in toDisableButtons)
            {
                button.Enabled = false;
            }

            remainingTime = 15;
            answerTimer.Start();

            fiftyFiftyButton.Enabled = false;
            fiftyFiftyButtonCondition = false;
        }

        private void CallFriendButton_Click(object sender, EventArgs e)
        {
            answerTimer.Stop();

            Button? correctAnswerButton = answerButtons.FirstOrDefault(e => (int)e.Tag == questions[currentQuestionIndex].CorrectAnswerIndex);
            correctAnswerButton.BackColor = Color.Gold;

            remainingTime = 15;
            answerTimer.Start();

            callFriendButton.Enabled = false;
            callFriendButtonCondition = false;
        }
        private void AnswerTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            if (remainingTime == 0)
            {
                answerTimer.Stop();
                MessageBox.Show("Game Over! You Lost: $" + currentMoney);
                Close();
            }
            else { timeLabel.Text = $"Time Left: {remainingTime} seconds"; }
        }

        private void HandleAnswer(int selectedAnswerIndex)
        {
            Question currentQuestion = questions[currentQuestionIndex];

            if (selectedAnswerIndex == currentQuestion.CorrectAnswerIndex)
            {
                currentMoney += currentQuestion.Money;
                NextQuestion();
            }
            else
            {
                MessageBox.Show("Game Over! You Lost: $" + currentMoney);
                Close();
            }
        }

        private void NextQuestion()
        {
            remainingTime = 15;
            currentQuestionIndex++;

            if (currentQuestionIndex < questions.Count)
            {
                ShowQuestion();
            }
            else
            {
                MessageBox.Show("Congratulations! You won: $" + currentMoney);
                Close();
            }
        }
    }
}