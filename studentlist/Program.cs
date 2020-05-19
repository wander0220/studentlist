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
            list.Add(new Teacher() { name = "박지우", subject = "정보컴퓨터" });
            list.Add(new Teacher() { name = "신혜정", subject = "정보컴퓨터" });
            list.Add(new Teacher() { name = "이대형", subject = "국어" });

            for (int i = list.Count-1; i >= 0; i--)
            {
                if (list[i].subject == "정보컴퓨터")
                {
                    list.RemoveAt(i);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.name+" : "+item.subject);
                //if (item.subject == "정보컴퓨터")
                //{
                //    list.Remove(item);
                //}
            }


        }
    }
}
