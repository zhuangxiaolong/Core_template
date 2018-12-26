using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_Domain
{
    public abstract class CacheableObjectBase : ICacheableObject
    {
        [JsonIgnore]
        public string CacheId { get; set; }

        [JsonIgnore]
        public TimeSpan? ExpireTime
        {
            get; set;
        }
    }
}
