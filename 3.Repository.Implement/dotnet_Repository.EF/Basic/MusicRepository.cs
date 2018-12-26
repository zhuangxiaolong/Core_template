using dotnet_Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_Repository.EF.Basic
{
    public class MusicRepository : Repository<MusicInfo, int>
    {

        public MusicRepository(IUnitOfWork unitWork) : base(unitWork) { }
    }
}
