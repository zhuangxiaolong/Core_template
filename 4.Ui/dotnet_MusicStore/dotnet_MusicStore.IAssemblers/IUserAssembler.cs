using dotnet_Domain;
using dotnet_MusicStore.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_MusicStore.IAssemblers
{
    public interface IUserAssembler
    {
        ResultMessage<UserResponse> GetList();
    }
}
