//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
        public Nullable<int> TeacherId { get; set; }
    
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
