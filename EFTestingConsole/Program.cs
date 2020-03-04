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

    public static class contextextender
    {
 
        static public void 
            viewentry<T>(this System.Data.Entity.Infrastructure.DbEntityEntry<T> e) 
            where T: class

        {
            Console.Write($"entry:{e.State,-11} [");



            switch (e.State)
            {
                default:
                    Console.Write($" Invalid State for this entry ");
                    break;
                case (System.Data.Entity.EntityState.Detached):
                    
                        Console.Write($" Not Tracking Properties for detached entry ");
                   
                    break;
                case (System.Data.Entity.EntityState.Modified):
                
                    foreach (var c in e.OriginalValues.PropertyNames)
                    {
                        Console.Write($"{c}:{e.OriginalValues[c]}->{e.CurrentValues[c]} ");
                    }
                    break;
                case (System.Data.Entity.EntityState.Unchanged):
                    foreach (var c in e.OriginalValues.PropertyNames)
                    {
                        Console.Write($"{c}:{e.OriginalValues[c]} ");
                    }
                    break;
                case (System.Data.Entity.EntityState.Added):
                    foreach (var c in e.CurrentValues.PropertyNames)
                    {
                        Console.Write($"{c}:NA->{e.CurrentValues[c]} ");
                    }

                    break;
                case (System.Data.Entity.EntityState.Deleted):
                    foreach (var c in e.OriginalValues.PropertyNames)
                    {
                        Console.Write($"{c}:{e.OriginalValues[c]}->NA ");
                    }

                    break;

            }

            Console.WriteLine($"]");
        }
        static public void viewctx(this sqltodayEntities ctx)
        {
            Console.WriteLine("******Context Tracing View **********");
            Console.WriteLine($"Entry Count: {ctx.ChangeTracker.Entries().Count()}");
            
            foreach(var e in ctx.ChangeTracker.Entries() )
            {
                Console.Write($"entry:{e.State,-11} [");



                switch (e.State)
                {
                    default:
                        Console.Write($" Invalid State for this entry ");
                        break;
                    case (System.Data.Entity.EntityState.Detached):

                        Console.Write($" Not Tracking Properties for detached entry ");

                        break;
                    case (System.Data.Entity.EntityState.Modified):

                        foreach (var c in e.OriginalValues.PropertyNames)
                        {
                            Console.Write($"{c}:{e.OriginalValues[c]}->{e.CurrentValues[c]} ");
                        }
                        break;
                    case (System.Data.Entity.EntityState.Unchanged):
                        foreach (var c in e.OriginalValues.PropertyNames)
                        {
                            Console.Write($"{c}:{e.OriginalValues[c]} ");
                        }
                        break;
                    case (System.Data.Entity.EntityState.Added):
                        foreach (var c in e.CurrentValues.PropertyNames)
                        {
                            Console.Write($"{c}:NA->{e.CurrentValues[c]} ");
                        }

                        break;
                    case (System.Data.Entity.EntityState.Deleted):
                        foreach (var c in e.OriginalValues.PropertyNames)
                        {
                            Console.Write($"{c}:{e.OriginalValues[c]}->NA ");
                        }

                        break;

                }

                Console.WriteLine($"]");

            }
            Console.WriteLine("-------------------------------------");
        }
    }
    class Program
    {
        
       

        static void Main(string[] args)
        {
            
            using (sqltodayEntities ctx = new sqltodayEntities())
            {
                ctx.viewctx();
                ctx.Database.Log = Console.WriteLine;
                QEMP newemp = new QEMP() { DEPTNAME="Books", EMPFNAME="Carol", EMPSALARY=25000, BOSSNO=3, EMPNO = ctx.QEMPs.Max(x=>x.EMPNO)+1 };
                ctx.viewctx();
                QEMP stub = new QEMP() { EMPNO = 13 };

                var s = ctx.Entry(stub);
               // s.State = System.Data.Entity.EntityState.Deleted;
                Console.WriteLine("Here i am");
                s.viewentry();
                Console.WriteLine("There I was");
                ctx.viewctx();

                var L = ctx.QEMPs.ToList();
                ctx.QEMPs.Add(newemp);
                ctx.viewctx();
            }
 
        }
    }
}
