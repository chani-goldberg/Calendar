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
    
    public partial class LinkParameter
    {
        public int ParameterId { get; set; }
        public string ParameterName { get; set; }
        public int KeyWordId { get; set; }
        public int PositionWord { get; set; }
    
        public virtual KeyWord KeyWord { get; set; }
    }
}
