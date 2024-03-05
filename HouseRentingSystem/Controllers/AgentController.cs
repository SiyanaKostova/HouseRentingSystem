﻿using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using HouseRentingSystem.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class AgentController : BaseController
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await agentService.ExistsByIdAsync(User.Id()))
            {
                return BadRequest();
            }

            var model = new BecomeAgentFormModel();

            return View(model);
        }

		[HttpPost]
		public async Task<IActionResult> Become(BecomeAgentFormModel agent)
		{
            return RedirectToAction(nameof(HouseController.All), "Houses");
		}
	}
}
