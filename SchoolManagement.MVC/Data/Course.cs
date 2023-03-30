using System;
using System.Collections.Generic;

namespace SchoolManagement.MVC.Data;

public partial class Course
{
    public int CrsId { get; set; }

    public string? CrsName { get; set; }

    public int? CrsDuration { get; set; }

    public int? TopId { get; set; }

    public virtual ICollection<InsCourse> InsCourses { get; } = new List<InsCourse>();

    public virtual ICollection<StudCourse> StudCourses { get; } = new List<StudCourse>();

    public virtual Topic? Top { get; set; }
}
