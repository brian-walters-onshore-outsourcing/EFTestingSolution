using SQLTodayLibrary;
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
            using (SQLTodayLibrary.sqltodayEntities ctx =
                new SQLTodayLibrary.sqltodayEntities())
            { 
                foreach (var x in ctx.QEMPs)
                {
                    Console.WriteLine(x);
                    x.EMPFNAME = x.EMPFNAME.ToUpper();
                }
                Console.WriteLine("********");
                foreach (var x in ctx.QEMPs)
                {
                    Console.WriteLine(x);
                   
                }
                QEMP newitem = new QEMP();
                newitem.EMPNO = 18;
                newitem.EMPFNAME = "Brian";
                newitem.DEPTNAME = "Books";
                newitem.EMPSALARY = 20;
                newitem.BOSSNO = 1;
               // ctx.QEMPs.Add(newitem);
                ctx.SaveChanges();
            }
        }
    }
}
