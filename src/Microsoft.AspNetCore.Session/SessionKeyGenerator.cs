// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Security.Cryptography;

namespace Microsoft.AspNetCore.Session
{
    public class SessionKeyGenerator: ISessionKeyGenerator
    {
        private static readonly RandomNumberGenerator CryptoRandom = RandomNumberGenerator.Create();

        public virtual string GetNewSessionKey(int sessionKeyLength)
        {
            var guidBytes = new byte[16];
            CryptoRandom.GetBytes(guidBytes);
            return new Guid(guidBytes).ToString();
        }
    }
}
