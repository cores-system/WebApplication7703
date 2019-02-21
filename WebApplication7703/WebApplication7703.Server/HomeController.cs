using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication7703.Shared;

namespace WebApplication7703.Server
{
    public class HomeController : Controller
    {
        public string MyIp()
        {
            string ip = HttpContext.Connection.RemoteIpAddress.ToString();

            CliEventTo ev = new CliEventTo();
            ev.Request(ip);

            return ip;
        }
    }
}
