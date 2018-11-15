using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevTaskUI.Helper;
using DevTaskApi.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace DevTaskUI.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly SolutionApi _api = new SolutionApi();

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<Project> projects = new List<Project>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Projects");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                projects = JsonConvert.DeserializeObject<List<Project>>(result);
            }
            return View(projects);
        }
    }
}