using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TECHHUB.Data;
using TECHHUB.Models;

namespace TECHHUB.Controllers
{
    [Authorize]
    public class HardwareInventoryController : Controller
    {
        private readonly ApplicationDbContext context;

        public HardwareInventoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult HardwareInventoryList()
        {
            var data = context.HardwareInventories.ToList();
            return new JsonResult(data);
        }

        [HttpPost]
        public JsonResult AddHardwareInventory(HardwareInventory hardwareinventory)
        {

            var hardware = new HardwareInventory()
            {
                DeviceType = hardwareinventory.DeviceType,
                SerialNumber = hardwareinventory.SerialNumber,
                PurchaseDate = hardwareinventory.PurchaseDate,
                WarrantyExpiration = hardwareinventory.WarrantyExpiration
            };

            context.HardwareInventories.Add(hardware);
            context.SaveChanges();
            return new JsonResult("Inventory saved!");
        }


        public JsonResult Edit(int id)
        {
            var data = context.HardwareInventories.Where(h => h.Id == id).SingleOrDefault();
            return new JsonResult(data);

        }


        [HttpPost]
        public JsonResult Update(HardwareInventory hardwareinventory)
        {
            context.Update(hardwareinventory);
            context.SaveChanges();
            return new JsonResult("Inventory details updated!");
        }


        public JsonResult Delete(int id)
        {
            var data = context.HardwareInventories.Where(h => h.Id == id).SingleOrDefault();
            context.HardwareInventories.Remove(data);
            context.SaveChanges();
            return new JsonResult("Inventory item deleted!");
        }
    }
}
