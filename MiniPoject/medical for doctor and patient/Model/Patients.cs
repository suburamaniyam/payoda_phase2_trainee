using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicineOfDoctorPatients.Model
{
    public class Patients
    {
        [Key]
        public int Patid { get; set; }
        public string? Patname { get; set; }
        public int Docid { get; set; }
        //navigator Patients Appointments
        [ForeignKey("Docid")]
        public Doctor? Doctors { get; set; }
    }
}
