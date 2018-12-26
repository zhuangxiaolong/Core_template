
using System;
using Domain;
using MusicStore.IAssemblers;
using MusicStore.DTOS;
using Models;
using Repository.EF;

namespace MusicStore.Assemblers
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
