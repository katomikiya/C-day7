﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample702
{
    internal class Access
    {
        private int data1 = 5;
        private int data2 = 0;

        public void showDatas()
        {
            Console.WriteLine("data1 = {0} data2 = {1}", data1, data2);
        }

        // プロパティ
        public int Data1
        {
            get { return data1; }   // 読み込みオンリー
        }
        public int Data2
        {
            set { data2 = value; }  // 書き込みオンリー
        }
    }
}
