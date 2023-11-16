using CIMS.Models;

namespace CIMS.Repo.Interfaces
{
    public interface ICountryRepo
    {
        IEnumerable<Country> GetCountries();
        void SaveCountry(Country country);
    }
}
