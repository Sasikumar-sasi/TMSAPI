using Microsoft.EntityFrameworkCore;
using TMSClient.Models;

namespace TMSAPI.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> dbConOptions) : base(dbConOptions)
        {

        }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Trainee> trainees { get; set; }
        public DbSet<Trainer> trainers { get; set; }
        public DbSet<HR> hr { get; set; }
        public DbSet<Batch> batch { get; set; }
        public DbSet<TrainerManager> trainersManager { get; set; }
        public DbSet<Assessment> assessments { get; set; }
        public DbSet<Answer> answers { get; set; }
    }
}
