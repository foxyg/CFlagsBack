using CFLAG.Model;
using CFLAG.Repository.Interface;
using System.Collections.Generic;
using CFLAG.FlagService;

namespace CFLAG.Repository
{
    public class CountryFlagRepository : ICountryFlagRepository
    {
        private readonly CountryFlagService _cf = new CountryFlagService();

        public CountryFlagRepository(CountryFlagService cf)
        {
            _cf = cf;
        }
        public ICollection<CountryFlag> GetCountry()
        {
            return _cf.Flags;
        }
    }
}
