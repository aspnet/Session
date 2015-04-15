using System;
using Microsoft.AspNet.Http;

namespace SessionSample
{
    public class BooleanFormatter:ISessionFormatter<bool>
    {
        public byte[] Serialize(bool value)
        {
            return BitConverter.GetBytes(value);
        }

        public bool Deserialize(byte[] value)
        {
            if(value==null)
                return false;
            return BitConverter.ToBoolean(value, 0);
        }
    }
}