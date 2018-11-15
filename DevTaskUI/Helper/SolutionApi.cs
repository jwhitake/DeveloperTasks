using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DevTaskUI.Helper
{
    public class SolutionApi
    {
        public SolutionApi()
        {

        }

        public HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("http://usfldeera-sg-02/DevTaskApi/");
            return Client;
        }
    }
}
