using System;

namespace Patient
{
    public class Patient
    {
        //properties
        public int MedicalRecordNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public DateTime Birthday { get; set; }
        public string BloodType { get; set; }
        public string SocialSecurity { get; set; }
        public double Hemoglobin { get; set; }
        public string Age
        {
            get { return getAge(); }
        }

        public void display()
        {
            Console.WriteLine("Patient Information:");
            Console.WriteLine($"Medical Record Number: {MedicalRecordNumber}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Birthday: {Birthday.ToShortDateString()}");
            Console.WriteLine($"Blood Type: {BloodType}");
            Console.WriteLine($"Social Secrutiy No.: {SocialSecurity}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Hemoglobin: {Hemoglobin}");

        }

        private string getAge()
        {
            if (Birthday == DateTime.MinValue)
            {
                return "Unknown";
            }
            return (DateTime.Now.Year - Birthday.Year).ToString();
        }
        static void Main(string[] args)
        {
            Patient patient = new Patient
            {
                MedicalRecordNumber = 11478632,
                FirstName = "Michael",
                LastName = "House",
                Birthday = new DateTime(1998, 6, 23),
                BloodType = "AB Neg",
                SocialSecurity = "342-56-3754",
                Hemoglobin = 12.5,
            };


            patient.display();

            Console.ReadLine();
        }

    }

}