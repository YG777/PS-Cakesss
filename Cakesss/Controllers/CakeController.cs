using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cakesss.Models;
using Cakesss.ViewModels;

namespace Cakesss.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CakeController(ICakeRepository cakeRepository, ICategoryRepository categoryRepository)
        {
            _cakeRepository = cakeRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            CakesListViewModel cakesListViewModel = new CakesListViewModel();
            cakesListViewModel.Cakes = _cakeRepository.Cakes;
            cakesListViewModel.CurrentCategory = "cheesecakes";
            return View(cakesListViewModel);
        }

    }
}
