
using dotnet_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_Models
{
    public class UserInfo : EntityBase<UserInfo, int>
    {
        public string Name { get; set; }
        public string Pw { get; set; }
    }
}
