using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab2
{
    internal class Students
    {
        public List<string> Groups { get; set; }
        public List<string> Student { get; set; }
        public List<string[]> Subjects { get; set; }
        public static void StudentAdd()
        {
            Students st = new Students();
            Console.WriteLine("ФИО студента");
            st.Student.Add(Console.ReadLine());
            Console.WriteLine("Группа студента");
            st.Groups.Add(Console.ReadLine());
            Console.WriteLine("Сколько у него задолжностей?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Предметы задолжности");
            string[] sub = new string[n];
            for (int i = 0; i<n;i++)
            {
                sub[i] = Console.ReadLine();
            }
            st.Subjects.Add(sub);
            Console.ReadLine();
        }

        public static void Dolg()
        {
            Students st = new Students();
            Console.WriteLine("Название долга:");
            var name = Console.ReadLine();
            Console.WriteLine("Студенты с долгом {0}:", name);
            for (int i = 0; i<st.Student.LongCount()-1;i++)
            {
                foreach (var dolg in st.Subjects[i])
                {
                    if (dolg == name)
                    {
                        Console.WriteLine(st.Student[i]);
                        break;
                    }
                }
            }
        }
    }
}
