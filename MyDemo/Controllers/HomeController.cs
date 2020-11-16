using MyDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.EmployeeProcessor;
using static DataLibrary.BusinessLogic.ProjectProcessor;
using static DataLibrary.BusinessLogic.TicketProcessor;

namespace MyDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Project()
        {
            ViewBag.Message = "New Project";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Project(ProjectModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateProject(model.ProjectId,
                    model.ProjectTitle,
                    model.ProjectStartDate);
                return RedirectToAction("Index");

            }
            return View();

        }
        public ActionResult ViewProjects()
        {
            ViewBag.Message = "Projects List";

            var data = LoadProjects();
            List<ProjectModel> projects = new List<ProjectModel>();

            foreach (var row  in data)
            {
                projects.Add(new ProjectModel
                {
                    ProjectId = row.ProjectId,
                    ProjectTitle = row.ProjectTitle,
                    ProjectStartDate = row.ProjectStartDate

                });
            }

            return View(projects);
        
        }
       


        public ActionResult Ticket()
        {
            ViewBag.Message = "New Ticket";

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ticket(TicketModel model)
        {
            if (ModelState.IsValid)
            {
                int recordCreated = CreateTicket( model.TicketId, model.TicketTitle, model.TicketDescription, model.TicketSubmitter, model.TicketPriority, model.TicketStatus, model.TicketCreatedOn, model.TicketUpdatedOn, model.TicketComment);
                return RedirectToAction("Index");

            }
            return View();

        }
        public ActionResult ViewTickets()
        {

            ViewBag.Message = "Ticket List";

            var data = LoadTickets();
            List<TicketModel> ticket = new List<TicketModel>();
            foreach (var row in data)
            {
                ticket.Add(new TicketModel
                {
                    TicketId = row.TicketId,
                    TicketTitle = row.TicketTitle,
                    TicketDescription = row.TicketDescription,
                    TicketStatus = row.TicketSubmitter,
                    TicketPriority = row.TicketPriority,
                    TicketCreatedOn = row.TicketCreatedOn,
                    TicketUpdatedOn = row.TicketUpdatedOn,
                    TicketComment = row.TicketComment,
                    TicketSubmitter = row.TicketSubmitter



                });
            }
            return View(ticket);
        
        
        }


        public ActionResult NewEmployee()
        {
            ViewBag.Message = "New Employee";
            return View();

        }
        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employee List";

            var data = LoadEmployees();

            List<EmployeeModel> employee = new List<EmployeeModel>();

            foreach (var row in data)
            {
                employee.Add(new EmployeeModel
                {
                    EmployeeId = row.EmployeeId,
                    Role = row.Role,
                    LastName = row.LastName,
                    FirstName = row.FirstName,
                    City = row.City,
                    Country = row.Country,
                    Email = row.Email


                });
            }



            return View(employee);

        
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewEmployee(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
               int recordsCreated = CreateEmployee(model.EmployeeId, model.Role, model.LastName, model.FirstName, model.City, model.Country, model.Email);
                return RedirectToAction("Index");
            
            }
            return View();

        }
       
       

    }
}