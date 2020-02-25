using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLTodayLibrary
{
    public partial class QEMP
    {
        public override string ToString()
        {
            return $"QEMP> empno: {EMPNO,-5} name:{EMPFNAME,-20} salary:{EMPSALARY,-10}";
        }
    }
}
