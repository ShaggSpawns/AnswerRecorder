using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerRecorder
{
    public enum ExamType
    {
        ACT,
        WYSE,
        SAT,
        Custom
    }

    public class ExamSession
    {
        public ExamType TypeExam { get; set; }
        public List<string> Answers { get; set; }
        public int NumQuestions { get; set; }
        public int NumChoices { get; set; }
        public string SequenceChoices { get; set; }
        public bool AllowMultiSelect { get; set; }
        public string PathPDF { get; set; }
        public string PathAnswers { get; set; }
        public bool Success { get; private set; }
    }
}
