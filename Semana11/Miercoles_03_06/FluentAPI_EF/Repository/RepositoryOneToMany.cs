using FluentAPI_EF.Data;
using FluentAPI_EF.Models.OneTOMany;
using Microsoft.EntityFrameworkCore;

namespace FluentAPI_EF.Repository
{
    public class RepositoryOneToMany
    {
        private readonly AppDbContext _context;
        public RepositoryOneToMany(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Doctor>> GetDoctorsAsync() =>
            await _context.Doctors.Include(x => x.Patients).ToListAsync();

        public async Task<List<Patient>> GetPatientAsync() =>
            await _context.Patients.Include(x => x.Doctor).ToListAsync();

        public async Task AddDoctorAsync(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();
        }

        public async Task AddPatientAsync(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
        }
    }
}
