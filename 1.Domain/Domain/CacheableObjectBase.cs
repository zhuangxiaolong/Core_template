using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
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
