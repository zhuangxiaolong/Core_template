using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_Domain
{
    public class EntityBase<T, Pk> : IEntity<Pk>
       where T : IEntity
    {
        public Pk Id { get; set; }
    }
}
