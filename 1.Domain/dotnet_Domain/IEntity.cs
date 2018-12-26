using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_Domain
{
    public interface IEntity
    {

    }

    public interface IEntity<Pk> : IEntity
    {
        Pk Id { get; set; }
    }
}
