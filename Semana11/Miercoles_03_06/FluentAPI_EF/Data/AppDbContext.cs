using FluentAPI_EF.Models.OneTOMany;
using FluentAPI_EF.Models.OneTOOne;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI_EF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        //One To One
        public DbSet<CarCompany> CarCompanies { get; set; }
        public DbSet<CarModel> CarModels { get; set; }

        //One To Many
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One TO One
            modelBuilder.Entity<CarCompany>()
                .HasOne(x => x.CarModel)
                .WithOne(r => r.CarCompany)
                .HasForeignKey<CarModel>(z => z.CarCompanyID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            //One To Many
            modelBuilder.Entity<Doctor>()
                .HasMany(x=>x.Patients)
                .WithOne(p=>p.Doctor)
                .HasForeignKey(x=>x.DoctorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
