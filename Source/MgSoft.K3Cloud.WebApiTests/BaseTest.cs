﻿using MgSoft.K3Cloud.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MgSoft.K3Cloud.WebApiTests
{
    public abstract class BaseTest
    {
        protected ApiServerInfo GetApiServerInfo()
        {
            return new ApiServerInfo() 
            {
                ServerUrl= "http://win-bb1tms7l26e/K3Cloud/",
                Dbid= "5fa3b80c5957c5",
                UserName="administrator",
                Password="888888"
            };
        }
    }
}
