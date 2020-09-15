using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_core_open_xml.Models
{
    public class Word
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PlaceofBirth { get; set; }
        public DateTime DateofBirth { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int? PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Nationality { get; set; }
        public string ProfessionalSummary { get; set; }
    }
}
