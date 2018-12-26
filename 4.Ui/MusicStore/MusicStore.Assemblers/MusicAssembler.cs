using Domain;
using Models;
using MusicStore.DTOS;
using MusicStore.IAssemblers;
using Repository.EF;
using System;
using System.Collections.Generic;
using System.Text;


namespace MusicStore.Assemblers
{
    public class MusicAssembler : AssemblerBase, IMusicAssembler
    {
        private IRepository<MusicInfo, int> _musicRepository;

        public MusicAssembler(IRepository<MusicInfo, int> musicRepository)
        {
            _musicRepository = musicRepository;
        }

        public ResultMessage<MusicResponse> GetList()
        {
            var result = new ResultMessage<MusicResponse>();

            var musicResponse = new MusicResponse();
            musicResponse.LstInfo = new System.Collections.Generic.List<MusicInfo>();
        var lst= _musicRepository.FindAll();
            foreach(var obj in lst)
            {
                musicResponse.LstInfo.Add(obj);
            }
            result.body = musicResponse;
            return result;
        }
    }
}
