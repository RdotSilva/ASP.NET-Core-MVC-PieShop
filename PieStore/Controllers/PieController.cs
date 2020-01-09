using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieStore.Models;
using PieStore.ViewModels;

namespace PieStore.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List(int id)
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();

            switch (id)
            {
                case 1:
                    piesListViewModel.Pies = _pieRepository.FruitPies;
                    piesListViewModel.CurrentCategory = "Fruit Pies";
                    break;
                case 2:
                    piesListViewModel.Pies = _pieRepository.CheeseCakes;
                    piesListViewModel.CurrentCategory = "Cheese Cakes";
                    break;
                case 3:
                    piesListViewModel.Pies = _pieRepository.SeasonalPies;
                    piesListViewModel.CurrentCategory = "Seasonal Pies";
                    break;
                case 4:
                    piesListViewModel.Pies = _pieRepository.AllPies;
                    piesListViewModel.CurrentCategory = "All Pies";
                    break;
            }

            return View(piesListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
        }
    }
}
