using dotnet_Domain;
using dotnet_Models;
using dotnet_MusicStore.DTOS;
using dotnet_MusicStore.IAssemblers;
using dotnet_Repository.EF;
using System;
using System.Collections.Generic;
using System.Text;


namespace dotnet_MusicStore.Assemblers
{
    public class MusicAssembler : AssemblerBase, IMusicAssembler
    {
        private readonly IUnitOfWork _unitWork;
        private IRepository<MusicInfo, int> _musicRepository;

        public MusicAssembler(IUnitOfWork unitWork, 
            IRepository<MusicInfo, int> musicRepository)
        {
            _unitWork = unitWork;
            _musicRepository = musicRepository;
        }

        public ResultMessage<MusicListResponse> GetList()
        {
            var result = new ResultMessage<MusicListResponse>();

            var musicResponse = new MusicListResponse();
            musicResponse.LstInfo = new System.Collections.Generic.List<MusicInfo>();
        var lst= _musicRepository.FindAll();
            foreach(var obj in lst)
            {
                musicResponse.LstInfo.Add(obj);
            }
            result.body = musicResponse;
            return result;
        }
        public ResultMessage<MusicResponse> Add(AddMusicRequest request)
        {
            var result = new ResultMessage<MusicResponse>();
            var response = new MusicResponse();

            var obj = new MusicInfo();
            obj.Name = request.Name;
            obj.Price = request.Price;
            _musicRepository.Add(obj);
            _unitWork.Commit();
            result.err_code = 0;
            return result;
        }
        public ResultMessage<MusicResponse> Update(UpdateMusicRequest request)
        {
            var result = new ResultMessage<MusicResponse>();
            var response = new MusicResponse();

            var obj = _musicRepository.FindSingle(request.Id);
            if (obj == null)
            {
                result.err_code = -1;
                result.err_msg = "对象不存在";
                return result;
            }
            obj.Name = request.Name;
            obj.Price = request.Price;
            _musicRepository.Update(obj);
            _unitWork.Commit();
            result.err_code = 0;
            return result;
        }
        public ResultMessage<MusicResponse> Delete(DeleteMusicRequest request)
        {
            var result = new ResultMessage<MusicResponse>();
            var response = new MusicResponse();

            var obj = _musicRepository.FindSingle(request.Id);
            if (obj == null)
            {
                result.err_code = -1;
                result.err_msg = "对象不存在";
                return result;
            }
            _musicRepository.Remove(request.Id);
            _unitWork.Commit();
            result.err_code = 0;
            return result;
        }
    }
}
