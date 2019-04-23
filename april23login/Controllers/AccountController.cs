using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using april23login.Models;
using april23login.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace april23login.Controllers
{
    public class AccountController : Controller
    {
        AccountService accountService;

        public AccountController(AccountService accountService)
        {
            this.accountService = accountService;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/Members")]
        public IActionResult Members()
        {
            return View();
        }

        [HttpGet]
        [Route("/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("/Register")]
        public IActionResult Register(AccountRegisterVM accountRegisterVM)
        {
            return View();
        }
    }
}