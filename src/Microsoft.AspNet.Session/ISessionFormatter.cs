// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Http
{
    public interface ISessionFormatter<T>
    {
        byte[] Serialize(T value);
        T Deserialize(byte[] value);
    }
}