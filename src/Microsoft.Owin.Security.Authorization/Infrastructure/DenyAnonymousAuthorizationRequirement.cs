// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Owin.Security.Authorization.Infrastructure
{
    public class DenyAnonymousAuthorizationRequirement : AuthorizationHandler<DenyAnonymousAuthorizationRequirement>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, DenyAnonymousAuthorizationRequirement requirement)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var user = context.User;
            var userIsAnonymous = user?.Identity == null || !user.Identities.Any(i => i.IsAuthenticated);
            if (!userIsAnonymous)
            {
                context.Succeed(requirement);
            }

            return Task.FromResult(0);
        }
    }
}
