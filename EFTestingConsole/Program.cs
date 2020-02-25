using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLTodayLibrary.sqltodayEntities ctx =
                new SQLTodayLibrary.sqltodayEntities();
            foreach( var x in ctx.QEMPs)
            {
                Console.WriteLine(x);
            }
        }
    }
}
