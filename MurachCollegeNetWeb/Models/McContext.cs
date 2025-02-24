using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MurachCollegeNetWeb.Models;

public partial class McContext : DbContext
{


    public McContext(DbContextOptions<McContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<Tuition> Tuitions { get; set; }
}
