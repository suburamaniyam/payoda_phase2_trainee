using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicineOfDoctorPatients.Model;

namespace MedicineOfDoctorPatients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly PatientsDbContext _context;

        public PatientsController(PatientsDbContext context)
        {
            _context = context;
        }

        // GET: api/Patients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patients>>> GetPatientcs()
        {
            return await _context.Patientcs.ToListAsync();
        }

        // GET: api/Patients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Patients>> GetPatients(int id)
        {
            var patients = await _context.Patientcs.FindAsync(id);

            if (patients == null)
            {
                return NotFound();
            }

            return patients;
        }

        // PUT: api/Patients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatients(int id, Patients patients)
        {
            if (id != patients.Patid)
            {
                return BadRequest();
            }

            _context.Entry(patients).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Patients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Patients>> PostPatients(Patients patients)
        {
            _context.Patientcs.Add(patients);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatients", new { id = patients.Patid }, patients);
        }

        // DELETE: api/Patients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatients(int id)
        {
            var patients = await _context.Patientcs.FindAsync(id);
            if (patients == null)
            {
                return NotFound();
            }

            _context.Patientcs.Remove(patients);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatientsExists(int id)
        {
            return _context.Patientcs.Any(e => e.Patid == id);
        }
    }
}
