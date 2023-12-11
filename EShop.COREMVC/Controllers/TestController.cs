using EShop.BLL.DTOs.DTOClasesses;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.COREMVC.Models.TestModels;
using Microsoft.AspNetCore.Mvc;

namespace EShop.COREMVC.Controllers
{
    public class TestController : Controller
    {
        readonly ICategoryManager _categoryManager;

        public TestController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public IActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KategoriEkle(CategoryAddPageVM model)
        {
            CategoryDTO categoryDTO = new()
            {
                CategoryName = model.Category.CategoryName,
                Description = model.Category.Description
                
            };

            
            _categoryManager.Add(categoryDTO);

            return RedirectToAction("CategoryIndex");
        }
        public IActionResult CategoryIndex()
        {
            return View();
        }
        public IActionResult CategoryAnyTest()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CategoryAnyTest(CategoryAddPageVM model)
        {
            CategoryDTO categoryDTO = new()
            {
                CategoryName = model.Category.CategoryName,
                Description = model.Category.Description

            };

            if (await _categoryManager.AnyAsync(x => x.CategoryName == model.Category.CategoryName))
            {
                TempData["message"] = "Bu Kategori Zaten Mevcut";
                return RedirectToAction("CategoryAnyTest");
            }
            else
            {
                TempData["message"] = "Bu kategori Mevcut Değil";
            }

            return View();
        }
        public IActionResult CategoryDeleteTest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryDeleteTest(CategoryAddPageVM model)
        {
            CategoryDTO categoryDTO = new()
            {
                CategoryName = model.Category.CategoryName,
                Description = model.Category.Description

            };
            _categoryManager.Sil(categoryDTO.CategoryName);

            return View();
        }
    }
}
