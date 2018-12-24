using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class EntityBase<T, Pk> : IEntity<Pk>
       where T : IEntity
    {
        public Pk Id { get; set; }
    }
}
