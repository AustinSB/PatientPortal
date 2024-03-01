using MVCPortal.Models;

namespace MVCPortal.Data
{
    public class PatientData : IPatientData
    {
        private readonly ISQLDataAccess _db;

        public PatientData(ISQLDataAccess db)
        {
            _db = db;
        }

        public async Task<IEnumerable<PatientModel>> GetPatient(int id)
        {
            //var sql = $"SELECT * FROM patient WHERE id = {id}";
            var sql = $"SELECT * FROM patient WHERE id = {id}";
            var test = await _db.GetData<PatientModel>(sql);

            //return (IEnumerable<PatientModel>)test;
            return test;
        }
    }
}
