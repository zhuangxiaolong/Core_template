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
    [Route("Music")]
    public class MusicController : Controller
    {
        private readonly IMusicAssembler _assembler;
        public MusicController(IMusicAssembler assembler)
        {
            _assembler = assembler;
        }
        [HttpGet]
        [Route("GetList")]
        public ResultMessage<MusicResponse> GetList()
        {
            return _assembler.GetList();
        }

    }
}
