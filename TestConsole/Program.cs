using DevTaskApi.DAL;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using DevTaskApi.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DevTaskContext>();
            optionsBuilder.UseSqlServer(@"server=(local);database=DevTasks;Trusted_Connection=True;");
            DevTaskContext _context = new DevTaskContext(optionsBuilder.Options);


            //IniatializeDatabase(_context);



            var solutions = _context.Solutions;
            foreach (Solution s in solutions)
            {
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Description);
            }

            Console.ReadKey();

        }

        public static async Task RunAsync()
        {
            //using (var client = new HttpClient())
            //{
            //    try
            //    {
            //        client.BaseAddress = napi/Projects/1ew Uri("http://usfldeera-sg-02/devtaskapi/");
            //        HttpResponseMessage response = await client.GetAsync("api/Projects/1");
            //        if (response.IsSuccessStatusCode)
            //        {
            //            var result = response.Content.ReadAsStringAsync().Result;
            //            var project = JsonConvert.DeserializeObject<Project>(result);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
        }

        #region Seed database
        public static void IniatializeDatabase(DevTaskContext _context)
        {
            AddSolutions(_context);
            AddProjects(_context);
            AddUsers(_context);
            AddTickets(_context);
        }
        public static void AddSolutions(DevTaskContext _context)
        {
            Solution solution = new Solution()
            {
                Name = "Test Api",
                Description = "Solution to test building and deploying a RESTful API",
                IsEnabled = true
            };
            _context.Solutions.Add(solution);

            solution = new Solution()
            {
                Name = "Client-Side Data Collector",
                Description = "Solution to contain all client-side programs",
                IsEnabled = true
            };
            _context.Solutions.Add(solution);

            solution = new Solution()
            {
                Name = "User Interfaces",
                Description = "Solution for Internal and external user interfaces",
                IsEnabled = true
            };
            _context.Solutions.Add(solution);

            _context.SaveChanges();
        }
        public static void AddProjects(DevTaskContext _context)
        {
            Project project = new Project()
            {
                Name = "DevTicketApi",
                Description = "RESTful API to support all UI and services for the developer ticketing system",
                IsEnabled = true,
                SolutionId = 1
            };
            _context.Projects.Add(project);

            project = new Project()
            {
                Name = "WebTestProject",
                Description = "Diagnostic and test project for the API of the developer ticketing system",
                IsEnabled = true,
                SolutionId = 1
            };
            _context.Projects.Add(project);

            project = new Project()
            {
                Name = "ClientDataCollector",
                Description = "Client-side Windows service to collect network appliance ind=formation",
                IsEnabled = true,
                SolutionId = 2
            };
            _context.Projects.Add(project);

            project = new Project()
            {
                Name = "ClientUtility",
                Description = "Client application for systemstatus, log viewer, and diagnostic tests",
                IsEnabled = true,
                SolutionId = 2
            };
            _context.Projects.Add(project);

            project = new Project()
            {
                Name = "ClientUI",
                Description = "External client user interdace",
                IsEnabled = true,
                SolutionId = 3
            };
            _context.Projects.Add(project);

            project = new Project()
            {
                Name = "UserUI",
                Description = "Internal client user interdace",
                IsEnabled = true,
                SolutionId = 3
            };
            _context.Projects.Add(project);

            project = new Project()
            {
                Name = "TestConsole",
                Description = "Developer console UI for testing projects in the User Interfaces solution",
                IsEnabled = true,
                SolutionId = 3
            };
            _context.Projects.Add(project);

            _context.SaveChanges();
        }
        public static void AddUsers(DevTaskContext _context)
        {
            User user = new User()
            {
                FirstName = "John",
                LastName = "Whitaker",
                Email = "John.Whitaker@example.com",
                IsEnabled = true
            };
            _context.Users.Add(user);

            user = new User()
            {
                FirstName = "Grace",
                LastName = "Hopper",
                Email = "Grace.Hopper@example.com",
                IsEnabled = true
            };
            _context.Users.Add(user);

            user = new User()
            {
                FirstName = "Charles",
                LastName = "Babbage",
                Email = "Charles.Babbage@example.com",
                IsEnabled = true
            };
            _context.Users.Add(user);

            user = new User()
            {
                FirstName = "Alan",
                LastName = "Turing",
                Email = "John.Whitaker@example.com",
                IsEnabled = true
            };

            user = new User()
            {
                FirstName = "Ada",
                LastName = "Lovelace",
                Email = "Ada.Lovelace@example.com",
                IsEnabled = true
            };
            _context.Users.Add(user);

            _context.SaveChanges();
        }
        public static void AddTickets(DevTaskContext _context)
        {
            Ticket ticket = new Ticket()
            {
                Name = "Add unit tests",
                Description = "Add unit tests to the API",
                IsEnabled = true,
                ProjectId = 1,
                UserId = 1
            };
            _context.Tickets.Add(ticket);

            ticket = new Ticket()
            {
                Name = "BUG FIX:Ubernman-Bass switch not returning serial",
                Description = "BUG FIX:Ubernman-Bass switch not returning serial number.  This is only for this Mfr.",
                IsEnabled = true,
                ProjectId = 3,
                UserId = 3
            };
            _context.Tickets.Add(ticket);

            ticket = new Ticket()
            {
                Name = "Add edit network",
                Description = "Add edit network description, and other fields to ClientUI",
                IsEnabled = true,
                ProjectId = 5,
                UserId = 2
            };
            _context.Tickets.Add(ticket);

            ticket = new Ticket()
            {
                Name = "Add test to console ",
                Description = "Add unit tests to the test conole for network health check",
                IsEnabled = true,
                ProjectId = 7,
                UserId = 1
            };
            _context.Tickets.Add(ticket);

            ticket = new Ticket()
            {
                Name = "Add heart beat check",
                Description = "Add heart beat to test from client to our system",
                IsEnabled = true,
                ProjectId = 4,
                UserId = 4
            };
            _context.Tickets.Add(ticket);

            ticket = new Ticket()
            {
                Name = "Add new UI test methods",
                Description = "Add new UI test methods for UserUi, ClientUI, and WebApi",
                IsEnabled = true,
                ProjectId = 2,
                UserId = 3
            };
            _context.Tickets.Add(ticket);

            ticket = new Ticket()
            {
                Name = "BUG FIX: Check WebApi swagger for documentation error",
                Description = "Swagger not reporting all XML comments for Controller methods",
                IsEnabled = true,
                ProjectId = 1,
                UserId = 1
            };
            _context.Tickets.Add(ticket);

            ticket = new Ticket()
            {
                Name = "Change network scan to Async/Await",
                Description = "Change network scan methods to use Asunc/Await.  Need to improve performance",
                IsEnabled = true,
                ProjectId = 3,
                UserId = 2
            };
            _context.Tickets.Add(ticket);

            ticket = new Ticket()
            {
                Name = "Add new page for transfering tickets",
                Description = "Add new page for transfering tickets. Admin user only",
                IsEnabled = true,
                ProjectId = 6,
                UserId = 3
            };
            _context.Tickets.Add(ticket);

            _context.SaveChanges();
        }
        #endregion
    }
}
