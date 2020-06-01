using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ziana.IdsAdmin.Server.Domains;
using Ziana.IdsAdmin.Server.Pages.Account;
using Ziana.IdsAdmin.Server.ViewModels.Account;

namespace Ziana.IdsAdmin.Server.Services
{
    public class AccountService:IApplicationService
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;


        public AccountService(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task Login(LoginInput input)
        {
            Console.WriteLine(input);
        }
    }
}
