//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MyMemo
    {
        public int MyMemoId { get; set; }
        public int MemoId { get; set; }
        public int UserId { get; set; }
        public System.TimeSpan AdvanceAlertTime { get; set; }
        public string AlertName { get; set; }
    
        public virtual BuiltInMemo BuiltInMemo { get; set; }
        public virtual User User { get; set; }
    }
}
