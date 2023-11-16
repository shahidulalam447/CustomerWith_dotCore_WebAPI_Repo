using CIMS.DAL.Interface;
using CIMS.Models;
using CIMS.Repo.Interfaces;

namespace CIMS.Repo.Implementation
{
    public class CountryRepo : ICountryRepo
    {
        private readonly IGenericRepo<Country> _cntryRepo;
        public CountryRepo(IGenericRepo<Country> cntryRepo)
        {
            _cntryRepo = cntryRepo;
        }
        public IEnumerable<Country> GetCountries()
        {
            try
            {
                return _cntryRepo.FindAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }                                                                                          
        }
        public void SaveCountry(Country country)
        {
            try
            {
                _cntryRepo.Create(country);
                _cntryRepo.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
