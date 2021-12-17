using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample703
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();

            per.setAgeAndName("山田太郎", 26);
            per.Age = 32;

            per.showAgeAndName();
            
        }
    }
}