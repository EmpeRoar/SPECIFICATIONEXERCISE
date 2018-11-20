using System;
using System.Collections.Generic;
using System.Text;

namespace BETTERCOMBININGSPECIFICATIONS
{
    public class Person
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public BrainLevel BrainLevel { get; set; }

    }

    public enum BrainLevel
    {
        bogo,
        sakto,
        bright
    }
}
