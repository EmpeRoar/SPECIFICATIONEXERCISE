using System;
using System.Collections.Generic;
using System.Text;

namespace COMBININGSPECIFICATIONS.Models
{
    public class Person
    {
        public int Id { get; set; }
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
