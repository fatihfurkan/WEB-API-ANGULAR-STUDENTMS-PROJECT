//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS.Database.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        public System.Guid ID { get; set; }
        public Nullable<int> IDNUMBER { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string EMAIL { get; set; }
        public string PASSWORD { get; set; }
        public string ADDRESS { get; set; }
        public string PHONE { get; set; }
        public Nullable<System.DateTime> CREATIONDATE { get; set; }
        public Nullable<System.Guid> ROLEREF { get; set; }
    }
}