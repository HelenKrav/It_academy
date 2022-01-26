using ITAcademyFormApp.BusinesLogic;
using ITAcademyFormApp.Persistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAcademyFormApp
{
    public partial class MainForm : Form
    {
        private  IRepository<Question> _fileRepository;
        private List<Question> _questions;
        private Question _currentQuestion;
        private int _currentQuestionIndex;

        private readonly System.Threading.Timer _timer;
        private DateTime _elapsedSeconds;

        private readonly List<Result>  _result;
        

        public MainForm()
        {
            InitializeComponent();

            _timer = new System.Threading.Timer(TimerCallback, null, 0, 1000);
            ResetTimer();

            NextBackButtonEnabled();


            _result = new List<Result>();
        }

        private void NextBackButtonEnabled()
        {
            btnBackQuestion.Enabled = false;
            btnNextQuestion.Enabled = false;
        }

        public void TimerCallback(object state)
        {
            _elapsedSeconds = _elapsedSeconds.AddSeconds(1);

            SetText(_elapsedSeconds.ToString("T"));
        }       
        private void SetText(string text)
        {
            if(this.labelForTimer.InvokeRequired)
            {
                Action<string> d = (x) => SetText(x);
                this.Invoke(d, new object[] { text });
            }
            else 
            {
                this.labelForTimer.Text = text;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _fileRepository= new FileRepository();
        }

        private void LoadToolStripButton_Click(object sender, EventArgs e)
        {
            this.btnCommitAnswer.Enabled = true;
            _questions =_fileRepository.GetAll().ToList();
            if (_questions.Any(x=> String.IsNullOrEmpty(x.Text)))
            {
                return;
            }

            _currentQuestionIndex = -1;

            MoveNextQuestion();

            this.Refresh();
        }

        private void SetQuestions()
        {
            if (_questions.Count>0)
            {
                _currentQuestion = _questions[_currentQuestionIndex];
                QuestionTextBox.Text = _currentQuestion.Text;
                var iCheck = 1;
                foreach (var item in _currentQuestion.Answers)
                {
                    SetAnswersToCheckBox(iCheck++, item);
                }
            }
            else
            {
                MessageBox.Show("You haven't  any questions!" );
            }
        }       


        private void SetAnswersToCheckBox(int id, Answer value)
        {
            var chk = GetCheckBox(id);
            chk.Text = value.Text;
            chk.Visible = true;
            
        }

        private CheckBox GetCheckBox(int id)
        {
            return id switch
            {
                1 => checkBoxAnswer1,
                2 => checkBoxAnswer2,
                3 => checkBoxAnswer3,
                4 => checkBoxAnswer4,
                _ => throw new IndexOutOfRangeException(),
            };
        }


        private void BtnCommitAnswer_Click(object sender, EventArgs e)
        {
            
            var i = 1;
            bool correct = true;
            foreach (var item in _currentQuestion.Answers)
            {
                var chk = GetCheckBox(i++);
                correct = correct && (item.IsCorrect ? chk.Checked : !chk.Checked);
                if (!correct)
                {
                    break;
                }
            }
            _result.Add(new Result()
            {
                Question = _currentQuestion,
                Success = correct,
                TakenSecond = _elapsedSeconds.Second
            });
            if (_currentQuestionIndex < _questions.Count - 1)
            {
                MoveNextQuestion();
            }
            else
            {
                btnCommitAnswer.Enabled = false;
                MessageBox.Show($"Test complited. Your result {_result.Where(x=>x.Success ==true).Count()}, Time {_result.Sum(x=>x.TakenSecond)}");
                this._result.Clear();
                RefreshMainFormAfterResult();
            }
        }

        private void RefreshMainFormAfterResult()
        {
            NextBackButtonEnabled();
            for (int i=1; i <= 4; i++)
            {
                GetCheckBoxClear(i);
            }
            
        }

        private void GetCheckBoxClear(int id)
        {
            this.QuestionTextBox.Clear();
            switch (id)
            {
                case 1:
                    checkBoxAnswer1.Checked = false;
                    checkBoxAnswer1.Text = "";
                    break;
                case 2:
                    checkBoxAnswer2.Checked = false;
                    checkBoxAnswer2.Text = "";
                    break;
                case 3:
                    checkBoxAnswer3.Checked = false;
                    checkBoxAnswer3.Text = "";
                    break;
                case 4:
                    checkBoxAnswer4.Checked = false;
                    checkBoxAnswer4.Text = "";
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        private void ResetTimer()
        {
            _elapsedSeconds =  DateTime.MinValue;
        }
         

        private void NewToolStripButton1_Click(object sender, EventArgs e)
        {
            var newQuestion = new NewQuestionsForm();
            newQuestion.ShowDialog();
            if (newQuestion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            var question = new Question(newQuestion.QuestionText, newQuestion.Answers);

            Save(question);
        }

        private void UpdateToolStripButton_Click(object sender, EventArgs e)
        {
            NewQuestionsForm editForm =null;
            if (!(_currentQuestion is null))
            {
                editForm = new NewQuestionsForm
                {
                    QuestionText = _currentQuestion.Text,
                    Answers = _currentQuestion.Answers
                };
            }
            else
            {
                MessageBox.Show("You haven't  any questions!");
                return;
            }
            editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK)
                {
                    _currentQuestion.Text = editForm.QuestionText;
                    _currentQuestion.Answers = editForm.Answers;

                    _fileRepository.Update(_currentQuestion);
                    SetQuestions();
                }
        }

        private void RemoveStripButton1_Click(object sender, EventArgs e)
        {
            _fileRepository.Remove(_currentQuestion);
            SetQuestions();
            RefreshMainFormAfterResult();
            _currentQuestion = null;
            btnCommitAnswer.Enabled = false;
        }


        private void Save(Question question)
        {
            _fileRepository.Add(question);
        }    
        

        private void NextQuestion_Click(object sender, EventArgs e)
        {
            MoveNextQuestion();


        }
        private void BtnBackQuestion_Click(object sender, EventArgs e)
        {
            MovePrevQuestion();
        }

        private void MoveNextQuestion()
        {
            _currentQuestionIndex++;
            RefreshMainFormAfterResult();
            ResetTimer();
            SetQuestions();
            RefreshPrevNextButton();

        }
        private void MovePrevQuestion()
        {
            _currentQuestionIndex--;
            RefreshMainFormAfterResult();
            ResetTimer();
            SetQuestions();
            RefreshPrevNextButton();
        }

        private void RefreshPrevNextButton()
        {
            btnBackQuestion.Enabled = _currentQuestionIndex > 0;
            btnNextQuestion.Enabled = _currentQuestionIndex < _questions.Count - 1;
        }


        private void ExitStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
