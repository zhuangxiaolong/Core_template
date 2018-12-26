using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface ICacheableObject : IValueObject
    {
        string CacheId { get; set; }
        TimeSpan? ExpireTime { get; set; }
    }
}
