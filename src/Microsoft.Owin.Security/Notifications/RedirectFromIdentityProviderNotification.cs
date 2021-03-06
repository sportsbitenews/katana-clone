﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Microsoft.Owin.Security.Notifications
{
    public class RedirectFromIdentityProviderNotification
    {
        public AuthenticationTicket AuthenticationTicket { get; set; }

        public string SignInAsAuthenticationType { get; set; }

        public bool Cancel { get; set; }

        public int StatusCode { get; set; }

        public bool IsRequestCompleted { get; set; }
    }
}
