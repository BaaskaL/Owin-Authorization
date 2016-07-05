﻿using System.Threading.Tasks;
using Microsoft.Owin.Security.Authorization;

namespace WebApi_Custom_Handler.Models
{
    public class EmployeeNumber2Handler : AuthorizationHandler<EmployeeNumber2Requirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, EmployeeNumber2Requirement requirement)
        {
            foreach (var claim in context.User.Claims)
            {
                if (string.Equals(claim.Type, ExampleConstants.EmployeeClaimType))
                {
                    if (claim.Value == "2")
                    {
                        context.Succeed(requirement);
                        break;
                    }
                }
            }

            return Task.FromResult(0);
        }
    }
}