using CFLAG.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFLAG.Repository.Interface
{
    public interface ICountryFlagRepository
    {
        ICollection<CountryFlag> GetCountry();
    }
}
