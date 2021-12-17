using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    internal class Person
    {
        private string name = "";
        private int age = 0;

        public void setAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void showAgeAndName()
        {
            Console.WriteLine("名前：{0} 年齢：{1}", name, age);
        }
        public string Name  // Nameプロパティ定義
        {
            set { name = value; }
            get { return name; }
        }
        public int Age      // Ageプロパティ定義
        {
            set { age = value; }
            get { return age; }
        }
    }
}
