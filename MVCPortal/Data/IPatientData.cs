using MVCPortal.Models;

namespace MVCPortal.Data
{
    public interface IPatientData
    {
        Task<IEnumerable<PatientModel>> GetPatient(int id);
    }
}