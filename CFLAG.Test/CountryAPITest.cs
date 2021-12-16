using System;
using System.Collections.Generic;
using CFLAG.FlagService;
using CFLAG.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CFLAG.Test
{
    [TestClass]
    public class CountryAPITest
    {

        CountryFlagService _cFlag = new CountryFlagService();
        
        [TestMethod]
        public void GetCountryFlag()
        {            
            string url = "https://restcountries.com/v3.1/name/";

            var testCountryFlag = _cFlag.MergeFlags(url, Flags);

            Assert.IsNotNull(testCountryFlag);
        }

        [TestMethod]
        public void GetCountryDetails()
        {
            string url = "https://restcountries.com/v3.1/name/";

            var testCountryDetails = _cFlag.GetCountryDetails(url);

            Assert.IsNotNull(testCountryDetails);
        }

        public List<CountryFlag> Flags = new List<CountryFlag>
        {
            new CountryFlag { ID = 1, CountryName="Isle of Man"},
            new CountryFlag { ID = 2, CountryName="United Kingdom"},
            new CountryFlag { ID = 3, CountryName="United States of America"},
            new CountryFlag { ID = 4, CountryName="France"},
            new CountryFlag { ID = 5, CountryName="Nigeria"},
            new CountryFlag { ID = 6, CountryName="Australia"},
        };
    }
}
