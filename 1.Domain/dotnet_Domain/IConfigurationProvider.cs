using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_Domain
{
    public interface IConfigurationProvider : IDependency
    {
        string GetAppSetting(string key);
        string GetConnectionString(string key);
    }
}
