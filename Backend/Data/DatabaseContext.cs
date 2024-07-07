using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<SubjectStudent> SubjectStudents { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherStudent>().HasKey(TS => new { TS.StudentID, TS.TeacherID });
            modelBuilder.Entity<SubjectStudent>().HasKey(SS => new { SS.SubjectID, SS.StudentID });

            modelBuilder.Entity<School>()
                .HasOne<Manager>(m => m.Manager)
                .WithOne(s => s.School)
                .HasForeignKey<Manager>(m => m.SchoolID);

            // many to many relationship for Teachers and Students
            modelBuilder.Entity<TeacherStudent>()
                .HasOne<Student>(S => S.Student)
                .WithMany(TS => TS.TeacherStudents)
                .HasForeignKey(S => S.StudentID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeacherStudent>()
                .HasOne<Teacher>(T => T.Teacher)
                .WithMany(TS => TS.TeacherStudents)
                .HasForeignKey(T => T.TeacherID)
                .OnDelete(DeleteBehavior.Restrict);

            // one to many for School and Class
            modelBuilder.Entity<School>()
                .HasMany<Class>(s => s.Classes)
                .WithOne(Class => Class.School)
                .HasForeignKey(C => C.SchoolID)
                .OnDelete(DeleteBehavior.Restrict);

            // one to many for Managers and Teachers
            modelBuilder.Entity<Manager>()
                .HasMany<Teacher>(T => T.Teachers)
                .WithOne(M => M.Manager)
                .HasForeignKey(T => T.ManagerID)
                .OnDelete(DeleteBehavior.Restrict); // Restrict to prevent deletion of Teachers when Manager is deleted

            // many to many relationship for Subjects and Students
            modelBuilder.Entity<SubjectStudent>()
                .HasOne<Subject>(S => S.Subject)
                .WithMany(SS => SS.SubjectStudents)
                .HasForeignKey(S => S.SubjectID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<SubjectStudent>()
                .HasOne<Student>(S => S.Student)
                .WithMany(SS => SS.SubjectStudents)
                .HasForeignKey(S => S.StudentID)
                .OnDelete(DeleteBehavior.Restrict);

            // one to many relationship for Class and Subject
            modelBuilder.Entity<Class>()
                .HasMany<Subject>(S => S.Subjects)
                .WithOne(C => C.Class)
                .HasForeignKey(S => S.ClassID)
                .OnDelete(DeleteBehavior.Restrict);

            // one to many relationship for Class and Division
            modelBuilder.Entity<Class>()
                .HasMany<Division>(D => D.Divisions)
                .WithOne(C => C.Class)
                .HasForeignKey(D => D.ClassID)
                .OnDelete(DeleteBehavior.Restrict);

            // one to many relationship for Division and Student
            modelBuilder.Entity<Division>()
                .HasMany<Student>(S => S.Students)
                .WithOne(D => D.Division)
                .HasForeignKey(S => S.DivisionID)
                .OnDelete(DeleteBehavior.Restrict);

            // one to many relationship for Guardian and Students
            modelBuilder.Entity<Guardian>()
                .HasMany<Student>(S => S.Students)
                .WithOne(G => G.Guardian)
                .HasForeignKey(S => S.GuardianID)
                .OnDelete(DeleteBehavior.Cascade);
                
            //composite Atribute for Student and Name
            modelBuilder.Entity<Student>()
            .OwnsOne(s => s.Name);
        }
    }
}
