using Microsoft.EntityFrameworkCore;

namespace carpoolapp.Models {
    public class Context : DbContext {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Travel> Travels { get; set; }
        public virtual DbSet<TravelEmployees> TravelEmployees { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder options) => options.UseSqlite ("Data Source=carpool.db");

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            SeedData (modelBuilder);
        }

        void SeedData (ModelBuilder modelBuilder) {


            modelBuilder.Entity<Travel>(entity => {
                entity.HasMany(e => e.TravelEmployees)
                .WithOne(t => t.Travel)
                .HasForeignKey(t => t.TravelId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TravelEmployees>(entity =>
            {
                entity.HasKey(e => new { e.TravelId, e.EmployeeId });
            });

            modelBuilder.Entity<Car> ().HasData (Seed.Cars);
            modelBuilder.Entity<Employee> ().HasData (Seed.Employees);
            modelBuilder.Entity<Travel> ().HasData (Seed.Travels);
            modelBuilder.Entity<TravelEmployees> ().HasData (Seed.TravelEmployees);
        }

    }
}