//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupsTeacher
    {
        public int Id { get; set; }
        public Nullable<int> TeacherID { get; set; }
        public Nullable<int> GroupID { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
