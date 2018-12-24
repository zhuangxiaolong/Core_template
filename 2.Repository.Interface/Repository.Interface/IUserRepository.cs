using System;
using System.Collections.Generic;
using Models;

namespace Repository.Interface
{
    public interface IUserRepository
    {
        UserInfo Find(int id);
        IEnumerable<UserInfo> List();
    }
}
