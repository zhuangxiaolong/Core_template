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
        public ResultMessage<MusicListResponse> GetList()
        {
            return _assembler.GetList();
        }
        [HttpPost]
        [Route("Add")]
        public ResultMessage<MusicResponse> Add(AddMusicRequest request)
        {
            return _assembler.Add(request);
        }
        [HttpPost]
        [Route("Update")]
        public ResultMessage<MusicResponse> Update(UpdateMusicRequest request)
        {
            return _assembler.Update(request);
        }
        [HttpPost]
        [Route("Delete")]
        public ResultMessage<MusicResponse> Delete(DeleteMusicRequest request)
        {
            return _assembler.Delete(request);
        }

    }
}
