using dotnet_Models;
using System;
using System.Collections.Generic;

namespace dotnet_MusicStore.DTOS
{
    public class MusicListResponse
    {
        public List<MusicInfo> LstInfo { get; set; }
    }
}
