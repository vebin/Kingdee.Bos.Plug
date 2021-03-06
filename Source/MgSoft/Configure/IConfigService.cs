﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.Configure
{
    public interface IConfigService
    {
        T GetConfig<T>(string configName = "") where T : class,new();
        void SetConfig<T>(T config, string configName = "");
    }
}
