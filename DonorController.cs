using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Module_IV_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : ControllerBase
    {

        public List<Donor> GetDonors()
        {
            List<Donor> donors = new List<Donor>(4);

            donors.Add(new Donor("Michael", "House", "O Positive", "MRN:2783389"));
            donors.Add(new Donor("Celeste", "Iglesias", "O Positive", "MRN:2344389"));
            donors.Add(new Donor("Galilea", "Ramirez", "O Positive", "MRN:4754389"));
            donors.Add(new Donor("Onessimo", "Marillo", "O Positive", "MRN:8643389"));

            return donors;
        }
    }
}
