using SQLTodayLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestingConsole
{
    class Data
    {
        public int intData {get;set;}
        public string stringData { get; set; }
        public char charData { get; set; }
        public double doubleData { get; set; }
        public Data(int i, string s, char c, double d)
        {
            intData = i;
            stringData = s;
            charData = c;
            doubleData = d;
        }
        public override string ToString()
        {
            return $"Data: int:{intData} string:'{stringData}'  char:'{charData}' double:{doubleData}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region initialization
            int[] integers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> strings = new List<string>();
            strings.Add("Zero");
            strings.Add("One");
            strings.Add("two");
            strings.Add("three");
            strings.Add("Four");
            strings.Add("five");
            strings.Add("Six");
            strings.Add("seven");
            strings.Add("Eight");
            strings.Add("Nine");
            List<Data> datas = new List<Data>();
            datas.Add(new Data(0, "Zero", 'Z', 0.0001));
            datas.Add(new Data(1, "One", 'O', 1.1111));
            datas.Add(new Data(2, "two", 't', 2.2222));
            datas.Add(new Data(3, "three", 't', 3.3333));
            datas.Add(new Data(4, "Four", 'F', 4.4444));
            datas.Add(new Data(5, "five", 'f', 5.5555));
            datas.Add(new Data(6, "Six", 'S', 6.6666));
            datas.Add(new Data(7, "seven", 's', 7.7777));
            datas.Add(new Data(8, "Eight", 'E', 8.8888));
            datas.Add(new Data(9, "Nine", 'N', 9.9999));
            #endregion initialization

            int cutoff = 3;

            var q1 = from y in datas
                     where (y.intData > cutoff)
                     select new {y.stringData, y.doubleData, length = y.stringData.Length };
           
            var l = q1.ToList();

            foreach(var x in q1)
            {
                Console.WriteLine(x);
            }

            cutoff = 1;
           
            Console.WriteLine("*******************");
            foreach (var x in q1)
            {
                Console.WriteLine(x);
            }





        }
    }
}
