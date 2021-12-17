using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample703
{
    internal class Person
    {
        public void setAgeAndName(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void showAgeAndName()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", Name, Age);
        }

        public string Name
        {
            private set; get;
        }
        public int Age
        {
            set; get;
        }
    }
}
