using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_Repository.EF
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class DbFKAttribute : Attribute
    {

    }
}
