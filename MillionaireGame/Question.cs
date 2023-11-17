namespace MillionaireGame
{
    public class Question
    {
        public string Text { get; }
        public List<string> Answers { get; }
        public int CorrectAnswerIndex { get; }
        public decimal Money { get; }

        public Question(string text, List<string> answers, int correctAnswerIndex, decimal money = 10000)
        {
            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
            Money = money;
        }
    }
}