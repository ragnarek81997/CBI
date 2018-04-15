using CBI.Domain.Interfaces;
using CBI.Services.Interfaces;
using System.Threading.Tasks;
using CBI.Domain.Entities.ViewModels;
using CBI.Domain.Entities.Struct;
using Microsoft.AspNet.Identity;
using CBI.Domain.Entities.Infrastructure;
using System;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using CBI.Domain.Entities.Enums;
using System.Web.Http;
using CBI.Domain.Entities.Dictionaries;
using System.Linq;
using CBI.Infrastructure.Data;

namespace CBI.Infrastructure.Business
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        private readonly IUserRepository _userRepository;

        public AccountService(IUserRepository userRepository, ApplicationDbContext applicationDbContext)
        {
            _userRepository = userRepository;
            _applicationDbContext = applicationDbContext;
        }

        #region Initialization
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        #endregion

        public async Task<ServiceResult> Register(RegisterBindingModel model)
        {
            var serviceResult = new ServiceResult();

            var user = new ApplicationUser()
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await UserManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                UserManager.AddToRole(user.Id, UserRoles.User.ToString());
                serviceResult.Success = true;
            }
            else
            {
                serviceResult.Error.Code = ErrorStatusCode.InvalidSignUp;
                serviceResult.Error.Description = result?.Errors?.FirstOrDefault();
            }

            return serviceResult;
        }
    }
}
