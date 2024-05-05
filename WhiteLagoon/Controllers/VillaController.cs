using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Web.ViewModels;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public VillaController(IUnitOfWork context, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            var villas = _unitOfWork.Villa.GetAll();
            return View(villas);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa obj)
        {
            if (obj.Name == obj.Description)
            {
                ModelState.AddModelError("Name", "The name cannot exactly match the name");
            }
            if (ModelState.IsValid)
            {
                if (obj.Image != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(obj.Image.FileName);
                    string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\Villa");
                    using (FileStream fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create))
                    {
                        obj.Image.CopyTo(fileStream);
                        obj.ImageUrl = @"\images\Villa\" + fileName;
                    }
                }
                else
                {
                    obj.ImageUrl = "https://placehold.co/600x400";
                }
                _unitOfWork.Villa.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Villa has been created successfully";

                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Update(int villaId)
        {
            Villa? obj = _unitOfWork.Villa.Get(u => u.ID == villaId);
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Update(Villa obj)
        {

            if (ModelState.IsValid && obj.ID > 0)
            {
                if (obj.Image != null)
                {
                    if (!string.IsNullOrEmpty(obj.ImageUrl))
                    {
                        var oldImageUrl = Path.Combine(_webHostEnvironment.WebRootPath, obj.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImageUrl))
                        {
                            System.IO.File.Delete(oldImageUrl);
                        }

                    }
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(obj.Image.FileName);
                    string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\Villa");
                    using (FileStream fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create))
                    {
                        obj.Image.CopyTo(fileStream);
                        obj.ImageUrl = @"\images\Villa\" + fileName;
                    }
                }
                _unitOfWork.Villa.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Villa has been updated successfully";

                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Delete(int villaId)
        {
            Villa? obj = _unitOfWork.Villa.Get(u => u.ID == villaId);
            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Delete(Villa obj)
        {
            Villa? objFromDb = _unitOfWork.Villa.Get(u => u.ID == obj.ID);
            if (objFromDb is not null)
            {
                if (!string.IsNullOrEmpty(objFromDb.ImageUrl))
                {
                    var oldImageUrl = Path.Combine(_webHostEnvironment.WebRootPath, objFromDb.ImageUrl.TrimStart('\\'));
                    if (System.IO.File.Exists(oldImageUrl))
                    {
                        System.IO.File.Delete(oldImageUrl);
                    }

                }
                _unitOfWork.Villa.Remove(objFromDb);
                _unitOfWork.Save();
                TempData["success"] = "Villa has been deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            TempData["success"] = "Villa could not be deleted successfully";

            return View();
        }
    }
}
