using HouseRentingSystem.Attributes;
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static HouseRentingSystem.Core.Constants.MessageConstants;

namespace HouseRentingSystem.Controllers
{
	public class AgentController : BaseController
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }

        [HttpGet]
        [NotAnAgent]
        public IActionResult Become()
        {
            var model = new BecomeAgentFormModel();

            return View(model);
        }

		[HttpPost]
        [NotAnAgent]
		public async Task<IActionResult> Become(BecomeAgentFormModel model)
		{
            if (await agentService.UserWithPhoneNumberExistsAsync(User.Id()))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), PhoneExistsMessage);
            }

            if (await agentService.UserHasRentsAsync(User.Id()))
            {
				ModelState.AddModelError("Error", NoRentsMessage);
			}

            await agentService.CreateAsync(User.Id(), model.PhoneNumber);

			if (ModelState.IsValid == false)
            {
                return View(model);
            }

            return RedirectToAction(nameof(HouseController.All), "Houses");
		}
	}
}
