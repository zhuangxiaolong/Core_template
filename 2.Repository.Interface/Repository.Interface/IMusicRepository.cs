using System;
using System.Collections.Generic;
using Models;

namespace Repository.Interface
{
    public interface IMusicRepository
    {
        MusicInfo Find(int id);
        IEnumerable<MusicInfo> List();
    }
}
