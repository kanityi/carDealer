using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using carDealer.Controllers.Resources;
using carDealer.Models;
using carDealer.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace carDealer.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly IMapper mapper;
        private readonly CarDealerDbContext context;
        public FeaturesController(CarDealerDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("api/features")]
        public IEnumerable<FeatureResource> getFeatures()
        {
            var features = context.Features.ToList();
            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }

    }
}