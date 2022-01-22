using Care4Pets.Api.Bol;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care4Pets.Api.Dal
{
    public class Care4PetsDbContext : DbContext
    {
        public Care4PetsDbContext() : base("name=Care4PetsDbConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Care4PetsDbContext>());
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<AdministrationWay> AdministrationWays { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Feeding> Feedings { get; set; }
        public DbSet<FoodPresentation> FoodPresentations { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MedicationPresentation> MedicationPresentations { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Professional> Professionals { get; set; }
        public DbSet<ReminderType> RemiderTypes { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<RepeatType> RepeatTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
