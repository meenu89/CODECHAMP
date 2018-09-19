using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Context:DbContext
    {
        public Context():base(@"server=OXFORDN09\SQLEXPRESS;uid=sa;pwd=info@123!;database=CodeChamp")
        {

        }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Training>().HasRequired<Trainer>(t => t.Trainer).WithMany(s => s.Trainings).HasForeignKey<int>(t => t.TrainingId);
            //modelBuilder.Entity<Feedback>().HasRequired<Training>(t => t.Training).WithMany(s => s.Feedbacks).HasForeignKey<int>(t => t.FeedbackId);

        }

    }
}