using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Client.Apis.Models;
using MusicStore.IAssemblers;

using Domain;
using MusicStore.DTOS;

namespace MusicStore.Client.Apis.Controllers
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
