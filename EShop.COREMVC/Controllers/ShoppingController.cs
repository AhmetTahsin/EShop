using EShop.BLL.DTOs.DTOClasesses;
using EShop.BLL.ManagerServices.Abstracts;
using EShop.COREMVC.Models.PageModels.ShoppingModels;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace EShop.COREMVC.Controllers
{
    
    public class ShoppingController : Controller
    {
        readonly IProductManager _productManager;
        readonly ICategoryManager _categoryManager;
        public ShoppingController(IProductManager productManager, ICategoryManager categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }



        public IActionResult Index(int? page, int? categoryID, ShoppingPageVM model) //Todo:Resimler Gözükmüyor Düzelt
        {

            ShoppingPageVM spVm = new ShoppingPageVM()
            {
                Products = categoryID == null ? _productManager.GetActives().ToPagedList(page ?? 1, 5) : _productManager.Where(x => x.CategoryID == categoryID).ToPagedList(page ?? 1, 5),
                //categoryID null ise aktif ürünleri listele sayfa numarası yok ise 1 yap 5 li listele
                //categoryID null degil ise seçili ise  .... listele
                Categories = _categoryManager.GetActives()

            };
            if (categoryID != null) TempData["catID"] = categoryID;

            return View(spVm);

        }
    }
}
