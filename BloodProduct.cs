﻿using System;
namespace Blood_Banking_Project
{
	public class BloodProduct
	{
		public string BloodType { get; set; }
		public string BloodComponent { get; set; } //Whole Blood, PRBC, FFP, Platelets, Cryoprecipitate
		public string ExpirationDate { get; set; }
		public string DonationDate { get; set; }
	
}
}
