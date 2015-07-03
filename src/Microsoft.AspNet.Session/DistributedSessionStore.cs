// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.Http.Features;
using Microsoft.Framework.Caching.Distributed;
using Microsoft.Framework.Internal;
using Microsoft.Framework.Logging;

namespace Microsoft.AspNet.Session
{
    /// <summary>
    /// Represents a session state provider that using a distributed cache store.
    /// </summary>
    public class DistributedSessionStore : ISessionStore
    {
        private readonly IDistributedCache _cache;
        private readonly ILoggerFactory _loggerFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="DistributedSessionStore"/> class.
        /// </summary>
        /// <param name="cache">The <see cref="IDistributedCache"/>.</param>
        /// <param name="loggerFactory">The <see cref="ILoggerFactory"/>.</param>
        public DistributedSessionStore([NotNull] IDistributedCache cache, [NotNull] ILoggerFactory loggerFactory)
        {
            _cache = cache;
            _loggerFactory = loggerFactory;
        }

        /// <inheritdoc />
        public bool IsAvailable
        {
            get
            {
                return true; // TODO:
            }
        }

        /// <inheritdoc />
        public void Connect()
        {
            _cache.Connect();
        }

        /// <inheritdoc />
        public ISession Create([NotNull] string sessionId, TimeSpan idleTimeout, [NotNull] Func<bool> tryEstablishSession, bool isNewSessionKey)
        {
            return new DistributedSession(_cache, sessionId, idleTimeout, tryEstablishSession, _loggerFactory, isNewSessionKey);
        }
    }
}