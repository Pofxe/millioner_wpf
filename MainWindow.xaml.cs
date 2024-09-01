using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace MillionaireGame
{
    public partial class MainWindow : Window
    {
        private readonly QuestionManager questionManager;
        private int currentQuestionIndex;
        private readonly List<Question> questions;
        private List<TextBlock> moneyTextBlocks;
        private bool immuneLifeUsed = false;
        private bool fiftyFiftyUsed = false;

        public MainWindow()
        {
            InitializeComponent();
            questionManager = new QuestionManager();
            questions = questionManager.GetQuestions();
            currentQuestionIndex = 0;
            InitializeMoneyTextBlocks();
            LoadQuestion(currentQuestionIndex);
        }

        private void InitializeMoneyTextBlocks()
        {
            moneyTextBlocks = new List<TextBlock>
            {
                t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15
            };
        }

        private void LoadQuestion(int index)
        {
            if (index >= 0 && index < questions.Count)
            {
                var question_ = questions[index];
                question.Text = question_.Text;
                answer1.Content = question_.Answers[0].Text;
                answer2.Content = question_.Answers[1].Text;
                answer3.Content = question_.Answers[2].Text;
                answer4.Content = question_.Answers[3].Text;

                HighlightMoneyTextBlock(index, Brushes.Goldenrod);

                if (fiftyFiftyUsed)
                {
                    answer1.Visibility = Visibility.Visible;
                    answer2.Visibility = Visibility.Visible;
                    answer3.Visibility = Visibility.Visible;
                    answer4.Visibility = Visibility.Visible;
                    fiftyFiftyUsed = false;
                }
            }
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string selectedAnswer = clickedButton.Content.ToString();
            CheckAnswer(selectedAnswer);
        }

        private void CheckAnswer(string selectedAnswer)
        {
            var currentQuestion = questions[currentQuestionIndex];
            foreach (var answer in currentQuestion.Answers)
            {
                if (answer.Text == selectedAnswer)
                {
                    if (answer.IsCorrect)
                    {
                        MessageBox.Show("Правильно!!!");
                        HighlightMoneyTextBlock(currentQuestionIndex, Brushes.Green);
                        currentQuestionIndex++;
                        if (currentQuestionIndex < questions.Count)
                        {
                            LoadQuestion(currentQuestionIndex);
                        }
                        else
                        {
                            EndGame("Вы ответили правильно на все вопросы и стали миллионером!!!");
                        }
                    }
                    else
                    {
                        if (immuneLifeUsed)
                        {
                            immuneLifeUsed = false;
                            MessageBox.Show("Неправильно! Но у вас была несгораемая жизнь, игра продолжается.");
                        }
                        else
                        {
                            HighlightMoneyTextBlock(currentQuestionIndex, Brushes.Red);
                            EndGame("Вы ответили не правильно и не дошли до финала!!!");
                        }
                    }
                    break;
                }
            }
            immuneLifeUsed = false;
        }

        private void HighlightMoneyTextBlock(int index, Brush color)
        {
            if (index >= 0 && index < moneyTextBlocks.Count)
            {
                moneyTextBlocks[index].Background = color;
            }
        }

        private void EndGame(string text)
        {
            answer1.IsEnabled = false;
            answer2.IsEnabled = false;
            answer3.IsEnabled = false;
            answer4.IsEnabled = false;

            hint1.IsEnabled = false;
            hint2.IsEnabled = false;
            hint3.IsEnabled = false;
            hint4.IsEnabled = false;

            MessageBox.Show(text);

            this.Close();
        }

        private void Hint50_50_Click(object sender, RoutedEventArgs e)
        {
            var currentQuestion = questions[currentQuestionIndex];
            var correctAnswer = currentQuestion.Answers.First(a => a.IsCorrect);
            var incorrectAnswers = currentQuestion.Answers.Where(a => !a.IsCorrect).ToList();

            var random = new Random();
            var randomIncorrectAnswer = incorrectAnswers[random.Next(incorrectAnswers.Count)];

            answer1.Visibility = correctAnswer.Text == answer1.Content.ToString() || randomIncorrectAnswer.Text == answer1.Content.ToString() ? Visibility.Visible : Visibility.Hidden;
            answer2.Visibility = correctAnswer.Text == answer2.Content.ToString() || randomIncorrectAnswer.Text == answer2.Content.ToString() ? Visibility.Visible : Visibility.Hidden;
            answer3.Visibility = correctAnswer.Text == answer3.Content.ToString() || randomIncorrectAnswer.Text == answer3.Content.ToString() ? Visibility.Visible : Visibility.Hidden;
            answer4.Visibility = correctAnswer.Text == answer4.Content.ToString() || randomIncorrectAnswer.Text == answer4.Content.ToString() ? Visibility.Visible : Visibility.Hidden;

            hint1.IsEnabled = false;
            fiftyFiftyUsed = true;
        }

        private void HintCallFriend_Click(object sender, RoutedEventArgs e)
        {
            var currentQuestion = questions[currentQuestionIndex];
            var possibleAnswers = currentQuestion.Answers.ToList();
            var random = new Random();
            var randomAnswer = possibleAnswers[random.Next(possibleAnswers.Count)];

            MessageBox.Show($"Друг считает, что возможный ответ: {randomAnswer.Text}");

            hint3.IsEnabled = false;
        }

        private void HintAudience_Click(object sender, RoutedEventArgs e)
        {
            var currentQuestion = questions[currentQuestionIndex];
            var correctAnswer = currentQuestion.Answers.First(a => a.IsCorrect);

            MessageBox.Show($"Помощь зала считает, что правильный ответ: {correctAnswer.Text}");

            hint2.IsEnabled = false;
        }

        private void HintImmune_Click(object sender, RoutedEventArgs e)
        {
            immuneLifeUsed = true;
            MessageBox.Show("Вы использовали несгораемую жизнь. Теперь у вас есть еще одна попытка в случае неправильного ответа.");

            hint4.IsEnabled = false;
        }
    }

}