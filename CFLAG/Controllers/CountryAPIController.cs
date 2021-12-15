using CFLAG.Business;
using CFLAG.FlagService;
using CFLAG.Model;
using CFLAG.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace CFLAG.Controllers
{
    public class CountryAPIController : ApiController
    {
        private readonly CountryFlagBusiness _countryFlag;
        private readonly CountryFlagService _cFlag;

        public CountryAPIController()
        {
            _countryFlag = new CountryFlagBusiness();
            _cFlag = new CountryFlagService();
        }
       
        [HttpGet, Route("api/flag")]
        public IHttpActionResult GetCountryFlag()
        {
            List<CountryFlag> result;
            try
            {
                var cflag = _countryFlag.GetCountry();
                string url = System.Configuration.ConfigurationManager.AppSettings["GetCountryDetails"];

                result = _cFlag.MergeFlags(url, cflag.ToList());                
            }
            catch(Exception ex)
            {
                return Ok(new
                {
                    success = true,
                    message = ex.Message
                });
            }
            
            return Ok(new
            {
                success = true,
                message = "success",
                CountryFlag = result
            });
        }

        [HttpGet, Route("api/countrydetails/country/{country}")]
        public IHttpActionResult GetCountryDetails(string country)
        {
            string url = System.Configuration.ConfigurationManager.AppSettings["GetCountryDetails"];
            url = url + country;

            var result = _cFlag.GetCountryDetails(url);

            return Ok(new
            {
                success = true,
                message = "success",
                CountryDetails = result
            });
        }
    }
}