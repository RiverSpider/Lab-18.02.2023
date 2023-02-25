using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab2
{
    internal class Rules
    {
        public Dictionary<string, string> RulePrepod { get; set; }
        public Dictionary<string, string> RuleHelper { get; set; }

        public static void RuleAdd()
        {
            Rules rl = new Rules();
            Teachers tch = new Teachers();
            Students st = new Students();
            Helpers hp = new Helpers();
            Directors dr = new Directors();
            Console.WriteLine("Кто издал этот указ?");
            Console.WriteLine("-----------------------------------");
            string name;
            while (true)
            {
                name = Console.ReadLine();
                int count = 0;
                for (int i = 0; i < dr.Director.LongCount() - 1; i++)
                {
                    if (name == dr.Director[i])
                    {
                        count++;
                    }
                }
                if (count==0)
                {
                    Console.WriteLine("Такого директора нет");
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.Clear();
            Console.WriteLine("Для кого будет этот указ?");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Для преподавателей и студентов");
            Console.WriteLine("2. Для помощников");
            Console.WriteLine("Выход");
            int command = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Номер указа:");
            if (command == 1)
            {
                rl.RulePrepod.Add(Console.ReadLine(), name);
                Console.WriteLine("Издан новый указ!");
                Console.WriteLine("Всем преподавателям:");
                for (int i = 0; i < tch.Teacher.LongCount() - 1; i++)
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
            else if (command == 2)
            {
                rl.RuleHelper.Add(Console.ReadLine(), name);
                Console.WriteLine("Издан новый указ!");
                Console.WriteLine("Всем помощникам:");
                for (int i = 0; i < hp.Helper.LongCount() - 1; i++)
                {
                    Console.WriteLine(hp.Helper[i]);
                }
                Console.WriteLine("Приготовиться!");
            }
            else
            {
                
            }
        }

        public static void RuleCount()
        {
            Console.WriteLine("Какие указы вывести?");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Для преподавателей и студентов");
            Console.WriteLine("2. Для помощников");
            Console.WriteLine("Выход");
            Rules rl = new Rules();
            int command = Convert.ToInt32(Console.ReadLine());
            if (command == 1)
            {
                foreach (var rule in rl.RulePrepod)
                {
                    Console.WriteLine($"Номер: {rule.Key}  ФИО: {rule.Value}");
                }
            }
            else if (command == 2)
            {
                foreach (var rule in rl.RuleHelper)
                {
                    Console.WriteLine($"Номер:  {rule.Key}   ФИО: {rule.Value}");
                }
            }
            else
            {

            }
            
        }
    }
}
