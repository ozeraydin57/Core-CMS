using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Tier.Entities.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CityCode { get; set; }
        public int CountyCode { get; set; }
        public string MapsUrl { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
    }
}
