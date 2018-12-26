using dotnet_Domain;
using dotnet_MusicStore.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_MusicStore.IAssemblers
{
    public interface IMusicAssembler
    {
        ResultMessage<MusicListResponse> GetList();
        ResultMessage<MusicResponse> Add(AddMusicRequest request);
        ResultMessage<MusicResponse> Delete(DeleteMusicRequest request);
        ResultMessage<MusicResponse> Update(UpdateMusicRequest request);
    }
}
