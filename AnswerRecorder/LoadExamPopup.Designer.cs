namespace AnswerRecorder
{
    partial class FormLoadExam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbExamType = new System.Windows.Forms.ComboBox();
            this.lbExamType = new System.Windows.Forms.Label();
            this.gbCustomExam = new System.Windows.Forms.GroupBox();
            this.tbChoiceSequence = new System.Windows.Forms.TextBox();
            this.btnChoiceSequence = new System.Windows.Forms.Button();
            this.lbChoiceSequence = new System.Windows.Forms.Label();
            this.cbMultiSelect = new System.Windows.Forms.CheckBox();
            this.tbNumChoices = new System.Windows.Forms.TextBox();
            this.tbNumQuestions = new System.Windows.Forms.TextBox();
            this.lbNumChoices = new System.Windows.Forms.Label();
            this.lbNumQuestions = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbExamPDF = new System.Windows.Forms.ComboBox();
            this.lbExamPDF = new System.Windows.Forms.Label();
            this.btnExamPDF = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExamAnswers = new System.Windows.Forms.Button();
            this.lbExamAnswers = new System.Windows.Forms.Label();
            this.cbExamAnswers = new System.Windows.Forms.ComboBox();
            this.ofdExamPDF = new System.Windows.Forms.OpenFileDialog();
            this.ofdExamAnswers = new System.Windows.Forms.OpenFileDialog();
            this.gbCustomExam.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbExamType
            // 
            this.cbExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExamType.FormattingEnabled = true;
            this.cbExamType.ItemHeight = 13;
            this.cbExamType.Items.AddRange(new object[] {
            "ACT",
            "SAT",
            "WYSE",
            "Custom"});
            this.cbExamType.Location = new System.Drawing.Point(78, 6);
            this.cbExamType.Name = "cbExamType";
            this.cbExamType.Size = new System.Drawing.Size(238, 21);
            this.cbExamType.TabIndex = 0;
            this.cbExamType.SelectedIndexChanged += new System.EventHandler(this.cbExamType_SelectedIndexChanged);
            // 
            // lbExamType
            // 
            this.lbExamType.AutoSize = true;
            this.lbExamType.Location = new System.Drawing.Point(12, 9);
            this.lbExamType.Name = "lbExamType";
            this.lbExamType.Size = new System.Drawing.Size(60, 13);
            this.lbExamType.TabIndex = 1;
            this.lbExamType.Text = "Exam Type";
            // 
            // gbCustomExam
            // 
            this.gbCustomExam.Controls.Add(this.tbChoiceSequence);
            this.gbCustomExam.Controls.Add(this.btnChoiceSequence);
            this.gbCustomExam.Controls.Add(this.lbChoiceSequence);
            this.gbCustomExam.Controls.Add(this.cbMultiSelect);
            this.gbCustomExam.Controls.Add(this.tbNumChoices);
            this.gbCustomExam.Controls.Add(this.tbNumQuestions);
            this.gbCustomExam.Controls.Add(this.lbNumChoices);
            this.gbCustomExam.Controls.Add(this.lbNumQuestions);
            this.gbCustomExam.Enabled = false;
            this.gbCustomExam.Location = new System.Drawing.Point(15, 148);
            this.gbCustomExam.Name = "gbCustomExam";
            this.gbCustomExam.Size = new System.Drawing.Size(304, 157);
            this.gbCustomExam.TabIndex = 2;
            this.gbCustomExam.TabStop = false;
            this.gbCustomExam.Text = "Custom";
            // 
            // tbChoiceSequence
            // 
            this.tbChoiceSequence.Enabled = false;
            this.tbChoiceSequence.Location = new System.Drawing.Point(6, 129);
            this.tbChoiceSequence.Name = "tbChoiceSequence";
            this.tbChoiceSequence.Size = new System.Drawing.Size(292, 20);
            this.tbChoiceSequence.TabIndex = 8;
            // 
            // btnChoiceSequence
            // 
            this.btnChoiceSequence.Enabled = false;
            this.btnChoiceSequence.Location = new System.Drawing.Point(104, 102);
            this.btnChoiceSequence.Name = "btnChoiceSequence";
            this.btnChoiceSequence.Size = new System.Drawing.Size(21, 21);
            this.btnChoiceSequence.TabIndex = 7;
            this.btnChoiceSequence.Text = "?";
            this.btnChoiceSequence.UseVisualStyleBackColor = true;
            // 
            // lbChoiceSequence
            // 
            this.lbChoiceSequence.AutoSize = true;
            this.lbChoiceSequence.Location = new System.Drawing.Point(6, 106);
            this.lbChoiceSequence.Name = "lbChoiceSequence";
            this.lbChoiceSequence.Size = new System.Drawing.Size(92, 13);
            this.lbChoiceSequence.TabIndex = 6;
            this.lbChoiceSequence.Text = "Choice Sequence";
            // 
            // cbMultiSelect
            // 
            this.cbMultiSelect.AutoSize = true;
            this.cbMultiSelect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbMultiSelect.Location = new System.Drawing.Point(6, 76);
            this.cbMultiSelect.Name = "cbMultiSelect";
            this.cbMultiSelect.Size = new System.Drawing.Size(154, 17);
            this.cbMultiSelect.TabIndex = 5;
            this.cbMultiSelect.Text = "Allow Multi-Select (e.g. BD)";
            this.cbMultiSelect.UseVisualStyleBackColor = true;
            // 
            // tbNumChoices
            // 
            this.tbNumChoices.Enabled = false;
            this.tbNumChoices.Location = new System.Drawing.Point(139, 43);
            this.tbNumChoices.MaxLength = 1;
            this.tbNumChoices.Name = "tbNumChoices";
            this.tbNumChoices.Size = new System.Drawing.Size(43, 20);
            this.tbNumChoices.TabIndex = 4;
            // 
            // tbNumQuestions
            // 
            this.tbNumQuestions.Location = new System.Drawing.Point(118, 13);
            this.tbNumQuestions.Name = "tbNumQuestions";
            this.tbNumQuestions.Size = new System.Drawing.Size(64, 20);
            this.tbNumQuestions.TabIndex = 3;
            this.tbNumQuestions.TextChanged += new System.EventHandler(this.tbNumQuestions_TextChanged);
            // 
            // lbNumChoices
            // 
            this.lbNumChoices.AutoSize = true;
            this.lbNumChoices.Enabled = false;
            this.lbNumChoices.Location = new System.Drawing.Point(6, 46);
            this.lbNumChoices.Name = "lbNumChoices";
            this.lbNumChoices.Size = new System.Drawing.Size(127, 13);
            this.lbNumChoices.TabIndex = 1;
            this.lbNumChoices.Text = "Number of Choices (1 - 6)";
            // 
            // lbNumQuestions
            // 
            this.lbNumQuestions.AutoSize = true;
            this.lbNumQuestions.Location = new System.Drawing.Point(6, 16);
            this.lbNumQuestions.Name = "lbNumQuestions";
            this.lbNumQuestions.Size = new System.Drawing.Size(106, 13);
            this.lbNumQuestions.TabIndex = 0;
            this.lbNumQuestions.Text = "Number of Questions";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(47, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exam PDF";
            // 
            // cbExamPDF
            // 
            this.cbExamPDF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExamPDF.FormattingEnabled = true;
            this.cbExamPDF.Location = new System.Drawing.Point(97, 43);
            this.cbExamPDF.Name = "cbExamPDF";
            this.cbExamPDF.Size = new System.Drawing.Size(156, 21);
            this.cbExamPDF.TabIndex = 6;
            // 
            // lbExamPDF
            // 
            this.lbExamPDF.AutoSize = true;
            this.lbExamPDF.Location = new System.Drawing.Point(12, 67);
            this.lbExamPDF.Name = "lbExamPDF";
            this.lbExamPDF.Size = new System.Drawing.Size(91, 13);
            this.lbExamPDF.TabIndex = 7;
            this.lbExamPDF.Text = "Selected: [ none ]";
            // 
            // btnExamPDF
            // 
            this.btnExamPDF.Location = new System.Drawing.Point(259, 41);
            this.btnExamPDF.Name = "btnExamPDF";
            this.btnExamPDF.Size = new System.Drawing.Size(60, 23);
            this.btnExamPDF.TabIndex = 8;
            this.btnExamPDF.Text = "Browse...";
            this.btnExamPDF.UseVisualStyleBackColor = true;
            this.btnExamPDF.Click += new System.EventHandler(this.btnExamPDF_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(178, 322);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(101, 40);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Exam Answers";
            // 
            // btnExamAnswers
            // 
            this.btnExamAnswers.Location = new System.Drawing.Point(259, 92);
            this.btnExamAnswers.Name = "btnExamAnswers";
            this.btnExamAnswers.Size = new System.Drawing.Size(60, 23);
            this.btnExamAnswers.TabIndex = 13;
            this.btnExamAnswers.Text = "Browse...";
            this.btnExamAnswers.UseVisualStyleBackColor = true;
            this.btnExamAnswers.Click += new System.EventHandler(this.btnExamAnswers_Click);
            // 
            // lbExamAnswers
            // 
            this.lbExamAnswers.AutoSize = true;
            this.lbExamAnswers.Location = new System.Drawing.Point(12, 119);
            this.lbExamAnswers.Name = "lbExamAnswers";
            this.lbExamAnswers.Size = new System.Drawing.Size(91, 13);
            this.lbExamAnswers.TabIndex = 12;
            this.lbExamAnswers.Text = "Selected: [ none ]";
            // 
            // cbExamAnswers
            // 
            this.cbExamAnswers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExamAnswers.FormattingEnabled = true;
            this.cbExamAnswers.Location = new System.Drawing.Point(97, 94);
            this.cbExamAnswers.Name = "cbExamAnswers";
            this.cbExamAnswers.Size = new System.Drawing.Size(156, 21);
            this.cbExamAnswers.TabIndex = 11;
            // 
            // FormLoadExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 370);
            this.Controls.Add(this.btnExamAnswers);
            this.Controls.Add(this.lbExamAnswers);
            this.Controls.Add(this.cbExamAnswers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnExamPDF);
            this.Controls.Add(this.lbExamPDF);
            this.Controls.Add(this.cbExamPDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbCustomExam);
            this.Controls.Add(this.lbExamType);
            this.Controls.Add(this.cbExamType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoadExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Exam...";
            this.gbCustomExam.ResumeLayout(false);
            this.gbCustomExam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbExamType;
        private System.Windows.Forms.Label lbExamType;
        private System.Windows.Forms.GroupBox gbCustomExam;
        private System.Windows.Forms.TextBox tbChoiceSequence;
        private System.Windows.Forms.Button btnChoiceSequence;
        private System.Windows.Forms.Label lbChoiceSequence;
        private System.Windows.Forms.CheckBox cbMultiSelect;
        private System.Windows.Forms.TextBox tbNumChoices;
        private System.Windows.Forms.TextBox tbNumQuestions;
        private System.Windows.Forms.Label lbNumChoices;
        private System.Windows.Forms.Label lbNumQuestions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbExamPDF;
        private System.Windows.Forms.Label lbExamPDF;
        private System.Windows.Forms.Button btnExamPDF;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExamAnswers;
        private System.Windows.Forms.Label lbExamAnswers;
        private System.Windows.Forms.ComboBox cbExamAnswers;
        private System.Windows.Forms.OpenFileDialog ofdExamPDF;
        private System.Windows.Forms.OpenFileDialog ofdExamAnswers;
    }
}