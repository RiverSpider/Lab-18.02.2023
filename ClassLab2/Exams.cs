using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab2
{
    internal class Exams
    {
        public List<string> Exam { get; set; }

        public static void ExamAdd()
        {
            Teachers tch = new Teachers();
            Students st = new Students();
            Exams ex = new Exams();
            Console.WriteLine("Название Экзамена:");
            ex.Exam.Add(Console.ReadLine());
            Console.WriteLine("Издан новый экзамен!");
            Console.WriteLine("Всем преподавателям:");
            for (int i = 0; i<tch.Teacher.LongCount() -1 ;i++)
            {
                Console.WriteLine(tch.Teacher[i]);
            }
            Console.WriteLine("И всем студентам:");
            for (int i = 0; i < st.Student.LongCount() - 1; i++)
            {
                Console.WriteLine(st.Student[i]);
            }
            Console.WriteLine("Приготовиться!");
        }

        public static void ExamCount()
        {
            Exams ex = new Exams();
            for (int i = 0; i<ex.Exam.LongCount() -1;i++)
            {
                Console.WriteLine(ex.Exam[i]);
            }
        }
    }
}
