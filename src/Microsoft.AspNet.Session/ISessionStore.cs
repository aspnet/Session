// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.Http.Features;

namespace Microsoft.AspNet.Session
{
    /// <summary>
    /// Represent a session store.".
    /// </summary>
    public interface ISessionStore
    {
        /// <summary>
        /// Determine the session availability.".
        /// </summary>
        bool IsAvailable { get; }
        
        /// <summary>
        /// Connect to the session store.".
        /// </summary>
        void Connect();
        
        /// <summary>
        /// Create <see cref="ISession"/>.
        /// </summary>
        /// <param name="sessionId">Represents the session id.</param>
        /// <param name="idleTimeout">Represents the session timeout.</param>
        /// <param name="tryEstablishSession">Represents the delegate that trying to establish the session.</param>
        /// <param name="isNewSessionKey">Determine whether the session key is new.</param>
        /// <returns>The <see cref="ISession"/>.</returns>
        ISession Create(string sessionId, TimeSpan idleTimeout, Func<bool> tryEstablishSession, bool isNewSessionKey);
    }
}