﻿using Domain;
using MusicStore.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.IAssemblers
{
    public interface IUserAssembler
    {
        ResultMessage<UserResponse> GetList();
    }
}
