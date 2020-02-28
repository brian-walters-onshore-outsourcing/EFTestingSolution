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

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region initialization
            int[] integers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> names = new List<string>();
            names.Add("Zero");
            names.Add("One");
            names.Add("two");
            names.Add("three");
            names.Add("Four");
            names.Add("five");
            names.Add("Six");
            names.Add("seven");
            names.Add("Eight");
            names.Add("Nine");
            List<Data> DataItems = new List<Data>();
            DataItems.Add(new Data(0, "Zero", 'Z', 0.0001));
            DataItems.Add(new Data(1, "One", 'O', 1.1111));
            DataItems.Add(new Data(2, "two", 't', 2.2222));
            DataItems.Add(new Data(3, "three", 't', 3.3333));
            DataItems.Add(new Data(4, "Four", 'F', 4.4444));
            DataItems.Add(new Data(5, "five", 'f', 5.5555));
            DataItems.Add(new Data(6, "Six", 'S', 6.6666));
            DataItems.Add(new Data(7, "seven", 's', 7.7777));
            DataItems.Add(new Data(8, "Eight", 'E', 8.8888));
            DataItems.Add(new Data(9, "Nine", 'N', 9.9999));
            #endregion initialization





        }
    }
}
