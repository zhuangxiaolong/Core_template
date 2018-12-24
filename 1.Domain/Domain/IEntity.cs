using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IEntity
    {

    }

    public interface IEntity<Pk> : IEntity
    {
        Pk Id { get; set; }
    }
}
