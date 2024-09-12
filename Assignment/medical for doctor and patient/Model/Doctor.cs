using System.ComponentModel.DataAnnotations;

namespace MedicineOfDoctorPatients.Model
{
    public class Doctor
    {

        [Key]
        public int Docid { get; set; }
        public string? DocName { get; set; }
        public string? DocSpecialist { get; set; }
        public ICollection<Patients>? Patient { get; set; }

    }
}
