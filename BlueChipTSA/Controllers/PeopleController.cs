using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlueChipTSA.Models;
using BlueChipTSA.ViewModels;

namespace BlueChipTSA.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private readonly BlueChipDataContext _context;

        public PeopleController(BlueChipDataContext context)
        {
            _context = context;
        }

        //API to get List of PeopleViewModels
        [HttpGet("[action]")]
        public IEnumerable<PeopleViewModel> GetList()
        {
            var peopleList = new List<PeopleViewModel>();
            var listData = (from person in _context.People
                            join country in _context.Countries on person.CountryId equals country.Id

                            select new PeopleViewModel
                           {
                              FirstName = person.FirstName,
                              LastName = person.LastName,
                              Email = person.Email,
                              Country = country.Name,
                              CountryDescription = country.Description
                            }
                          ).ToList();
     
            return listData;
        }
    }
}