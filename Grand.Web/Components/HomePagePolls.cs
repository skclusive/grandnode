﻿using Microsoft.AspNetCore.Mvc;
using Grand.Web.Services;
using System.Linq;
using Grand.Framework.Components;

namespace Grand.Web.ViewComponents
{
    public class HomePagePollsViewComponent : BaseViewComponent
    {
        private readonly IPollViewModelService _pollViewModelService;

        public HomePagePollsViewComponent(IPollViewModelService pollViewModelService)
        {
            this._pollViewModelService = pollViewModelService;
        }

        public IViewComponentResult Invoke()
        {
            var model = _pollViewModelService.PrepareHomePagePoll();
            if (!model.Any())
                Content("");
            return View(model);
        }
    }
}