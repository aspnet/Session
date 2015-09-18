// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.Http.Features;

namespace Microsoft.AspNet.Session
{
    /// <summary>
    /// Represent a session store.
    /// </summary>
    public interface ISessionStore
    {
        /// <summary>
        /// Check whether the session store is exist.
        /// </summary>
        bool IsAvailable { get; }
        
        /// <summary>
        /// Connect to the session store.
        /// </summary>
        void Connect();
        
        /// <summary>
        /// Create <see cref="ISession"/>.
        /// </summary>
        /// <param name="sessionId">Represents the unique identifier for the session.</param>
        /// <param name="idleTimeout">Represents the amount of time, in minutes, allowed between requests before the session-state provider terminates the session.</param>
        /// <param name="tryEstablishSession">Represents the delegate that try to establish the session.</param>
        /// <param name="isNewSessionKey">Represents a value indicating whether the session was created with the current request.</param>
        /// <returns>The <see cref="ISession"/>.</returns>
        ISession Create(string sessionId, TimeSpan idleTimeout, Func<bool> tryEstablishSession, bool isNewSessionKey);
    }
}