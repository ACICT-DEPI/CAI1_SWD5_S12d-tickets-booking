﻿using Microsoft.AspNetCore.Mvc;

namespace Tickets.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {

        }


        public IActionResult Index()
        {
            return View();
        }


    }
}
