﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_Domain
{
    public class ResultMessage<T> : APIResponseBodyBase<ResultMessage<T>>
    {
        public ResultMessage() { }

        public ResultMessage(int err_code,
                             string err_msg)
        {
            this.err_code = err_code;
            this.err_msg = err_msg;
        }
        public int err_code { get; set; }
        public string err_msg { get; set; }
        public T body { get; set; }
    }
}
