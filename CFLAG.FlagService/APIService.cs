using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CFLAG.FlagService
{
    public static class APIService
    {
        public static string GET(string url)
        {
            try
            {
                string response;
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add(HttpRequestHeader.Accept, "application/json");
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    
                  
                    response = client.DownloadString(url);
                   
                    return response;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
