using System;
namespace Module_IV_API
{
	public class Donor
	{
 
        public string MedicalRecordNumber { get; set; }
        public string FirstName { get; set; }
        public string BloodType { get; set; }
        public string LastName { get; set; }


        public Donor()
        {
        }

        public Donor(string medicalRecordNumber, string firstName, string bloodType, string lastName)
        {
            this.MedicalRecordNumber = medicalRecordNumber;
            this.FirstName = firstName;
            this.BloodType = bloodType;
            this.LastName = lastName;
        }
    }
    }
	


