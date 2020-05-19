using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentlist
{
    class Program
    {
        class Teacher
        {
            public string name;
            public string subject;
        }
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "함기훈", subject="뉴미디어콘텐츠제작" });
            list.Add(new Teacher() { name = "최규정", subject = "JSP" });

            foreach(var item in list)
            {
                Console.WriteLine(item.name+""+item.subject);
            }

        }
    }
}
