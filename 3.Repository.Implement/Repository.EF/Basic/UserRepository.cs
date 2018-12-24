using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EF.Basic
{
    public class UserRepository : Repository<UserInfo, int>
    {

        public UserRepository(IUnitOfWork unitWork) : base(unitWork) { }
    }
}
