using CFLAG.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace CFLAG.FlagService
{
    public class CountryFlagService
    {
        public List<CountryFlag> Flags = new List<CountryFlag>
        {
            new CountryFlag { ID = 1, CountryName="Isle of Man"},
            new CountryFlag { ID = 2, CountryName="United Kingdom"},
            new CountryFlag { ID = 3, CountryName="United States of America"},
            new CountryFlag { ID = 4, CountryName="France"},
            new CountryFlag { ID = 5, CountryName="Portugal"},
            new CountryFlag { ID = 6, CountryName="Australia"},
            new CountryFlag { ID = 7, CountryName="Sweden"},
            new CountryFlag { ID = 8, CountryName="Nigeria"},
            new CountryFlag { ID = 9, CountryName="Germany"},
            new CountryFlag { ID = 10, CountryName="Belgium"},
        };

        public List<CountryFlag> MergeFlags(string url, List<CountryFlag> countryFlags)
        {
            string urlConcat = url;

            try
            {
                for (int i = 0; i < countryFlags.Count; i++)
                {
                    urlConcat = url + countryFlags[i].CountryName + "?fullText=true";
                    string response = APIService.GET(urlConcat);

                    
                    JArray root = JArray.Parse(response);

                    var flags = root[0]["flags"].ToObject<FlagModel>();

                    countryFlags[i].ImageUrl = flags.png;
                                       
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            return countryFlags;
        }

        public object GetCountryDetails(string url)
        {
            try
            {
                CountryDetails countryDetails = new CountryDetails();
                string response = APIService.GET(url);
                if (!string.IsNullOrEmpty(response))
                {
                    JArray root = JArray.Parse(response);

                    var capital = root[0]["capital"][0];
                    CountryNameModel name = root[0]["name"].ToObject<CountryNameModel>();
                    var population = root[0]["population"];
                    var currencies = root[0]["currencies"].ToObject<Currencies>();

                    countryDetails.Capital = capital.ToString();
                    countryDetails.Name = name.common;
                    countryDetails.Population = population.ToString();
                    if (countryDetails != null)
                    {
                        return countryDetails;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
