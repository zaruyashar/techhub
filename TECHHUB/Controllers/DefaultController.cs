using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TECHHUB.Data;
using TECHHUB.Models;

namespace TECHHUB.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ApplicationDbContext context;

        public DefaultController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetDashboardStats()
        {
            int currentOpenTickets = context.SupportTickets.Count(t => t.Status == "Open");
            int currentUrgentTickets = context.SupportTickets.Count(t => t.UrgencyLevel == "High" || t.UrgencyLevel == "Critical");
            int currentHardware = context.HardwareInventories.Count();
            int currentLicenses = context.SoftwareLicenses.Count(l => l.RenewalDate <= DateTime.Now.AddDays(30));

            return Json(new
            {
                openTickets = currentOpenTickets,
                urgentCriticalTickets = currentUrgentTickets,
                hardwareTracked = currentHardware,
                licensesExpiring = currentLicenses
            });
        }

        public JsonResult TicketList()
        {
            var data = context.SupportTickets.Where(t => t.Status == "Open").ToList();
            return new JsonResult(data);
        }


        [HttpPost]
        public JsonResult AddSupportTicket(SupportTicket supportticket)
        {
            var ticket = new SupportTicket()
            {
                IssueTitle = supportticket.IssueTitle,
                Description = supportticket.Description,
                UrgencyLevel = supportticket.UrgencyLevel,
                ReportedDate = supportticket.ReportedDate,
                Status = supportticket.Status
            };

            context.SupportTickets.Add(ticket);
            context.SaveChanges();
            return new JsonResult("Ticket Created");
        }


        public JsonResult Edit(int id)
        {
            var data = context.SupportTickets.Where(m => m.Id == id).SingleOrDefault();
            return new JsonResult(data);
        }


        [HttpPost]
        public JsonResult Update(SupportTicket supportticket)
        {
            context.Update(supportticket);
            context.SaveChanges();
            return new JsonResult("Ticket Updated");
        }


        [HttpPost]
        public JsonResult ChangeStatusToggle(int id)
        {
            var data = context.SupportTickets.SingleOrDefault(m => m.Id == id);
            if (data != null)
            {
                data.Status = data.Status == "Open" ? "Resolved" : "Open";
                context.SaveChanges();
            }
            return new JsonResult(data?.Status);
        }
    }
}
