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
    
    public partial class TEACHER_COURSE_DETAIL
    {
        public System.Guid ID { get; set; }
        public Nullable<System.Guid> COURSEID { get; set; }
        public Nullable<System.Guid> USERID { get; set; }
        public string CONTENTDETAIL { get; set; }
        public string LINK { get; set; }
    }
}