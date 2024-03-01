using MVCPortal.Models;

namespace MVCPortal.Data
{
    public interface ISQLDataAccess
    {
        public Task<IEnumerable<T>> GetData<T>(string sql);
    }
}