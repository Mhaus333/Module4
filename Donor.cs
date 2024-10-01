using System;
namespace Patient
{
    public class Donor
    {
        public Donor()
        { }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BloodType { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }

        public string GetAge()
        { return getAge(); }

        private string getAge()
        {
            if (Birthday == DateTime.MinValue)
            {
                return "Unknown";
            }
            return (DateTime.Now.Year - Birthday.Year).ToString();
        }
    }
}

