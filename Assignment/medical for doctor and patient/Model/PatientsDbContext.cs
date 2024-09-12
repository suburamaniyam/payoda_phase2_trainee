using Microsoft.EntityFrameworkCore;

namespace MedicineOfDoctorPatients.Model
{
    public class PatientsDbContext:DbContext
    {
        public DbSet<Patients> Patientcs { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public PatientsDbContext(DbContextOptions<PatientsDbContext> options) : base(options)
        {

        }

    }
}
