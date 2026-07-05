using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TECHHUB.Data;
using TECHHUB.Models;

namespace TECHHUB.Controllers
{
    [Authorize]
    public class SoftwareLicenseController : Controller
    {
        private readonly ApplicationDbContext context;

        public SoftwareLicenseController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult SoftwareLicenseList()
        {
            var data = context.SoftwareLicenses.ToList();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult AddSoftwareLicense(SoftwareLicense softwarelicense)
        {
            var license = new SoftwareLicense()
            {
                SoftwareName = softwarelicense.SoftwareName,
                LicenseKey = softwarelicense.LicenseKey,
                TotalSeats = softwarelicense.TotalSeats,
                RenewalDate = softwarelicense.RenewalDate
            };

            context.SoftwareLicenses.Add(license);
            context.SaveChanges();
            return new JsonResult("License saved!");
        }

        public JsonResult Edit(int id)
        {
            var data = context.SoftwareLicenses.Where(s => s.Id == id).SingleOrDefault();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult Update(SoftwareLicense softwarelicense)
        {
            context.Update(softwarelicense);
            context.SaveChanges();
            return new JsonResult("License updated!");
        }

        public JsonResult Delete(int id)
        {
            var data = context.SoftwareLicenses.Where(s => s.Id == id).SingleOrDefault();
            context.SoftwareLicenses.Remove(data);
            context.SaveChanges();
            return new JsonResult("License deleted!");
        }
    }
}