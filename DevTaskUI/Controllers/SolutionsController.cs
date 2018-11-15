using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevTaskUI.Models;
using DevTaskUI.Helper;
using DevTaskApi.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace DevTaskUI.Controllers
{
    public class SolutionsController : Controller
    {
        private readonly SolutionApi _api = new SolutionApi();

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<Solution> solutions = new List<Solution>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Solutions");
            if(res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                solutions = JsonConvert.DeserializeObject<List<Solution>>(result);
            }
            return View(solutions);
        }

    }
}
