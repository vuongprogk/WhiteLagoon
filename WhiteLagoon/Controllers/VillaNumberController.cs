using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Web.ViewModels;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public VillaNumberController(IUnitOfWork context)
        {
            _unitOfWork = context;
        }
        public IActionResult Index()
        {
            var villas = _unitOfWork.VillaNumber.GetAll(includeProperties : "Villa").ToList();
            return View(villas);
        }
        public IActionResult Create()
        {
            VillaNumberVM villaNumberVM = new VillaNumberVM
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
        public IActionResult Create(VillaNumberVM obj)
        {
            bool isExist = _unitOfWork.VillaNumber.Any(u => u.Villa_Number == obj.VillaNumber!.Villa_Number);

            if (ModelState.IsValid && !isExist)
            {

                _unitOfWork.VillaNumber.Add(obj.VillaNumber!);
                _unitOfWork.Save();
                TempData["success"] = "Villa Number has been created successfully";

                return RedirectToAction(nameof(Index));
            }
            if (isExist)
            {
                TempData["error"] = "Villa number already exist";
            }
            obj.VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.ID.ToString()
            });
            return View(obj);
        }
        public IActionResult Update(int villaNumber)
        {
            VillaNumberVM villaNumberVM = new VillaNumberVM
            {
                VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.ID.ToString()
                }),
                VillaNumber = _unitOfWork.VillaNumber.Get(u => u.Villa_Number == villaNumber)
            };
            if (villaNumberVM.VillaNumber == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villaNumberVM);
        }
        [HttpPost]
        public IActionResult Update(VillaNumberVM obj)
        {

            if (ModelState.IsValid && obj.VillaNumber.Villa_Number > 0)
            {

                _unitOfWork.VillaNumber.Update(obj.VillaNumber);
                _unitOfWork.Save();
                TempData["success"] = "Villa number has been updated successfully";

                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Delete(int villaNumber)
        {
            VillaNumberVM villaNumberVM = new VillaNumberVM
            {
                VillaList = _unitOfWork.Villa.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.ID.ToString()
                }),
                VillaNumber = _unitOfWork.VillaNumber.Get(u => u.Villa_Number == villaNumber)
            };
            if (villaNumberVM.VillaNumber == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villaNumberVM);
        }
        [HttpPost]
        public IActionResult Delete(VillaNumberVM obj)
        {
            VillaNumber? villaNumber = _unitOfWork.VillaNumber.Get(u => u.Villa_Number == obj.VillaNumber.Villa_Number);
            if (villaNumber is not null)
            {

                _unitOfWork.VillaNumber.Remove(villaNumber);
                _unitOfWork.Save();
                TempData["success"] = "Villa number has been deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "Villa number could not be deleted";

            return View();
        }
    }
}
