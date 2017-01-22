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
            this.choicebExam = new System.Windows.Forms.ComboBox();
            this.lbExam = new System.Windows.Forms.Label();
            this.gbCustomExam = new System.Windows.Forms.GroupBox();
            this.tbNumSections = new System.Windows.Forms.TextBox();
            this.lbNumSections = new System.Windows.Forms.Label();
            this.tbChoiceSequence = new System.Windows.Forms.TextBox();
            this.btnAnswers = new System.Windows.Forms.Button();
            this.lbChoiceSequence = new System.Windows.Forms.Label();
            this.checkbMultiSelect = new System.Windows.Forms.CheckBox();
            this.lbAnswers = new System.Windows.Forms.Label();
            this.tbNumChoices = new System.Windows.Forms.TextBox();
            this.tbNumQuestions = new System.Windows.Forms.TextBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.lbNumChoices = new System.Windows.Forms.Label();
            this.lbNumQuestions = new System.Windows.Forms.Label();
            this.lbPDF = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.ofdExamPDF = new System.Windows.Forms.OpenFileDialog();
            this.ofdExamAnswers = new System.Windows.Forms.OpenFileDialog();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbACT = new System.Windows.Forms.RadioButton();
            this.rbSAT = new System.Windows.Forms.RadioButton();
            this.rbWYSE = new System.Windows.Forms.RadioButton();
            this.flowRdBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.gbCustomExam.SuspendLayout();
            this.flowRdBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // choicebExam
            // 
            this.choicebExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choicebExam.Enabled = false;
            this.choicebExam.FormattingEnabled = true;
            this.choicebExam.ItemHeight = 13;
            this.choicebExam.Items.AddRange(new object[] {
            "ACT",
            "SAT",
            "WYSE",
            "Custom"});
            this.choicebExam.Location = new System.Drawing.Point(48, 43);
            this.choicebExam.Name = "choicebExam";
            this.choicebExam.Size = new System.Drawing.Size(295, 21);
            this.choicebExam.TabIndex = 0;
            // 
            // lbExam
            // 
            this.lbExam.AutoSize = true;
            this.lbExam.Enabled = false;
            this.lbExam.Location = new System.Drawing.Point(9, 46);
            this.lbExam.Name = "lbExam";
            this.lbExam.Size = new System.Drawing.Size(33, 13);
            this.lbExam.TabIndex = 1;
            this.lbExam.Text = "Exam";
            // 
            // gbCustomExam
            // 
            this.gbCustomExam.Controls.Add(this.tbNumSections);
            this.gbCustomExam.Controls.Add(this.lbNumSections);
            this.gbCustomExam.Controls.Add(this.tbChoiceSequence);
            this.gbCustomExam.Controls.Add(this.btnAnswers);
            this.gbCustomExam.Controls.Add(this.lbChoiceSequence);
            this.gbCustomExam.Controls.Add(this.checkbMultiSelect);
            this.gbCustomExam.Controls.Add(this.lbAnswers);
            this.gbCustomExam.Controls.Add(this.tbNumChoices);
            this.gbCustomExam.Controls.Add(this.tbNumQuestions);
            this.gbCustomExam.Controls.Add(this.btnPDF);
            this.gbCustomExam.Controls.Add(this.lbNumChoices);
            this.gbCustomExam.Controls.Add(this.lbNumQuestions);
            this.gbCustomExam.Controls.Add(this.lbPDF);
            this.gbCustomExam.Location = new System.Drawing.Point(12, 70);
            this.gbCustomExam.Name = "gbCustomExam";
            this.gbCustomExam.Size = new System.Drawing.Size(331, 302);
            this.gbCustomExam.TabIndex = 2;
            this.gbCustomExam.TabStop = false;
            this.gbCustomExam.Text = "Configuration";
            // 
            // tbNumSections
            // 
            this.tbNumSections.Location = new System.Drawing.Point(127, 143);
            this.tbNumSections.Name = "tbNumSections";
            this.tbNumSections.Size = new System.Drawing.Size(30, 20);
            this.tbNumSections.TabIndex = 10;
            // 
            // lbNumSections
            // 
            this.lbNumSections.AutoSize = true;
            this.lbNumSections.Location = new System.Drawing.Point(13, 146);
            this.lbNumSections.Name = "lbNumSections";
            this.lbNumSections.Size = new System.Drawing.Size(100, 13);
            this.lbNumSections.TabIndex = 9;
            this.lbNumSections.Text = "Number of Sections";
            // 
            // tbChoiceSequence
            // 
            this.tbChoiceSequence.Enabled = false;
            this.tbChoiceSequence.Location = new System.Drawing.Point(13, 270);
            this.tbChoiceSequence.Name = "tbChoiceSequence";
            this.tbChoiceSequence.Size = new System.Drawing.Size(312, 20);
            this.tbChoiceSequence.TabIndex = 8;
            // 
            // btnAnswers
            // 
            this.btnAnswers.Location = new System.Drawing.Point(16, 99);
            this.btnAnswers.Name = "btnAnswers";
            this.btnAnswers.Size = new System.Drawing.Size(60, 23);
            this.btnAnswers.TabIndex = 13;
            this.btnAnswers.Text = "Browse...";
            this.btnAnswers.UseVisualStyleBackColor = true;
            this.btnAnswers.Click += new System.EventHandler(this.btnExamAnswers_Click);
            // 
            // lbChoiceSequence
            // 
            this.lbChoiceSequence.AutoSize = true;
            this.lbChoiceSequence.Enabled = false;
            this.lbChoiceSequence.Location = new System.Drawing.Point(13, 247);
            this.lbChoiceSequence.Name = "lbChoiceSequence";
            this.lbChoiceSequence.Size = new System.Drawing.Size(92, 13);
            this.lbChoiceSequence.TabIndex = 6;
            this.lbChoiceSequence.Text = "Choice Sequence";
            // 
            // checkbMultiSelect
            // 
            this.checkbMultiSelect.AutoSize = true;
            this.checkbMultiSelect.Location = new System.Drawing.Point(176, 212);
            this.checkbMultiSelect.Name = "checkbMultiSelect";
            this.checkbMultiSelect.Size = new System.Drawing.Size(154, 17);
            this.checkbMultiSelect.TabIndex = 5;
            this.checkbMultiSelect.Text = "Allow Multi-Select (e.g. BD)";
            this.checkbMultiSelect.UseVisualStyleBackColor = true;
            // 
            // lbAnswers
            // 
            this.lbAnswers.AutoSize = true;
            this.lbAnswers.Location = new System.Drawing.Point(13, 83);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(89, 13);
            this.lbAnswers.TabIndex = 10;
            this.lbAnswers.Text = "Answers: [ none ]";
            // 
            // tbNumChoices
            // 
            this.tbNumChoices.Enabled = false;
            this.tbNumChoices.Location = new System.Drawing.Point(127, 210);
            this.tbNumChoices.MaxLength = 1;
            this.tbNumChoices.Name = "tbNumChoices";
            this.tbNumChoices.Size = new System.Drawing.Size(30, 20);
            this.tbNumChoices.TabIndex = 4;
            // 
            // tbNumQuestions
            // 
            this.tbNumQuestions.Location = new System.Drawing.Point(127, 176);
            this.tbNumQuestions.Name = "tbNumQuestions";
            this.tbNumQuestions.Size = new System.Drawing.Size(64, 20);
            this.tbNumQuestions.TabIndex = 3;
            this.tbNumQuestions.TextChanged += new System.EventHandler(this.tbNumQuestions_TextChanged);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(16, 43);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(60, 23);
            this.btnPDF.TabIndex = 8;
            this.btnPDF.Text = "Browse...";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnExamPDF_Click);
            // 
            // lbNumChoices
            // 
            this.lbNumChoices.AutoSize = true;
            this.lbNumChoices.Enabled = false;
            this.lbNumChoices.Location = new System.Drawing.Point(13, 213);
            this.lbNumChoices.Name = "lbNumChoices";
            this.lbNumChoices.Size = new System.Drawing.Size(108, 13);
            this.lbNumChoices.TabIndex = 1;
            this.lbNumChoices.Text = "Choices per Question";
            // 
            // lbNumQuestions
            // 
            this.lbNumQuestions.AutoSize = true;
            this.lbNumQuestions.Location = new System.Drawing.Point(13, 179);
            this.lbNumQuestions.Name = "lbNumQuestions";
            this.lbNumQuestions.Size = new System.Drawing.Size(106, 13);
            this.lbNumQuestions.TabIndex = 0;
            this.lbNumQuestions.Text = "Number of Questions";
            // 
            // lbPDF
            // 
            this.lbPDF.AutoSize = true;
            this.lbPDF.Location = new System.Drawing.Point(13, 27);
            this.lbPDF.Name = "lbPDF";
            this.lbPDF.Size = new System.Drawing.Size(70, 13);
            this.lbPDF.TabIndex = 5;
            this.lbPDF.Text = "PDF: [ none ]";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(48, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(201, 388);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(101, 40);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Checked = true;
            this.rbCustom.Location = new System.Drawing.Point(3, 3);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.rbCustom.Size = new System.Drawing.Size(65, 17);
            this.rbCustom.TabIndex = 14;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbACT
            // 
            this.rbACT.AutoSize = true;
            this.rbACT.Location = new System.Drawing.Point(74, 3);
            this.rbACT.Name = "rbACT";
            this.rbACT.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rbACT.Size = new System.Drawing.Size(56, 17);
            this.rbACT.TabIndex = 15;
            this.rbACT.Text = "ACT";
            this.rbACT.UseVisualStyleBackColor = true;
            this.rbACT.CheckedChanged += new System.EventHandler(this.rbACT_CheckedChanged);
            // 
            // rbSAT
            // 
            this.rbSAT.AutoSize = true;
            this.rbSAT.Location = new System.Drawing.Point(136, 3);
            this.rbSAT.Name = "rbSAT";
            this.rbSAT.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rbSAT.Size = new System.Drawing.Size(56, 17);
            this.rbSAT.TabIndex = 16;
            this.rbSAT.Text = "SAT";
            this.rbSAT.UseVisualStyleBackColor = true;
            this.rbSAT.CheckedChanged += new System.EventHandler(this.rbSAT_CheckedChanged);
            // 
            // rbWYSE
            // 
            this.rbWYSE.AutoSize = true;
            this.rbWYSE.Location = new System.Drawing.Point(198, 3);
            this.rbWYSE.Name = "rbWYSE";
            this.rbWYSE.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rbWYSE.Size = new System.Drawing.Size(67, 17);
            this.rbWYSE.TabIndex = 17;
            this.rbWYSE.Text = "WYSE";
            this.rbWYSE.UseVisualStyleBackColor = true;
            this.rbWYSE.CheckedChanged += new System.EventHandler(this.rbWYSE_CheckedChanged);
            // 
            // flowRdBtns
            // 
            this.flowRdBtns.Controls.Add(this.rbCustom);
            this.flowRdBtns.Controls.Add(this.rbACT);
            this.flowRdBtns.Controls.Add(this.rbSAT);
            this.flowRdBtns.Controls.Add(this.rbWYSE);
            this.flowRdBtns.Location = new System.Drawing.Point(48, 12);
            this.flowRdBtns.Name = "flowRdBtns";
            this.flowRdBtns.Size = new System.Drawing.Size(275, 26);
            this.flowRdBtns.TabIndex = 18;
            this.flowRdBtns.WrapContents = false;
            // 
            // FormLoadExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 435);
            this.Controls.Add(this.flowRdBtns);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbCustomExam);
            this.Controls.Add(this.lbExam);
            this.Controls.Add(this.choicebExam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoadExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Exam...";
            this.gbCustomExam.ResumeLayout(false);
            this.gbCustomExam.PerformLayout();
            this.flowRdBtns.ResumeLayout(false);
            this.flowRdBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choicebExam;
        private System.Windows.Forms.Label lbExam;
        private System.Windows.Forms.GroupBox gbCustomExam;
        private System.Windows.Forms.TextBox tbChoiceSequence;
        private System.Windows.Forms.Label lbChoiceSequence;
        private System.Windows.Forms.CheckBox checkbMultiSelect;
        private System.Windows.Forms.TextBox tbNumChoices;
        private System.Windows.Forms.TextBox tbNumQuestions;
        private System.Windows.Forms.Label lbNumChoices;
        private System.Windows.Forms.Label lbNumQuestions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbPDF;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lbAnswers;
        private System.Windows.Forms.Button btnAnswers;
        private System.Windows.Forms.OpenFileDialog ofdExamPDF;
        private System.Windows.Forms.OpenFileDialog ofdExamAnswers;
        private System.Windows.Forms.TextBox tbNumSections;
        private System.Windows.Forms.Label lbNumSections;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbACT;
        private System.Windows.Forms.RadioButton rbSAT;
        private System.Windows.Forms.RadioButton rbWYSE;
        private System.Windows.Forms.FlowLayoutPanel flowRdBtns;
    }
}