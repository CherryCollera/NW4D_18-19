using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsLab1_Lingad.Models
{
    class Exam
    {
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public double Score { get; set; }
        public double Grade { get; set; }
        public ExamType studentExamType = new ExamType();

        public double ComputeExam(int examtype, double MyScore)
        {
            if (examtype == System.Convert.ToInt32(ExamType.regular))
            {
                Score = MyScore / 50 * 0.1;

            }
            else if (examtype == System.Convert.ToInt32(ExamType.regular))
            {
                Score = MyScore / 100 * 0.6;

            }
            return Score;
        }
    }
    public enum ExamType
    {
        regular,
        finals

    }
}

