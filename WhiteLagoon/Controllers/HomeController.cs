using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Models;
using WhiteLagoon.Web.ViewModels;

namespace WhiteLagoon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Villas = _unitOfWork.Villa.GetAll(includeProperties: "VillaAmenity"),
                Nights = 1,
                CheckInDay = DateOnly.FromDateTime(DateTime.Now),
            };
            return View(homeVM);
        }

        public IActionResult Contact()
        {
            return View(_unitOfWork.members);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
