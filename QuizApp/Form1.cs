using QuizApp.Models;
namespace QuizApp
{
    public partial class Form1 : Form
    {
        QuizApiClient? _client;
        List<QuizQuestion> _questions = [];
        int _currentindex = 0;
        int _correctCount = 0;
        string _correctAnswer = "";
        bool _isCompleted = false;

        public Form1()
        {
            InitializeComponent();
            NxtBtn.Click += NxtBtn_Click;
        }


        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _client = QuizApiClient.Create();

            _questions = await _client.GetQuizQuestionsAsync();

            questlbl.Text = $"{_correctCount}/{_questions.Count}";
            NxtBtn.Text = "Next";

            ShowQuestion();
        }

        private void ShowQuestion()
        {
            if (_questions.Count == 0 || _currentindex >= _questions.Count || _isCompleted)
                return;
            var q = _questions[_currentindex];

            lbl1.Text = q.Question;

            var answers = new List<string>(q.IncorrectAnswers)
            {
                q.CorrectAnswer
            };

            var rng = new Random();
            answers = answers.OrderBy(x => rng.Next()).ToList();

            rbAns1.Text = answers[0];
            rbAns2.Text = answers[1];
            rbAns3.Text = answers[2];
            rbAns4.Text = answers[3];

            _correctAnswer = q.CorrectAnswer;

            rbAns1.Checked = false;
            rbAns2.Checked = false;
            rbAns3.Checked = false;
            rbAns4.Checked = false;

        }

        private void NxtBtn_Click(object? sender, EventArgs e)
        {
            if (_questions.Count == 0)
            {
                MessageBox.Show("Questions are not loaded yet. Please wait.");
                return;
            }
            if (_isCompleted)
            {
                return;
            }
            string? selected = null;
            if (rbAns1.Checked) selected = rbAns1.Text;
            else if (rbAns2.Checked) selected = rbAns2.Text;
            else if (rbAns3.Checked) selected = rbAns3.Text;
            else if (rbAns4.Checked) selected = rbAns4.Text;

            if (selected == null)
            {
                MessageBox.Show("Please select an answer before continuing.");
                return;
            }

            if (string.Equals(selected, _correctAnswer, StringComparison.Ordinal) && _correctCount < _questions.Count)
            {
                _correctCount++;
            }

            {
                questlbl.Text = $"{_correctCount}/{_questions.Count}";
            }

            if (_currentindex >= _questions.Count - 1)
            {
                _isCompleted = true;

                rbAns1.Enabled = rbAns2.Enabled = rbAns3.Enabled = rbAns4.Enabled = false;
                
                bool passed = _correctCount == _questions.Count;
                if (passed)
                    MessageBox.Show("Quiz completed! - you passed!");
                else
                    MessageBox.Show($"Quiz completed! - you failed! You got {_correctCount} out of {_questions.Count} correct.");
                return;
            }

            _currentindex++;
            ShowQuestion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
