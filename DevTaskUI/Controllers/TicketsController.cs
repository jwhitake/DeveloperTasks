using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevTaskUI.Helper;
using DevTaskApi.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace DevTaskUI.Controllers
{
    public class TicketsController : Controller
    {
        private readonly SolutionApi _api = new SolutionApi();

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<Ticket> tickets = new List<Ticket>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Tickets");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                tickets = JsonConvert.DeserializeObject<List<Ticket>>(result);
            }
            return View(tickets);
        }
    }
}