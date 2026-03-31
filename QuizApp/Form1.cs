using QuizApp.Models;
namespace QuizApp
{
    public partial class Form1 : Form
    {
        QuizApiClient? _client;
        List<QuizQuestion> _questions = [];
        int _currentindex = 0;
        string _correctAnswer = "";

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

            ShowQuestion();
        }
        
        private void ShowQuestion()
        {
            if (_questions.Count == 0 || _currentindex >= _questions.Count)
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

            if (_currentindex >= _questions.Count - 1)
            {
                MessageBox.Show("Quiz completed!");
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
    }
}
