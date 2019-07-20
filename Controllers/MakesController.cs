using AutoMapper;
using carDealer.Controllers.Resources;
using carDealer.Models;
using carDealer.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace carDealer.Controllers
{
    public class MakesController : Controller
    {
        public readonly CarDealerDbContext cotext;
        private readonly IMapper mapper;
        public MakesController(CarDealerDbContext cotext, IMapper mapper)
        {
            this.mapper = mapper;
            this.cotext = cotext;
        }
        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await cotext.Makes.Include(m => m.Models).ToListAsync();
            return  mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}