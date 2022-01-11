namespace ITAcademyFormApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Question_listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditFileToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ExitStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question_listBox
            // 
            this.Question_listBox.FormattingEnabled = true;
            this.Question_listBox.ItemHeight = 20;
            this.Question_listBox.Location = new System.Drawing.Point(21, 45);
            this.Question_listBox.Name = "Question_listBox";
            this.Question_listBox.Size = new System.Drawing.Size(436, 104);
            this.Question_listBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(277, 421);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileToolStripButton,
            this.EditFileToolStripButton,
            this.ExitStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(482, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // OpenFileToolStripButton
            // 
            this.OpenFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileToolStripButton.Image")));
            this.OpenFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileToolStripButton.Name = "OpenFileToolStripButton";
            this.OpenFileToolStripButton.Size = new System.Drawing.Size(76, 24);
            this.OpenFileToolStripButton.Text = "&Open File";
            // 
            // EditFileToolStripButton
            // 
            this.EditFileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EditFileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditFileToolStripButton.Image")));
            this.EditFileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditFileToolStripButton.Name = "EditFileToolStripButton";
            this.EditFileToolStripButton.Size = new System.Drawing.Size(66, 24);
            this.EditFileToolStripButton.Text = "&Edit File";
            // 
            // ExitStripButton1
            // 
            this.ExitStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitStripButton1.Name = "ExitStripButton1";
            this.ExitStripButton1.Size = new System.Drawing.Size(37, 24);
            this.ExitStripButton1.Text = "&Exit";
            this.ExitStripButton1.Click += new System.EventHandler(this.ExitStripButton1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Maybe",
            "Not sure"});
            this.checkedListBox1.Location = new System.Drawing.Point(21, 184);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(434, 120);
            this.checkedListBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 494);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Question_listBox);
            this.Name = "Form1";
            this.Text = "ITAcademyTasks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Question_listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton EditFileToolStripButton;
        private System.Windows.Forms.ToolStripButton OpenFileToolStripButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripButton ExitStripButton1;
    }
}
