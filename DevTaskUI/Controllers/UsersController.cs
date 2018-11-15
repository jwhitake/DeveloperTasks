using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DevTaskApi.DAL;
using DevTaskApi.Models;
using DevTaskUI.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DevTaskUI.Controllers
{
    public class UsersController : Controller
    {
        //private readonly DevTaskContext _context;

        private readonly SolutionApi _api = new SolutionApi();


        //public UsersController(DevTaskContext context)
        //{
        //    _context = context;
        //}


        // GET: Users
        public async Task<ActionResult> Index()
        {
            List<User> users = new List<User>();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Users");
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                users = JsonConvert.DeserializeObject<List<User>>(result);
            }
                return View(users);
        }

        // GET: Users/Details/5
        public async Task<ActionResult> Details(int id)
        {
            User user = new User();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Users/" + id);
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<User>(result);
            }
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {
            try
            {
                HttpClient client = _api.Initial();
                string strJson = JsonConvert.SerializeObject(user);
                HttpResponseMessage res = await client.PostAsync("api/Users/", new StringContent(strJson, Encoding.UTF8, "application/json"));
                if (res.IsSuccessStatusCode)
                {
                    string strBreakPointHere = "Stop";
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            User user = new User();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Users/" + id);
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<User>(result);
            }
            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, User user)
        {
            try
            {
                HttpClient client = _api.Initial();
                string strJson = JsonConvert.SerializeObject(user);
                HttpResponseMessage res = await client.PutAsync("api/Users/" + id, new StringContent(strJson, Encoding.UTF8, "application/json"));
                if (res.IsSuccessStatusCode)
                {
                    string strBreakPointHere = "Stop";
                }
                //_context.Users.Update(user);
                //_context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            User user = new User();
            HttpClient client = _api.Initial();
            HttpResponseMessage res = await client.GetAsync("api/Users/" + id);
            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<User>(result);
            }
            //var user = _context.Users.Find(id);
            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, User user)
        {
            try
            {
                HttpClient client = _api.Initial();
                HttpResponseMessage res = await client.DeleteAsync("api/Users/" + id);
                if (res.IsSuccessStatusCode)
                {
                    string strBreakPointHere = "Stop";
                }
                //_context.Users.Remove(user);
                //_context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}