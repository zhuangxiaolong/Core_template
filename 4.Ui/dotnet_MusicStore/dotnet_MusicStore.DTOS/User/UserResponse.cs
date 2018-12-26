using dotnet_Models;
using System;
using System.Collections.Generic;

namespace dotnet_MusicStore.DTOS
{
    public class UserResponse
    {
        public List<UserInfo> LstInfo { get; set; }
    }
}
