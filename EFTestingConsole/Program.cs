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
            QEMP mainemp;

            using (sqltodayEntities ctx = new sqltodayEntities())
            {
               // ctx.Database.Log = Console.Write;
                Console.WriteLine(ctx.ChangeTracker.Entries().Count());
                var Q1 = from r in ctx.QEMPs select r;
                Console.WriteLine(ctx.ChangeTracker.Entries().Count());
                var L1 = Q1.ToList();
                Console.WriteLine(ctx.ChangeTracker.Entries().Count());
                mainemp = L1[0];
                Console.WriteLine(L1[0]);
                Console.WriteLine(ctx.ChangeTracker.Entries().Count());
              //  Console.WriteLine(L1[0].QDEPT.DEPTFLOOR);
              //foreach (var item in L1)
              //  {
              //      Console.WriteLine(item.QDEPT.DEPTFLOOR);
              //      Console.WriteLine($"Count:{ctx.ChangeTracker.Entries().Count()}");
              //      foreach(var delitem in item.QDEPT.QDELs)
              //      {
              //          Console.WriteLine(delitem.QITEM);
              //          Console.WriteLine($"Count:{ctx.ChangeTracker.Entries().Count()}");
              //      }
              //  }
                Console.WriteLine(ctx.ChangeTracker.Entries().Count());
            }

            Console.WriteLine(mainemp);
            Console.WriteLine(mainemp.DEPTNAME);

        }
    }
}
