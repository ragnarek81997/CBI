﻿using CBI.Domain.Interfaces;
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
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository, ApplicationDbContext applicationDbContext)
        {
            _userRepository = userRepository;
            _applicationDbContext = applicationDbContext;
        }

        #region initialization
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

        public async Task<ServiceResult<ApplicationUser>> GetApplicationUser(string userId)
        {
            var serviceResult = new ServiceResult<ApplicationUser>();
            var result = await _userRepository.Get(userId);
            if (result.Success)
            {
                serviceResult.Success = true;
                serviceResult.Result = result.Entity;
            }
            else
            {
                serviceResult.Error.Code = ErrorStatusCode.BudRequest;
                serviceResult.Error.Description = result.Message;
            }
            return serviceResult;
        }

        public async Task<ServiceResult<ShortUser>> GetShortUser(string userId)
        {
            var serviceResult = new ServiceResult<ShortUser>();

            var result = await this.GetApplicationUser(userId);
            if (result.Success)
            {
                serviceResult.Success = true;
                serviceResult.Result = new ShortUser()
                {
                    Id = result.Result.Id,
                    Email = result.Result.Email
                };
            }
            else
            {
                serviceResult.Error = result.Error;
            }
            return serviceResult;
        }
    }
}
