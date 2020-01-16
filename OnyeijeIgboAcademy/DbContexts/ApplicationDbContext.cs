using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnyeijeIgboAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.DbContexts
{
 
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<ONJQuestions> ONJQuestions { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
        public virtual DbSet<QuestionChoices> QuestionChoices { get; set; }
        public virtual DbSet<StAssignment> StAssignment { get; set; }
        public virtual DbSet<StAssignmentAnswer> StAssignmentAnswer { get; set; }
        public virtual DbSet<StCourseEnrollment> StCourseEnrollment { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentTopic> StudentTopic { get; set; }
        public virtual DbSet<TopicFiles> TopicFiles { get; set; }

        public virtual DbSet<Instructor> Instructor { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<InstructorCourse> InstructorCourse { get; set; }

        public virtual DbSet<Blog> Blog { get; set; }

        public virtual DbSet<ExamSetUp> ExamSetUp { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual  DbSet<DifficultyLevels> DifficultyLevels { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Transactions> Transaction { get; set; }
        public virtual DbSet<StudentModules> StudentModules { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var foreignKey in builder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.SeedDifficultyLevel();
            builder.Entity<Message>()
                .HasOne<ApplicationUser>(a => a.Sender)
                .WithMany(d => d.Messages)
                .HasForeignKey(d => d.UserID);
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            AddTimestamps();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            AddTimestamps();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext != null)
            {
                var authenticatedUserName = httpContext.User.Identity.Name;

                // If it returns null, even when the user was authenticated, you may try to get the value of a specific claim 
                // var authenticatedUserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                foreach (var entity in entities)
                {
                    if (entity.State == EntityState.Added)
                    {
                        ((BaseEntity)entity.Entity).DateCreated = DateTime.UtcNow;
                        ((BaseEntity)entity.Entity).UserCreated = authenticatedUserName;
                    }

                 ((BaseEntity)entity.Entity).DateModified = DateTime.UtcNow;
                    ((BaseEntity)entity.Entity).UserModified = authenticatedUserName;
                }
            }
            //var currentUsername = !string.IsNullOrEmpty(System.Web.HttpContext.Current?.User?.Identity?.Name)
            //    ? HttpContext.User.Identity.Name
            //    : "Anonymous";


        }
    }
}


