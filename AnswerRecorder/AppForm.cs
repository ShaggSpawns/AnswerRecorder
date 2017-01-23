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
        private List<string> responses;
        private int currentQuestion;
        private int currentTime;
        ExamSession exam;

        private bool checking = false;

        private void NewSession(ExamSession newExam = null)
        {
            timer.Stop();
            ToggleOptionBtns(false);

            responses = new List<string>();
            currentQuestion = 1;
            currentTime = 0;
            exam = newExam ?? new ExamSession();
            
            dgvResponses.Rows.Clear();
            dgvResponses.Refresh();

            dgvResponses.Rows.Add((currentQuestion).ToString(), "");
            btnStartStop.Text = "Start";

            UpdateSessionInfo();
        }

        public FormApp()
        {
            InitializeComponent();
            NewSession();
        }

        private void UpdateSessionInfo()
        {
            lbTime.Text = $"Time |  {currentTime / 60 / 60:0} : {currentTime / 60 % 60:00} : {currentTime % 60:00}";
            lbSessionInfo.Text = $"Question {currentQuestion} { (exam.NumQuestions >= currentQuestion ? "/ " + exam.NumQuestions : "") }";
        }
        
        private void InsertResponse(string option)
        {
            if (dgvResponses.Rows.Count > currentQuestion)
            {
                if (responses.Count > currentQuestion)
                    responses.RemoveAt(currentQuestion - 1);
                responses.Insert(currentQuestion - 1, option);
                dgvResponses.CurrentRow.Cells[1].Value = option;
                dgvResponses.CurrentCell = dgvResponses[0, currentQuestion++];

                dgvResponses.FirstDisplayedScrollingRowIndex = currentQuestion - (currentQuestion < 23 ? currentQuestion : 23);
            }
            else
            {
                responses.Add(option);
                dgvResponses.CurrentRow.Cells[1].Value = option;
                dgvResponses.Rows.Add((++currentQuestion).ToString(), "");
                dgvResponses.CurrentCell = dgvResponses[0, currentQuestion - 1];
            }

            UpdateSessionInfo();

            if (checking)
            {
                for (int i = 0; i < responses.Count; i++)
                    dgvResponses.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                checking = false;
            }
        }

        private void dgvResponses_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentQuestion = dgvResponses.CurrentCell.RowIndex + 1;
            UpdateSessionInfo();
        }

        private void ToggleOptionBtns(bool enabled)
        {
            btnOption1.Enabled = enabled;
            btnOption2.Enabled = enabled;
            btnOption3.Enabled = enabled;
            btnOption4.Enabled = enabled;
            btnOption5.Enabled = enabled;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            switch (btnStartStop.Text)
            {
                case "Start":
                    pdfViewer.Enabled = true;

                    timer.Start();
                    ToggleOptionBtns(true);

                    btnStartStop.Text = "Done";
                    btnCheck.Enabled = true;
                    break;

                case "Done":
                    timer.Stop();
                    ToggleOptionBtns(false);

                    btnStartStop.Text = "Reset";
                    break;

                case "Reset":
                    NewSession();
                    break;

                default:
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentTime += timer.Interval / 1000;
            UpdateSessionInfo();
        }
        
        private void HandleBtnOption_Click(object sender, EventArgs e)
        {
            InsertResponse(((Button)sender).Text);
        }

        private void LoadExam()
        {
            FormLoadExam loadPopup = new FormLoadExam(out ExamSession newExam);
            loadPopup.ShowDialog();

            if (loadPopup.Success)
            {
                NewSession(newExam);

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
                    for (int i = 2; i <= exam.NumQuestions; i++)
                        dgvResponses.Rows.Add(i.ToString(), "");
                }
            }

            UpdateSessionInfo();
        }

        private void HandleLoadExam_Click(object sender, EventArgs e)
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
            checking = true;
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
                client.DownloadFile("https://wyse.engineering.illinois.edu/files/2014/12/2003regcomscitest.pdf", @"Exams\WYSE\Computer Science\Regional\2003\2003regcomscitest.pdf");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if should save
            Application.Exit();
        }
    }
}
