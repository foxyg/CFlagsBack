using System;
using System.Collections.Generic;
using System.Text;

namespace CFLAG.Model
{
    public class FlagModel
    {
        public string png { get; set; }
        public string svg { get; set; }
    }

    public class Flags
    {
        public FlagModel flags { get; set; }
    }

    public class CountryNameModel
    {
        public string common { get; set; }
        public string official { get; set; }
        
    }
    public class Currencies
    {
        public string name { get; set; }
    }
    
    //public class Capitals
    //{
    //    public List<Capital> capital { get; set; }
    //}

    public class CountryDetails
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Population { get; set; }
        public string Currencies { get; set; }
    }
    
}
