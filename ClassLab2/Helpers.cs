using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab2
{
    internal class Helpers
    {
        public List<string> Helper { get; set; }
        public List<string> Post { get; set; }

        public static void HelpersAdd()
        {
            Helpers hp = new Helpers();
            Console.WriteLine("ФИО помощника");
            hp.Helper.Add(Console.ReadLine());
            Console.WriteLine("Должность помощника");
            hp.Post.Add(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
