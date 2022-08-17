using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millioner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        QuestionRepository repository;
        Player player;
        int[] points = new int[] { 100, 500, 2000, 5000, 10000 };
        int currentPoints;
        int currentTurn = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            repository = new QuestionRepository("Questions.xml");
            StartGame();
        }

        private void StartGame()
        {
            string[] answerChoice = new string[4];
            repository.ResetUsedStatus();
            repository.SetCurrentQuestion();
            textBoxQuestionText.Text = repository.GetQuestionText();
            answerChoice = repository.GetQuestionAnswerChoice();
            buttonAnswer1.Text = answerChoice[0];
            buttonAnswer2.Text = answerChoice[1];
            buttonAnswer3.Text = answerChoice[2];
            buttonAnswer4.Text = answerChoice[3];
            player = new Player();
            player.ResetPoints();
            label_points.Text = player.Points.ToString();
            currentTurn = 0;
            EnableButtons();
            NextTurn();
        }

        private void NextTurn()
        {
            if (currentTurn < 5)
            {
                string[] answerChoice = new string[4];
                repository.SetCurrentQuestion();
                textBoxQuestionText.Text = repository.GetQuestionText();
                answerChoice = repository.GetQuestionAnswerChoice();
                buttonAnswer1.Text = answerChoice[0];
                buttonAnswer2.Text = answerChoice[1];
                buttonAnswer3.Text = answerChoice[2];
                buttonAnswer4.Text = answerChoice[3];
                label_points.Text = player.Points.ToString();
            }
            else
            {
                label_points.Text = player.Points.ToString();
                textBoxQuestionText.Text = "Вы победили";
                DisableButtons();
            }
        }

        private void DisableButtons()
        {
            buttonAnswer1.Enabled = false;
            buttonAnswer2.Enabled = false;
            buttonAnswer3.Enabled = false;
            buttonAnswer4.Enabled = false;
        }
        private void EnableButtons()
        {
            buttonAnswer1.Enabled = true;
            buttonAnswer2.Enabled = true;
            buttonAnswer3.Enabled = true;
            buttonAnswer4.Enabled = true;
        }

        private bool isValidAnswer(string text) => text == repository.GetCurrentAnswer();        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            if (isValidAnswer(buttonAnswer1.Text))
            {
                player.IncresePoints(points[currentTurn]);
                currentTurn++;
                NextTurn();
            }
            else
            {
                textBoxQuestionText.Text = "Вы проиграли";
                DisableButtons();
            }
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            if (isValidAnswer(buttonAnswer2.Text))
            {
                player.IncresePoints(points[currentTurn]);
                currentTurn++;
                NextTurn();
            }
            else
            {
                textBoxQuestionText.Text = "Вы проиграли";
                DisableButtons();
            }
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            if (isValidAnswer(buttonAnswer3.Text))
            {
                player.IncresePoints(points[currentTurn]);
                currentTurn++;
                NextTurn();
            }
            else
            {
                textBoxQuestionText.Text = "Вы проиграли";
                DisableButtons();
            }
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            if (isValidAnswer(buttonAnswer4.Text))
            {
                player.IncresePoints(points[currentTurn]);
                currentTurn++;
                NextTurn();
            }
            else
            {
                textBoxQuestionText.Text = "Вы проиграли";
                DisableButtons();
            }
        }
    }
}
