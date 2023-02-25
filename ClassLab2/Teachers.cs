using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLab2
{
    internal class Teachers
    {
        public List<string> Teacher { get; set; }
        public List<string[]> Group { get; set; }
        public List<string[]> Subject { get; set; }

        public static void TeacherAdd()
        {
            Teachers tch = new Teachers();
            Console.WriteLine("ФИО преподавателя");
            tch.Teacher.Add(Console.ReadLine());
            Console.WriteLine("Сколько у него групп?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Группы преподавателя:");
            string[] sub = new string[n];
            for (int i = 0; i < n; i++)
            {
                sub[i] = Console.ReadLine();
            }
            tch.Group.Add(sub);
            Console.WriteLine("Сколько у него предметов?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Предметы преподавателя:");
            for (int i = 0; i < n; i++)
            {
                sub[i] = Console.ReadLine();
            }
            tch.Subject.Add(sub);
            Console.ReadLine();
        }

        public static void Dolg()
        {
            Teachers tch = new Teachers();
            Students st = new Students();
            for (int i =0; i<tch.Teacher.LongCount() -1;i++)
            {
                Console.WriteLine("У {0} должники:", tch.Teacher[i]);
                Students:
                for (int j =0;j<st.Student.LongCount()-1;j++)
                {
                    foreach (var grp in tch.Group[i])
                    {
                        if (grp == st.Groups[j])
                        {
                            foreach (var sub in tch.Subject[i])
                            {
                                foreach (var dolg in st.Subjects[j])
                                {
                                    if (sub == dolg)
                                    {
                                        Console.WriteLine(st.Student[j]);
                                        goto Students;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void DolgAll()
        {
            Teachers tch = new Teachers();
            Students st = new Students();
            List<string> dolgs = new List<string>();
            for (int i =0;i<st.Student.LongCount()-1;i++)
            {
                foreach (var dolg in st.Subjects[i])
                {
                    dolgs.Add(dolg);
                }
            }
            for (int i=0; i<dolgs.LongCount()-1;i++)
            {
                List<string> teach = new List<string>();
                for (int j =0; j<tch.Teacher.LongCount()-1;j++)
                {
                    foreach (var sub in tch.Subject[j])
                    {
                        if (dolgs[i] == sub)
                        {
                            teach.Add(tch.Teacher[j]);
                        }
                    }
                }
                Console.WriteLine("Учителя которые принимают долг {}", dolgs[i]);
                for (int j = 0; j<teach.Count()-1;j++)
                {
                    Console.WriteLine(teach[i]);
                }
            }
        }
    }
}
