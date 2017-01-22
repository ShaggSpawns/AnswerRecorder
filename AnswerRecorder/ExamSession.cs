using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerRecorder
{
    public enum ExamType
    {
        Custom,
        ACT,
        WYSE,
        SAT
    }

    public class ExamSession
    {
        public ExamType TypeExam { get; set; }
        public List<string> Answers { get; set; }
        public string AnswersPath { get; set; }
        public string PDFPath { get; set; }
        public int NumSections { get; set; }
        public int NumQuestions { get; set; }
        public int NumChoices { get; set; }
        public string ChoiceSequence { get; set; }
        public bool AllowMultiSelect { get; set; }

        public ExamSession()
        {
            TypeExam = ExamType.Custom;
            Answers = new List<string>();
            NumSections = 1;
            NumQuestions = -1;
            NumChoices = 5;
            ChoiceSequence = "";
            AllowMultiSelect = false;
            PDFPath = "";
            AnswersPath = "";
        }
    }
}
