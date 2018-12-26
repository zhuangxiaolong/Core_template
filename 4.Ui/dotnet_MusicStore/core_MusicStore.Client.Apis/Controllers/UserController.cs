using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_MusicStore.IAssemblers;

using dotnet_Domain;
using dotnet_MusicStore.DTOS;

namespace core_MusicStore.Client.Apis
{
    [Route("User")]
    public class UserController : Controller
    {
        private readonly IUserAssembler _assembler;
        public UserController(IUserAssembler assembler)
        {
            _assembler = assembler;
        }
        [HttpGet]
        [Route("GetList")]
        public ResultMessage<UserResponse> GetList()
        {
            return _assembler.GetList();
        }

    }
}
