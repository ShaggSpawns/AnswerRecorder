using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnswerRecorder
{
    public partial class ExamManager : Form
    {
        struct oExam
        {
            public int Year { get; set; }
            public string Level { get; set; }
            public string Type { get; set; }
            public string Link { get; set; }
        }
        private List<oExam> exams;

        public ExamManager()
        {
            using (var reader = new StreamReader(File.OpenRead(@"\bin\Debug\Exams\WYSE\Computer Science\CompSci.csv")))
            {
                while (!reader.EndOfStream)
                {
                    var values = reader.ReadLine().Split(',');
                    //oExam n = new oExam(Year = 111);
                }
            }

            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        private void checkbSelectAll_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
