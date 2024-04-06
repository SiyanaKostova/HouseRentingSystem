using HouseRentingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    public class HouseController : AdminBaseController
    {
        private readonly IHouseService houseService;

        private readonly IAgentService agentService;

        public HouseController(
            IHouseService _houseService,
            IAgentService _agentService)
        {
            houseService = _houseService;
            agentService = _agentService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
