using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalsLab1_Lingad.Models
{
    class Student
    {
        public int ID { get; set; }
        public int StudentNumber { get; set; }
        public double FinalGrade { get; set; }
        public double AverageGrade { get; set; }
        public List<double> myGrade = new List<double>();

        public void ComputeGrade(double quizScore, double examScore)
        {
            FinalGrade = quizScore + examScore; AverageGrade = (quizScore + examScore) / 2;

            Console.Write("Final Grade: " + FinalGrade + "." + "\n" + "Average Grade: " + AverageGrade + "." + "\n");
            //   Console.Write("Average Grade: " + AverageGrade);
            if (AverageGrade >= 60)
                Console.WriteLine("Passed!");
            else
                Console.WriteLine("Failed!");
        }
    }
}

