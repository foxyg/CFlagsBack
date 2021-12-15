using CFLAG.FlagService;
using CFLAG.Model;
using CFLAG.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFLAG.Business
{
    public class CountryFlagBusiness
    {
        private readonly CountryFlagRepository _countryFlag;
        private readonly CountryFlagService cf = new CountryFlagService();
        public CountryFlagBusiness()
        {
            _countryFlag = new CountryFlagRepository(cf);
        }
        public ICollection<CountryFlag> GetCountry()
        {
            return _countryFlag.GetCountry();
        }
    }
}
