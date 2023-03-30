using System;
using System.Collections.Generic;

namespace SchoolManagement.MVC.Data;

public partial class Department
{
    public int DeptId { get; set; }

    public string? DeptName { get; set; }

    public string? DeptDesc { get; set; }

    public string? DeptLocation { get; set; }

    public int? DeptManager { get; set; }

    public DateTime? ManagerHiredate { get; set; }

    public virtual Instructor? DeptManagerNavigation { get; set; }

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
