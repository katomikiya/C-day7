using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per1 = new Person();
            Person per2 = new Person();

            per1.Name = "山田太郎";
            per1.Age = 19;
            per2.setAgeAndName("佐藤花子", 23);

            per1.showAgeAndName();
            Console.WriteLine("名前：{0} 年齢：{1}", per2.Name, per2.Age);
        }
    }
}