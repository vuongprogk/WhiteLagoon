using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Web.ViewModels;

namespace WhiteLagoon.Web.Controllers
{
    public class AmenityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AmenityController(IUnitOfWork context)
        {
            _unitOfWork = context;
        }
        public IActionResult Index()
        {
            var villas = _unitOfWork.Amenity.GetAll(includeProperties : "Villa").ToList();
            return View(villas);
        }
        public IActionResult Create()
        {
            AmenityVM villaNumberVM = new AmenityVM
            {
                VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.ID.ToString()
                })
            };
            return View(villaNumberVM);
        }

        [HttpPost]
        public IActionResult Create(AmenityVM obj)
        {

            if (ModelState.IsValid)
            {

                _unitOfWork.Amenity.Add(obj.Amenity!);
                _unitOfWork.Save();
                TempData["success"] = "Amenity has been created successfully";

                return RedirectToAction(nameof(Index));
            }

            obj.VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.ID.ToString()
            });
            return View(obj);
        }
        public IActionResult Update(int amenityId)
        {
            AmenityVM villaNumberVM = new AmenityVM
            {
                VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.ID.ToString()
                }),
                Amenity = _unitOfWork.Amenity.Get(u => u.Id == amenityId)
            };
            if (villaNumberVM.Amenity == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villaNumberVM);
        }
        [HttpPost]
        public IActionResult Update(AmenityVM obj)
        {

            if (ModelState.IsValid && obj.Amenity.Id > 0)
            {

                _unitOfWork.Amenity.Update(obj.Amenity);
                _unitOfWork.Save();
                TempData["success"] = "Amenity has been updated successfully";

                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Delete(int amenityId)
        {
            AmenityVM villaNumberVM = new AmenityVM
            {
                VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.ID.ToString()
                }),
                Amenity = _unitOfWork.Amenity.Get(u => u.Id == amenityId)
            };
            if (villaNumberVM.Amenity == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villaNumberVM);
        }
        [HttpPost]
        public IActionResult Delete(AmenityVM obj)
        {
            Amenity? amenity = _unitOfWork.Amenity.Get(u => u.Id == obj.Amenity.Id);
            if (amenity is not null)
            {

                _unitOfWork.Amenity.Remove(amenity);
                _unitOfWork.Save();
                TempData["success"] = "Amenity has been deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "Amenity could not be deleted";

            return View();
        }
    }
}
