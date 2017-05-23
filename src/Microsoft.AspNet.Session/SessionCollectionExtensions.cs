// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Http
{
    public static class SessionCollectionExtensions
    {
        public static void Set<T>(this ISessionCollection session, string key, T value, ISessionFormatter<T> formatter)
        {
            session.Set(key, formatter.Serialize(value));
        }

        public static T Get<T>(this ISessionCollection session, string key, ISessionFormatter<T> formatter)
        {
            return formatter.Deserialize(session.Get(key));
        }
    }
}