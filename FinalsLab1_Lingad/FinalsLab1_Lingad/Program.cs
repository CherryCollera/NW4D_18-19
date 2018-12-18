using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalsLab1_Lingad.Models;

namespace FinalsLab1_Lingad
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student();
            Exam myExam = new Exam();
            Person newPerson = new Person();
            int ctr = 0;
            int quiznum = 1;
            double quizScore, examScore, myExamScore, myQuiz;

            do
            {
                Console.Clear();
                myExam.Score = 0;
                examScore = 0;

                try
                {
                    Console.Write("Student number: ");
                    newStudent.StudentNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    newPerson.Name = Console.ReadLine();
                    Console.Write("Age: ");
                    newPerson.Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Gender: ");
                    newPerson.Gender = Console.ReadLine();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Student number should be numeric!" + e);
                }

                for (int i = 1; i <= 4; i++)
                {
                    Console.Write("Quiz " + i + " :");
                    quizScore = Convert.ToDouble(Console.ReadLine());
                    newStudent.myGrade.Add(quizScore);
                    myQuiz = myExam.ComputeExam(0, quizScore);
                    myExam.Score += quizScore;
                }


                Console.WriteLine("Final Exam: ");
                examScore = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n\nPress key to continue. ");
                Console.ReadKey();
                Console.Clear();

                foreach (var e in newStudent.myGrade)
                {
                    Console.WriteLine("Quiz " + quiznum + ": " + e);
                    quiznum++;
                }

                Console.WriteLine("Final Exam: " + examScore);

                newStudent.myGrade.Add(examScore);
                myExamScore = myExam.ComputeExam(1, examScore);
                newStudent.ComputeGrade(myExam.Score, myExamScore);

                Console.WriteLine("\n\nPress any number to continue. ");
                Console.WriteLine("Press any key to EXIT. ");
                ctr = Convert.ToInt32(Console.ReadLine());
            }
            while (ctr != 1);

        }

    }
}
