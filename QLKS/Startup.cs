﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(QLKS.Startup))]
namespace QLKS
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();


            //Test tran thong o day
            //Test Alicuthong o day
        }
    }
}