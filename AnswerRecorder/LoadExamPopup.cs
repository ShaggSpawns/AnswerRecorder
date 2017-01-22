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
        }

        private void cbExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ExamType)cbExamType.SelectedIndex)
            {
                case ExamType.ACT:
                    break;
                case ExamType.WYSE:
                    break;
                case ExamType.SAT:
                    break;
                case ExamType.Custom:
                    gbCustomExam.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btnExamPDF_Click(object sender, EventArgs e)
        {
            if (ofdExamPDF.ShowDialog() == DialogResult.OK)
            {
                exam.PathPDF = ofdExamPDF.FileName;
                lbExamPDF.Text = $"Selected: [ {exam.PathPDF.Substring(exam.PathPDF.LastIndexOf('\\') + 1)} ]";
            }
        }

        private void btnExamAnswers_Click(object sender, EventArgs e)
        {
            if (ofdExamAnswers.ShowDialog() == DialogResult.OK)
            {
                lbExamAnswers.Text = exam.PathAnswers = ofdExamAnswers.FileName;
                lbExamAnswers.Text = $"Selected: [ {exam.PathAnswers.Substring(exam.PathAnswers.LastIndexOf('\\') + 1)} ]";

                exam.Answers = System.IO.File.ReadAllLines(exam.PathAnswers).ToList();
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
    }
}
