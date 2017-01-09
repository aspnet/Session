// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// Represents the session state options for the application.
    /// </summary>
    public class SessionOptions
    {
        /// <summary>
        /// Determines the cookie name used to persist the session ID.
        /// Defaults to <see cref="SessionDefaults.CookieName"/>.
        /// </summary>
        public string CookieName { get; set; } = SessionDefaults.CookieName;

        /// <summary>
        /// Determines the domain used to create the cookie. Is not provided by default.
        /// </summary>
        public string CookieDomain { get; set; }

        /// <summary>
        /// Determines the path used to create the cookie.
        /// Defaults to <see cref="SessionDefaults.CookiePath"/>.
        /// </summary>
        public string CookiePath { get; set; } = SessionDefaults.CookiePath;

        /// <summary>
        /// Determines if the browser should allow the cookie to be accessed by client-side JavaScript. The
        /// default is true, which means the cookie will only be passed to HTTP requests and is not made available
        /// to script on the page.
        /// </summary>
        public bool CookieHttpOnly { get; set; } = true;

        /// <summary>
        /// Determines if the cookie should only be transmitted on HTTPS requests. 
        /// </summary>
        public CookieSecurePolicy CookieSecure { get; set; } = CookieSecurePolicy.None;

        /// <summary>
        /// The IdleTimeout indicates how long the session can be idle before its contents are abandoned. Each session access
        /// resets the timeout. Note this only applies to the content of the session, not the cookie.
        /// </summary>
        public TimeSpan IdleTimeout { get; set; } = TimeSpan.FromMinutes(20);

        /// <summary>
        /// Determines if session should be used for HTTP HEAD request
        /// </summary>
        public bool BypassHeadReqeust { get; set; }
    }
}