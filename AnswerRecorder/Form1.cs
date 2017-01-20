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
    public partial class formWindow : Form
    {
        public formWindow()
        {
            InitializeComponent();
        }

        private List<string> responses = new List<string>();
        private int currentQuestion = 1;
        private int currentTime = 0;

        private void AppendResponse(string option)
        {
            if (currentQuestion == 1)
            {
                timer.Start();
                btnDone.Enabled = true;
                btnLoadSave.Text = "Save";
            }
            responses.Add(option);
            dgvResponses.Rows.Add((currentQuestion++).ToString(), option);
            dgvResponses.FirstDisplayedScrollingRowIndex = currentQuestion - 2;
            lbQuestion.Text = $"Question {currentQuestion}";
        }

        private void BtnOption1_Click(object sender, EventArgs e)
        {
            AppendResponse(btnOption1.Text);
        }

        private void BtnOption2_Click(object sender, EventArgs e)
        {
            AppendResponse(btnOption2.Text);
        }

        private void BtnOption3_Click(object sender, EventArgs e)
        {
            AppendResponse(btnOption3.Text);
        }

        private void BtnOption4_Click(object sender, EventArgs e)
        {
            AppendResponse(btnOption4.Text);
        }

        private void BtnOption5_Click(object sender, EventArgs e)
        {
            AppendResponse(btnOption5.Text);
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            switch (btnDone.Text)
            {
                case "Done":
                    timer.Stop();

                    btnOption1.Enabled = false;
                    btnOption2.Enabled = false;
                    btnOption3.Enabled = false;
                    btnOption4.Enabled = false;
                    btnOption5.Enabled = false;

                    btnDone.Text = "Reset";
                    break;
                case "Reset":
                    currentTime = 0;
                    lbTimer.Text = "Time |  0 : 00 : 00";

                    dgvResponses.Rows.Clear();
                    dgvResponses.Refresh();

                    responses.Clear();

                    currentQuestion = 1;
                    lbQuestion.Text = $"Question {currentQuestion}";

                    btnOption1.Enabled = true;
                    btnOption2.Enabled = true;
                    btnOption3.Enabled = true;
                    btnOption4.Enabled = true;
                    btnOption5.Enabled = true;

                    btnDone.Enabled = false;
                    btnDone.Text = "Done";

                    btnLoadSave.Text = "Load";
                    break;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            currentTime += timer.Interval / 1000;
            
            lbTimer.Text = $"Time |  {currentTime / 60 / 60 :0} : {currentTime / 60 % 60 :00} : {currentTime % 60 :00}";
        }

        private void btnLoadSave_Click(object sender, EventArgs e)
        {
            switch (btnLoadSave.Text)
            {
                case "Load":
                    if (ofdPreviousResponses.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (System.IO.StreamReader srFile = new System.IO.StreamReader(ofdPreviousResponses.FileName))
                        {
                            while (!srFile.EndOfStream)
                            {
                                AppendResponse(srFile.ReadLine());
                            }
                        }
                    }
                    break;

                case "Save":
                    string path = System.IO.Directory.GetCurrentDirectory() + @"\Saves\";
                    System.IO.Directory.CreateDirectory(path);
                    string file = $"answers {DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}.txt";
                    System.IO.File.WriteAllLines(path + file, responses.ToArray<string>());
                    break;
            }
        }
    }
}
