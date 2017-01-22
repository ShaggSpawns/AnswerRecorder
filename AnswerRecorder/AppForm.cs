using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.Net;

namespace AnswerRecorder
{
    public partial class FormApp : Form
    {
        private List<string> responses = new List<string>();
        private int currentQuestion = 0;
        private int currentTime = 0;
        ExamSession exam = new ExamSession();

        public FormApp()
        {
            InitializeComponent();
        }

        private void UpdateTime()
        {
            lbTime.Text = $"Time |  {currentTime / 60 / 60:0} : {currentTime / 60 % 60:00} : {currentTime % 60:00}";
        }
        
        private void AppendResponse(string option)
        {
            responses.Add(option);

            if (dgvResponses.Rows.Count > currentQuestion)
            {
                dgvResponses.CurrentRow.Cells[1].Value = option;
                dgvResponses.CurrentCell = dgvResponses[0, ++currentQuestion];

                dgvResponses.FirstDisplayedScrollingRowIndex = currentQuestion - (currentQuestion < 23 ? currentQuestion : 23);
            }
            else
            {
                dgvResponses.Rows.Add((++currentQuestion).ToString(), option);

                dgvResponses.FirstDisplayedScrollingRowIndex = currentQuestion;
            }
            lbSessionInfo.Text = $"Question {currentQuestion + 1} { (exam.NumQuestions >= currentQuestion ? "/ " + exam.NumQuestions : "") }";
        }

        private void dgvResponses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentQuestion = dgvResponses.CurrentCell.RowIndex;
            lbSessionInfo.Text = $"Question {currentQuestion + 1} { (exam.NumQuestions >= currentQuestion ? "/ " + exam.NumQuestions : "") }";
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            switch (btnStartStop.Text)
            {
                case "Start":
                    pdfViewer.Enabled = true;
                    timer.Start();

                    btnOption1.Enabled = true;
                    btnOption2.Enabled = true;
                    btnOption3.Enabled = true;
                    btnOption4.Enabled = true;
                    btnOption5.Enabled = true;

                    btnStartStop.Text = "Done";
                    btnCheck.Enabled = true;
                    break;

                case "Done":
                    timer.Stop();

                    btnOption1.Enabled = false;
                    btnOption2.Enabled = false;
                    btnOption3.Enabled = false;
                    btnOption4.Enabled = false;
                    btnOption5.Enabled = false;

                    btnStartStop.Text = "Reset";
                    break;

                case "Reset":
                    currentTime = 0;
                    currentQuestion = 1;
                    UpdateTime();
                    lbSessionInfo.Text = $"Question {currentQuestion}";

                    dgvResponses.Rows.Clear();
                    dgvResponses.Refresh();

                    responses.Clear();

                    btnStartStop.Text = "Start";
                    break;

                default:
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentTime += timer.Interval / 1000;
            UpdateTime();
        }
        
        private void btnOption1_Click_1(object sender, EventArgs e)
        {
            AppendResponse(btnOption1.Text);
        }


        private void btnOption2_Click_1(object sender, EventArgs e)
        {
            AppendResponse(btnOption2.Text);
        }

        private void btnOption3_Click_1(object sender, EventArgs e)
        {
            AppendResponse(btnOption3.Text);
        }

        private void btnOption4_Click_1(object sender, EventArgs e)
        {
            AppendResponse(btnOption4.Text);
        }

        private void btnOption5_Click_1(object sender, EventArgs e)
        {
            AppendResponse(btnOption5.Text);
        }

        private void LoadExam()
        {
            FormLoadExam loadPopup = new FormLoadExam(ref exam);

            loadPopup.ShowDialog();

            if (loadPopup.Success)
            {
                panelStart.Visible = false;
                if (exam.PDFPath != null && !exam.PDFPath.Equals(String.Empty))
                {
                    var stream = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(exam.PDFPath));
                    PdfDocument pdfDocument = PdfDocument.Load(stream);
                    pdfViewer.Document = pdfDocument;
                    pdfViewer.Visible = true;
                }

                if (exam.NumQuestions > 0)
                {
                    for (int i = 1; i <= exam.NumQuestions; i++)
                        dgvResponses.Rows.Add(i.ToString(), "");
                }
            }

            lbSessionInfo.Text = $"Question {currentQuestion + 1} { (exam.NumQuestions >= currentQuestion ? "/ " + exam.NumQuestions : "") }";
        }

        private void loadExamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadExam();
        }

        private void btnLoadExam_Click(object sender, EventArgs e)
        {
            LoadExam();
        }

        private void saveSesssionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exam.PDFPath != null)
            {
                string path = "";

                string file = $"answers {DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}.txt";

                using (System.IO.StreamWriter srFile = new System.IO.StreamWriter(path + file))
                {
                    foreach (string r in responses)
                    {
                        srFile.WriteLine(r);
                    }
                    srFile.WriteLine("#" + currentTime);
                }
            }
            else
            {
                string path = System.IO.Directory.GetCurrentDirectory() + @"\Saves\";
                System.IO.Directory.CreateDirectory(path);

            }
            
        }

        private void btnLoadQuick_Click(object sender, EventArgs e)
        {
            if (ofdExamPDF.ShowDialog() == DialogResult.OK)
            {
                exam.PDFPath = ofdExamPDF.FileName;

                var stream = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(exam.PDFPath));

                PdfDocument pdfDocument = PdfDocument.Load(stream);
                pdfViewer.Document = pdfDocument;

                panelStart.Visible = false;
                pdfViewer.Visible = true;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int numCorrect = 0;
            for (int i = 0; i < responses.Count; i++)
            {
                if (exam.Answers.Count > i)
                {
                    if (responses[i] == exam.Answers[i])
                    {
                        numCorrect++;
                        dgvResponses.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        dgvResponses.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void retrieveExamFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                //client.Credentials = new NetworkCredential("", "Wyse2014");
                client.DownloadFile("https://wyse.engineering.illinois.edu/files/2015/01/CompSci_Sectional2016.pdf", "CompSci_Sectional2016.pdf");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if should save
            Application.Exit();
        }
    }
}
