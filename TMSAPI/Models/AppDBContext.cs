using Microsoft.EntityFrameworkCore;
using TMSClient.Models;
using TMSAPI.Models;

namespace TMSAPI.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> dbConOptions) : base(dbConOptions)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Score>()
        //        .HasOne(tr=>tr.Trainee)
        //        .WithMany(sc=>sc.sc)
        //}

        public DbSet<Admin> admins { get; set; }
        public DbSet<Trainee> trainees { get; set; }
        public DbSet<Trainer> trainers { get; set; }
        public DbSet<HR> hr { get; set; }
        public DbSet<Batch> batch { get; set; }
        public DbSet<TrainerManager> trainersManager { get; set; }
        public DbSet<Assessment> assessments { get; set; }
        public DbSet<Answer> answers { get; set; }
        public DbSet<Score> Score { get; set; }
    }
}
