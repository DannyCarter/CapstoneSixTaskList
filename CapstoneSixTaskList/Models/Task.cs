//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapstoneSixTaskList.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
        public int TaskID { get; set; }
        public int Owner { get; set; }
    
        public virtual User User { get; set; }
    }
}