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
    
    public partial class QSALE
    {
        public int SALENO { get; set; }
        public int SALEQTY { get; set; }
        public string ITEMNAME { get; set; }
        public string DEPTNAME { get; set; }
    
        public virtual QDEPT QDEPT { get; set; }
        public virtual QITEM QITEM { get; set; }
    }
}