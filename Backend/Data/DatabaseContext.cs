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
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

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
        // public DbSet<Fee> Fees { get; set; }
        // public DbSet<User> Users { get; set; }
        // public DbSet<FeePayment> FeePayments { get; set; }
        // public DbSet<Guardian> Guardians { get; set; }
        // public DbSet<Stage> Stages { get; set; }
        // public DbSet<StudentClass> StudentClasses { get; set; }
        // public DbSet<TeacherStudentSubject> TeacherStudentSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherStudent>().HasKey(TS => new { TS.StudentID, TS.TeacherID });
            modelBuilder.Entity<SubjectStudent>().HasKey(SS=> new{SS.SubjectID,SS.StudentID});

            modelBuilder.Entity<Manager>()
                .HasOne<School>(m => m.School)
                .WithOne(s => s.Manager)
                .HasForeignKey<School>(m => m.ManagerID);

            // many to many relationship for Teachars and Students
            modelBuilder.Entity<TeacherStudent>()
            .HasOne<Student>(S=>S.Student)
            .WithMany(TS=>TS.TeacherStudents)
            .HasForeignKey(S=>S.StudentID)
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeacherStudent>()
            .HasOne<Teacher>(T=>T.Teacher)
            .WithMany(TS=>TS.TeacherStudents)
            .HasForeignKey(T=>T.TeacherID)
            .OnDelete(DeleteBehavior.Restrict);

            // one to many for School and Class
            modelBuilder.Entity<School>()
                .HasMany<Class>(s => s.Classes)
                .WithOne(Class=>Class.School)
                .HasForeignKey(C => C.SchoolID)
                .OnDelete(DeleteBehavior.Restrict);

                //one to many for Managers and Teachers
            modelBuilder.Entity<Manager>()
                .HasMany<Teacher>(T => T.Teachers)
                .WithOne(M => M.Manager)
                .HasForeignKey(T => T.TeacherID)
                .OnDelete(DeleteBehavior.Restrict);//Restrict for I delete the Manager the Teacher is not deleted

            // many to many relationship for Subjects and Students
            modelBuilder.Entity<SubjectStudent>()
            .HasOne<Subject>(S => S.Subject)
            .WithMany(SS=>SS.SubjectStudents)
            .HasForeignKey(S => S.SubjectID)
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<SubjectStudent>()
            .HasOne<Student>(S=>S.Student)
            .WithMany(SS=>SS.SubjectStudents)
            .HasForeignKey(S=>S.StudentID)
            .OnDelete(DeleteBehavior.Restrict);

            // One to many relationship for Class and Students
            modelBuilder.Entity<Class>()
            .HasMany<Student>(S=>S.Students)
            .WithOne(C=>C.Class)
            .HasForeignKey(S=>S.StudentID)
            .OnDelete(DeleteBehavior.Restrict);

            // One to many relationship for Class and Subject
            modelBuilder.Entity<Class>()
            .HasMany<Subject>(S=>S.Subjects)
            .WithOne(C=>C.Class)
            .HasForeignKey(S=>S.SubjectID)
            .OnDelete(DeleteBehavior.Restrict);

            // One to many relationship for Class and Division
            modelBuilder.Entity<Class>()
            .HasMany<Division>(D=>D.Divisions)
            .WithOne(C=>C.Class)
            .HasForeignKey(D=>D.DivisionID)
            .OnDelete(DeleteBehavior.Restrict);

            // One to many relationship for Division and Student
            modelBuilder.Entity<Division>()
            .HasMany<Student>(S=>S.Students)
            .WithOne(D=>D.Division)
            .HasForeignKey(S=>S.StudentID)
            .OnDelete(DeleteBehavior.Restrict);

            // One to one relationship for class and Teacher
            modelBuilder.Entity<Class>()
                .HasOne<Teacher>(C => C.Teacher)
                .WithOne(T => T.Class)
                .HasForeignKey<Teacher>(C => C.ClassID)
                .OnDelete(DeleteBehavior.Restrict);
            
            // One to many relationship for class and Teacher
            modelBuilder.Entity<Guardian>()
            .HasMany<Student>(S=>S.Students)
            .WithOne(G=>G.Guardian)
            .HasForeignKey(S=>S.StudentID)
            .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
