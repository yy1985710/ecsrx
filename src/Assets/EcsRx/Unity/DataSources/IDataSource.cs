﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcsRx.Unity.DataSource
{
    public interface IDataSource<T> where T:IData
    {
        T Data { get; set; }
    }
}
