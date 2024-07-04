using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class ApplcationDBContext : DbContext
    {
        public ApplcationDBContext(DbContextOptions<ApplcationDBContext> options) : base(options) {}

        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        // public DbSet<Fee> Fees { get; set; }
        // public DbSet<User> Users { get; set; }
        // public DbSet<FeePayment> FeePayments { get; set; }
        // public DbSet<Guardian> Guardians { get; set; }
        // public DbSet<Stage> Stages { get; set; }
        // public DbSet<Student> Students { get; set; }
        // public DbSet<StudentClass> StudentClasses { get; set; }
        // public DbSet<TeacherStudentSubject> TeacherStudentSubjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // // Configure primary keys
            // // modelBuilder.Entity<FeepaymentStudentGardian>().HasKey(fsg => new { fsg.StudentID, fsg.GuardianID, fsg.FeePaymentID });
            // modelBuilder.Entity<ManagerTeacher>().HasKey(mt => new { mt.ManagerID, mt.TeacherID });
            // modelBuilder.Entity<TeacherStudentSubject>().HasKey(tss => new { tss.StudentID, tss.TeacherID, tss.SubjectID });
            // modelBuilder.Entity<StudentClass>().HasKey(sc => new { sc.StudentClassID, sc.ClassID });

            // Configure relationships
            // modelBuilder.Entity<Class>()
            //     .HasMany(c => c.Divisions)
            //     .WithOne(d => d.Class)
            //     .HasForeignKey(d => d.ClassID);

            // modelBuilder.Entity<Class>()
            //     .HasMany(c => c.Subjects)
            //     .WithOne(s => s.Class)
            //     .HasForeignKey(s => s.SubjClassID);

            // modelBuilder.Entity<Class>()
            //     .HasMany(c => c.Fees)
            //     .WithOne()
            //     .HasForeignKey(f => f.FeeID);

            // modelBuilder.Entity<Division>()
            //     .HasMany(d => d.Students)
            //     .WithOne(s => s.Division)
            //     .HasForeignKey(s => s.StudentDivisionID);

            // modelBuilder.Entity<Guardian>()
            //     .HasMany(g => g.Students)
            //     .WithOne(s => s.Guardian)
            //     .HasForeignKey(s => s.StudentGuardianID);

            // modelBuilder.Entity<Guardian>()
            //     .HasMany(g => g.FeepaymentStudentGardian)
            //     .WithOne(fsg => fsg.Guardian)
            //     .HasForeignKey(fsg => fsg.GuardianID);

            modelBuilder.Entity<Manager>()
                .HasOne<School>(m => m.School)
                .WithOne(s => s.Managers)
                .HasForeignKey<School>(m => m.ManagerID);

            // modelBuilder.Entity<Manager>()
            //     .HasMany(m => m.ManagerTeachers)
            //     .WithOne(mt => mt.Manager)
            //     .HasForeignKey(mt => mt.ManagerID);

            modelBuilder.Entity<School>()
                .HasMany<Class>(s => s.Classes)
                .WithOne(Class=>Class.School)
                .HasForeignKey(C => C.SchoolID);

            // modelBuilder.Entity<Stage>()
            //     .HasOne(s => s.Year)
            //     .WithMany()
            //     .HasForeignKey(s => s.StageYearID);

            // modelBuilder.Entity<Student>()
            //     .HasMany(s => s.TeacherStudentSubjects)
            //     .WithOne(tss => tss.Student)
            //     .HasForeignKey(tss => tss.StudentID);

            // modelBuilder.Entity<Student>()
            //     .HasMany(s => s.StudentClasses)
            //     .WithOne(sc => sc.Student)
            //     .HasForeignKey(sc => sc.StudentClassID);

            // modelBuilder.Entity<Student>()
            //     .HasMany(s => s.FeepaymentStudentGardian)
            //     .WithOne(fsg => fsg.Student)
            //     .HasForeignKey(fsg => fsg.StudentID);

            // modelBuilder.Entity<Subject>()
            //     .HasMany(s => s.TeacherStudentSubjects)
            //     .WithOne(tss => tss.Subject)
            //     .HasForeignKey(tss => tss.SubjectID);

            // modelBuilder.Entity<Teacher>()
            //     .HasMany(t => t.TeacherStudentSubjects)
            //     .WithOne(tss => tss.Teacher)
            //     .HasForeignKey(tss => tss.TeacherID);

            // modelBuilder.Entity<Teacher>()
            //     .HasMany(t => t.ManagerTeachers)
            //     .WithOne(mt => mt.Teacher)
            //     .HasForeignKey(mt => mt.TeacherID);

            modelBuilder.Entity<Manager>()
                .HasMany<Teacher>(M => M.Teachers)
                .WithOne(T => T.Manager)
                .HasForeignKey(T => T.TeacherID)
                .OnDelete(DeleteBehavior.Cascade);

        //     modelBuilder.Entity<User>()
        //         .HasMany(u => u.Students)
        //         .WithOne(s => s.User)
        //         .HasForeignKey(s => s.StudentUserID);

        //     modelBuilder.Entity<User>()
        //         .HasMany(u => u.Guardians)
        //         .WithOne(g => g.User)
        //         .HasForeignKey(g => g.UserID);

        //     // Configure property attributes
        //     modelBuilder.Entity<Class>()
        //         .Property(c => c.ClassName)
        //         .IsRequired();

        //     modelBuilder.Entity<Fee>()
        //         .Property(f => f.FeeName)
        //         .IsRequired();

        //     modelBuilder.Entity<User>()
        //         .Property(u => u.FirstName)
        //         .IsRequired();

        //     modelBuilder.Entity<Student>()
        //         .Property(s => s.FirstName)
        //         .IsRequired();

        //     modelBuilder.Entity<Teacher>()
        //         .Property(t => t.FirstName)
        //         .IsRequired();

        //     // Configure cascade delete behavior to avoid cycles or multiple cascade paths
        //     modelBuilder.Entity<Student>()
        //         .HasMany(s => s.StudentClasses)
        //         .WithOne(sc => sc.Student)
        //         .HasForeignKey(sc => sc.StudentClassID)
        //         .OnDelete(DeleteBehavior.Restrict);

        //     modelBuilder.Entity<User>()
        //         .HasMany(u => u.Students)
        //         .WithOne(s => s.User)
        //         .HasForeignKey(s => s.StudentUserID)
        //         .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
