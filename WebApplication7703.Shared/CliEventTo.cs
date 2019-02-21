using System;

namespace WebApplication7703.Shared
{
    public class CliEventTo
    {
        public static event Action<string> OnRequest;

        public void Request(string ip) => OnRequest?.Invoke(ip);
    }
}
