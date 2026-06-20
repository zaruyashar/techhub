using Microsoft.AspNetCore.Mvc;
using TECHHUB.Data;
using TECHHUB.Models;

namespace TECHHUB.Controllers
{
    public class SupportTicketController : Controller
    {
        private readonly ApplicationDbContext context;

        public SupportTicketController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult TicketList()
        {
            var data = context.SupportTickets.ToList();
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
                Status = supportticket.Status ?? "Open" // Default to Open if not provided
            };

            context.SupportTickets.Add(ticket);
            context.SaveChanges();
            return new JsonResult("Ticket saved!");
        }

        public JsonResult Edit(int id)
        {
            var data = context.SupportTickets.Where(t => t.Id == id).SingleOrDefault();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Update(SupportTicket supportticket)
        {
            context.Update(supportticket);
            context.SaveChanges();
            return new JsonResult("Ticket updated!");
        }

        public JsonResult Delete(int id)
        {
            var data = context.SupportTickets.Where(t => t.Id == id).SingleOrDefault();
            context.SupportTickets.Remove(data);
            context.SaveChanges();
            return new JsonResult("Ticket deleted!");
        }
    }
}