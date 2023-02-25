using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab2
{
    internal class Directors
    {
        public List<string> Director { get; set; }
        public List<string> Post { get; set; }

        public static void DirectorsAdd()
        {
            Directors dr = new Directors();
            Console.WriteLine("ФИО руководителя");
            dr.Director.Add(Console.ReadLine());
            Console.WriteLine("Должность руководителя");
            dr.Post.Add(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
