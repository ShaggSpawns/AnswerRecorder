using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnswerRecorder
{
    
    public partial class FormLoadExam : Form
    {
        public bool Success { get; private set; }

        private ExamSession exam;

        public FormLoadExam(ref ExamSession exam)
        {
            this.exam = exam;
            InitializeComponent();
            UpdateUIConfig();
        }

        private void UpdateUIConfig()
        {
            lbPDF.Text = $"PDF: [ {(exam.PDFPath.Equals("") ? "none" : exam.PDFPath.Substring(exam.PDFPath.LastIndexOf('\\') + 1))} ]";
            lbAnswers.Text = $"Answers: [ {(exam.AnswersPath.Equals("") ? "none" : exam.AnswersPath.Substring(exam.AnswersPath.LastIndexOf('\\') + 1))} ]";
            tbNumChoices.Text = exam.NumChoices.ToString();
            tbNumQuestions.Text = exam.NumQuestions > 0 ? exam.NumQuestions.ToString() : "";
            checkbMultiSelect.Checked = exam.AllowMultiSelect;
            tbChoiceSequence.Text = exam.ChoiceSequence;
            tbNumSections.Text = exam.NumSections.ToString();
        }

        private void btnExamPDF_Click(object sender, EventArgs e)
        {
            if (ofdExamPDF.ShowDialog() == DialogResult.OK)
            {
                exam.PDFPath = ofdExamPDF.FileName;
                UpdateUIConfig();
            }
        }

        private void btnExamAnswers_Click(object sender, EventArgs e)
        {
            if (ofdExamAnswers.ShowDialog() == DialogResult.OK)
            {
                exam.AnswersPath = ofdExamAnswers.FileName;
                UpdateUIConfig();

                exam.Answers = System.IO.File.ReadAllLines(exam.AnswersPath).ToList();
                exam.NumQuestions = exam.Answers.Count;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Success = false;
            Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Success = true;
            Close();
        }

        private void tbNumQuestions_TextChanged(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbNumQuestions.Text, out int num))
            {
                tbNumQuestions.ForeColor = Color.Black;
                exam.NumQuestions = num;
            }
            else
            {
                tbNumQuestions.ForeColor = Color.Red;
            }
        }


        private void HandleRadioGroup(ExamType selected)
        {
            gbCustomExam.Enabled = selected.Equals(ExamType.Custom);

            switch (selected)
            {
                case ExamType.Custom:

                    break;
                case ExamType.ACT:
                    break;
                case ExamType.WYSE:
                    break;
                case ExamType.SAT:
                    break;
                default:
                    break;
            }
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            HandleRadioGroup(ExamType.Custom);
        }

        private void rbACT_CheckedChanged(object sender, EventArgs e)
        {
            HandleRadioGroup(ExamType.ACT);
        }

        private void rbSAT_CheckedChanged(object sender, EventArgs e)
        {
            HandleRadioGroup(ExamType.SAT);
        }

        private void rbWYSE_CheckedChanged(object sender, EventArgs e)
        {
            HandleRadioGroup(ExamType.WYSE);
        }
    }
}
