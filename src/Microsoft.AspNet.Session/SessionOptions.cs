// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNet.Session
{
    public class SessionOptions
    {
        /// <summary>
        /// Determines the cookie name used to persist the session ID. The default value is ".AspNet.Session".
        /// </summary>
        public string CookieName { get; set; } = SessionDefaults.CookieName;

        /// <summary>
        /// Determines the domain used to create the cookie. Is not provided by default.
        /// </summary>
        public string CookieDomain { get; set; }

        /// <summary>
        /// Determines the path used to create the cookie. The default value is "/" for highest browser compatibility.
        /// </summary>
        public string CookiePath { get; set; } = SessionDefaults.CookiePath;

        /// <summary>
        /// Determines if the browser should allow the cookie to be accessed by client-side JavaScript. The
        /// default is true, which means the cookie will only be passed to HTTP requests and is not made available
        /// to script on the page.
        /// </summary>
        public bool CookieHttpOnly { get; set; } = SessionDefaults.CookieHTTPOnly;

        /// <summary>
        /// The IdleTimeout indicates how long the session can be idle before its contents are abandoned. Each session access
        /// resets the timeout. Note this only applies to the content of the session, not the cookie.
        /// </summary>
        public TimeSpan IdleTimeout { get; set; } = TimeSpan.FromMinutes(20);

        /// <summary>
        /// Determines if the cookie should only be transmitted on HTTPS request. The default is to limit the cookie
        /// to HTTPS requests if the page which is doing the SignIn is also HTTPS. If you have an HTTPS sign in page
        /// and portions of your site are HTTP you may need to change this value.
        /// </summary>
        public CookieSecureOption CookieSecure { get; set; } = SessionDefaults.CookieSecure;

        /// <summary>
        /// Gets or sets the session storage manager. This overrides any session store passed into the middleware constructor.
        /// </summary>
        public ISessionStore Store { get; set; }
    }
}