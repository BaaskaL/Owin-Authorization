// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace Microsoft.Owin.Security.Authorization
{
    public interface IAuthorizationHandler
    {
        Task HandleAsync(AuthorizationHandlerContext context);
    }
}
