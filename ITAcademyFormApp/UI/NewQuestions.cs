using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITAcademyFormApp
{
    internal partial class NewQuestionsForm : Form
    {
        public NewQuestionsForm()
        {
            InitializeComponent();
            Answers = new List<Answer>();
        }

        public string QuestionText { get;  set; } 
        public List<Answer> Answers { get; set; }

        private void BtnSaveQuestion_Click(object sender, EventArgs e)
        {
            QuestionText =  textBoxNewQuestion.Text;
            Answers.Clear();

            for(int i =1; i <= 4; i++)
            {
                var a = StoreAnswer(i);
                if (!string.IsNullOrEmpty(a.Text))
                {
                    Answers.Add(a);
                }

            }
            DialogResult = DialogResult.OK;
            this.Close();

        }



        public void SetAnswer(int index, Answer answer)
        {
            switch (index)
            {
                case 1:
                    textBoxNewAnswer1.Text = answer.Text;
                    checkBoxNewAnswer1.Checked = answer.IsCorrect;
                    break;
                case 2:
                    textBoxNewAnswer2.Text = answer.Text;
                    checkBoxNewAnswer2.Checked = answer.IsCorrect;
                    break;
                case 3:
                    textBoxNewAnswer3.Text = answer.Text;
                    checkBoxNewAnswer3.Checked = answer.IsCorrect;
                    break;
                case 4:
                    textBoxNewAnswer4.Text = answer.Text;
                    checkBoxNewAnswer4.Checked = answer.IsCorrect;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }  
        }


        public Answer StoreAnswer(int index)
        {
            return index switch
            {
                1 => new Answer(textBoxNewAnswer1.Text, checkBoxNewAnswer1.Checked),
                2 => new Answer(textBoxNewAnswer2.Text, checkBoxNewAnswer2.Checked),
                3 => new Answer(textBoxNewAnswer3.Text, checkBoxNewAnswer3.Checked),
                4 => new Answer(textBoxNewAnswer4.Text, checkBoxNewAnswer4.Checked),
                _ => throw new ArgumentOutOfRangeException(),
            };
        }

        private void NewQuestions_Load(object sender, EventArgs e)
        {
            textBoxNewQuestion.Text = QuestionText;
            for(int i=1; i<= Answers.Count; i++)
            {
                SetAnswer(i, Answers[i-1]);
            }
        }

        private void BtnCancelQuestion_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
