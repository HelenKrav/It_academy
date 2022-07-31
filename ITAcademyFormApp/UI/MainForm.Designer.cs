namespace ITAcademyFormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LoadToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.NewToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.UpdateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ExitToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnBackQuestion = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.btnCommitAnswer = new System.Windows.Forms.Button();
            this.panelForAnswers = new System.Windows.Forms.Panel();
            this.checkBoxAnswer4 = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswer3 = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswer2 = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswer1 = new System.Windows.Forms.CheckBox();
            this.labelForTimer = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panelForAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripButton,
            this.NewToolStripButton1,
            this.UpdateToolStripButton,
            this.RemoveToolStripButton1,
            this.ExitToolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(615, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LoadToolStripButton
            // 
            this.LoadToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LoadToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadToolStripButton.Image")));
            this.LoadToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadToolStripButton.Name = "LoadToolStripButton";
            this.LoadToolStripButton.Size = new System.Drawing.Size(46, 24);
            this.LoadToolStripButton.Text = "&Load";
            this.LoadToolStripButton.Click += new System.EventHandler(this.LoadToolStripButton_Click);
            // 
            // NewToolStripButton1
            // 
            this.NewToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton1.Image")));
            this.NewToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton1.Name = "NewToolStripButton1";
            this.NewToolStripButton1.Size = new System.Drawing.Size(43, 24);
            this.NewToolStripButton1.Text = "&New";
            this.NewToolStripButton1.Click += new System.EventHandler(this.NewToolStripButton1_Click);
            // 
            // UpdateToolStripButton
            // 
            this.UpdateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UpdateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateToolStripButton.Image")));
            this.UpdateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdateToolStripButton.Name = "UpdateToolStripButton";
            this.UpdateToolStripButton.Size = new System.Drawing.Size(62, 24);
            this.UpdateToolStripButton.Text = "&Update";
            this.UpdateToolStripButton.Click += new System.EventHandler(this.UpdateToolStripButton_Click);
            // 
            // RemoveToolStripButton1
            // 
            this.RemoveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RemoveToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("RemoveToolStripButton1.Image")));
            this.RemoveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveToolStripButton1.Name = "RemoveToolStripButton1";
            this.RemoveToolStripButton1.Size = new System.Drawing.Size(67, 24);
            this.RemoveToolStripButton1.Text = "&Remove";
            this.RemoveToolStripButton1.Click += new System.EventHandler(this.RemoveStripButton1_Click);
            // 
            // ExitToolStripButton1
            // 
            this.ExitToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolStripButton1.Name = "ExitToolStripButton1";
            this.ExitToolStripButton1.Size = new System.Drawing.Size(37, 24);
            this.ExitToolStripButton1.Text = "&Exit";
            this.ExitToolStripButton1.Click += new System.EventHandler(this.ExitStripButton1_Click);
            // 
            // btnBackQuestion
            // 
            this.btnBackQuestion.Location = new System.Drawing.Point(124, 200);
            this.btnBackQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackQuestion.Name = "btnBackQuestion";
            this.btnBackQuestion.Size = new System.Drawing.Size(90, 41);
            this.btnBackQuestion.TabIndex = 9;
            this.btnBackQuestion.Text = "Back";
            this.btnBackQuestion.UseVisualStyleBackColor = true;
            this.btnBackQuestion.Click += new System.EventHandler(this.BtnBackQuestion_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(407, 200);
            this.btnNextQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(90, 41);
            this.btnNextQuestion.TabIndex = 10;
            this.btnNextQuestion.Text = "Next";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.NextQuestion_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionTextBox.Location = new System.Drawing.Point(22, 60);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.ReadOnly = true;
            this.QuestionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.QuestionTextBox.Size = new System.Drawing.Size(562, 135);
            this.QuestionTextBox.TabIndex = 12;
            // 
            // btnCommitAnswer
            // 
            this.btnCommitAnswer.Location = new System.Drawing.Point(22, 415);
            this.btnCommitAnswer.Name = "btnCommitAnswer";
            this.btnCommitAnswer.Size = new System.Drawing.Size(562, 58);
            this.btnCommitAnswer.TabIndex = 13;
            this.btnCommitAnswer.Text = "Commit_Answer";
            this.btnCommitAnswer.UseVisualStyleBackColor = true;
            this.btnCommitAnswer.Click += new System.EventHandler(this.BtnCommitAnswer_Click);
            // 
            // panelForAnswers
            // 
            this.panelForAnswers.Controls.Add(this.checkBoxAnswer4);
            this.panelForAnswers.Controls.Add(this.checkBoxAnswer3);
            this.panelForAnswers.Controls.Add(this.checkBoxAnswer2);
            this.panelForAnswers.Controls.Add(this.checkBoxAnswer1);
            this.panelForAnswers.Location = new System.Drawing.Point(22, 246);
            this.panelForAnswers.Name = "panelForAnswers";
            this.panelForAnswers.Size = new System.Drawing.Size(562, 163);
            this.panelForAnswers.TabIndex = 14;
            // 
            // checkBoxAnswer4
            // 
            this.checkBoxAnswer4.AutoSize = true;
            this.checkBoxAnswer4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswer4.Location = new System.Drawing.Point(12, 123);
            this.checkBoxAnswer4.Name = "checkBoxAnswer4";
            this.checkBoxAnswer4.Size = new System.Drawing.Size(119, 26);
            this.checkBoxAnswer4.TabIndex = 3;
            this.checkBoxAnswer4.Text = "checkBox4";
            this.checkBoxAnswer4.UseVisualStyleBackColor = true;
            this.checkBoxAnswer4.Visible = false;
            // 
            // checkBoxAnswer3
            // 
            this.checkBoxAnswer3.AutoSize = true;
            this.checkBoxAnswer3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswer3.Location = new System.Drawing.Point(12, 82);
            this.checkBoxAnswer3.Name = "checkBoxAnswer3";
            this.checkBoxAnswer3.Size = new System.Drawing.Size(119, 26);
            this.checkBoxAnswer3.TabIndex = 2;
            this.checkBoxAnswer3.Text = "checkBox3";
            this.checkBoxAnswer3.UseVisualStyleBackColor = true;
            this.checkBoxAnswer3.Visible = false;
            // 
            // checkBoxAnswer2
            // 
            this.checkBoxAnswer2.AutoSize = true;
            this.checkBoxAnswer2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswer2.Location = new System.Drawing.Point(12, 42);
            this.checkBoxAnswer2.Name = "checkBoxAnswer2";
            this.checkBoxAnswer2.Size = new System.Drawing.Size(119, 26);
            this.checkBoxAnswer2.TabIndex = 1;
            this.checkBoxAnswer2.Text = "checkBox2";
            this.checkBoxAnswer2.UseVisualStyleBackColor = true;
            this.checkBoxAnswer2.Visible = false;
            // 
            // checkBoxAnswer1
            // 
            this.checkBoxAnswer1.AutoSize = true;
            this.checkBoxAnswer1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAnswer1.Location = new System.Drawing.Point(12, 3);
            this.checkBoxAnswer1.Name = "checkBoxAnswer1";
            this.checkBoxAnswer1.Size = new System.Drawing.Size(119, 26);
            this.checkBoxAnswer1.TabIndex = 0;
            this.checkBoxAnswer1.Text = "checkBox1";
            this.checkBoxAnswer1.UseVisualStyleBackColor = true;
            this.checkBoxAnswer1.Visible = false;
            // 
            // labelForTimer
            // 
            this.labelForTimer.AutoSize = true;
            this.labelForTimer.Location = new System.Drawing.Point(534, 27);
            this.labelForTimer.Name = "labelForTimer";
            this.labelForTimer.Size = new System.Drawing.Size(50, 20);
            this.labelForTimer.TabIndex = 15;
            this.labelForTimer.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(615, 501);
            this.Controls.Add(this.labelForTimer);
            this.Controls.Add(this.panelForAnswers);
            this.Controls.Add(this.btnCommitAnswer);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnBackQuestion);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "ITAcademyTasks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelForAnswers.ResumeLayout(false);
            this.panelForAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UpdateToolStripButton;
        private System.Windows.Forms.ToolStripButton LoadToolStripButton;
        private System.Windows.Forms.ToolStripButton ExitToolStripButton1;
        private System.Windows.Forms.Button btnBackQuestion;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.Button btnCommitAnswer;
        private System.Windows.Forms.Panel panelForAnswers;
        private System.Windows.Forms.CheckBox checkBoxAnswer4;
        private System.Windows.Forms.CheckBox checkBoxAnswer3;
        private System.Windows.Forms.CheckBox checkBoxAnswer2;
        private System.Windows.Forms.CheckBox checkBoxAnswer1;
        private System.Windows.Forms.ToolStripButton RemoveToolStripButton1;
        private System.Windows.Forms.ToolStripButton NewToolStripButton1;
        private System.Windows.Forms.Label labelForTimer;
    }
}
