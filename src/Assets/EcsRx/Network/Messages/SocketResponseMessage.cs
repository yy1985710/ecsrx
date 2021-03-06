﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EcsRx.Json;

namespace EcsRx.Network
{
    public abstract class SocketResponseMessage<T> : IResponseMessage<T>
    {
        public T Data { get; set; }
    }
}
