﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UniRx;
using UnityEngine;

namespace EcsRx.Unity.Loader
{
    public interface ILoadStrategy
    {
        string Folder { get; set; }
        WWW Load(string url);
    }
}
