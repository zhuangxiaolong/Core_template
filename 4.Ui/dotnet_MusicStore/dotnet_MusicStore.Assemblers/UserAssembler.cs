
using System;
using dotnet_Domain;
using dotnet_Models;
using dotnet_MusicStore.DTOS;
using dotnet_MusicStore.IAssemblers;
using dotnet_Repository.EF;

namespace dotnet_MusicStore.Assemblers
{
    public class UserAssembler : AssemblerBase, IUserAssembler
    {
        private IRepository<UserInfo, int> _userRepository;

        public UserAssembler(IRepository<UserInfo, int> userRepository)
        {
            _userRepository = userRepository;
        }

        public ResultMessage<UserResponse> GetList()
        {
            var result = new ResultMessage<UserResponse>();

            var response = new UserResponse();
            response.LstInfo = new System.Collections.Generic.List<UserInfo>();
            var lst = _userRepository.FindAll();
            foreach (var obj in lst)
            {
                response.LstInfo.Add(obj);
            }
            result.body = response;
            return result;
        }
    }
}
