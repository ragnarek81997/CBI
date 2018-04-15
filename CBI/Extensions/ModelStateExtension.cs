using CBI.Domain.Entities.Enums;
using CBI.Domain.Entities.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace CBI.Web.Extensions
{
    public static class ModelStateExtension
    {
        public static ServiceResult ToServiceResult(this ModelStateDictionary source)
        {
            var serviceResult = new ServiceResult();
            serviceResult.Success = false;

            string errorMessage = string.Empty;

            foreach (var value in source?.Values)
            {
                if (string.IsNullOrEmpty(errorMessage))
                {
                    if (value?.Errors.Count != 0)
                    {
                        errorMessage = value?.Errors?.FirstOrDefault().ErrorMessage;

                        if (string.IsNullOrEmpty(errorMessage))
                        {
                            errorMessage = value?.Errors?.FirstOrDefault().Exception?.Message;
                        }
                    }
                }
            }

            serviceResult.Error.Code = ErrorStatusCode.BudRequest;
            serviceResult.Error.Description = errorMessage;

            return serviceResult;
        }
    }
}