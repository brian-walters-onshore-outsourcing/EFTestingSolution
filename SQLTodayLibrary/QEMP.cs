//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQLTodayLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class QEMP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QEMP()
        {
            this.QDEPTs = new HashSet<QDEPT>();
            this.Employees = new HashSet<QEMP>();
        }
    
        public int EMPNO { get; set; }
        public string EMPFNAME { get; set; }
        public int EMPSALARY { get; set; }
        public string DEPTNAME { get; set; }
        public Nullable<int> BOSSNO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QDEPT> QDEPTs { get; set; }
        public virtual QDEPT QDEPT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QEMP> Employees { get; set; }
        public virtual QEMP Boss { get; set; }
       
    }
}
