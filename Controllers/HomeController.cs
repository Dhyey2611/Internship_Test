// using Microsoft.AspNetCore.Mvc;
// using Internship_Test.Data;
// using Internship_Test.ViewModel;
// using System.Linq;

// namespace Internship_Test.Controllers
// {
//     public class HomeController : Controller
//     {
//         private readonly DatabaseContext _context;

//         public HomeController(DatabaseContext context)
//         {
//             _context = context;
//         }

//         public IActionResult Index(string search)
//         {
//              var query = _context.Menu_Items.AsQueryable();
//               if (!string.IsNullOrEmpty(search))
//                 {
//               query = query.Where(m => m.Item_Name.ToLower().Contains(search.ToLower()));
//                 }
//             var menuItems = _context.Menu_Items
//                 .Select(m => new MeniItemsViewModel
//                 {
//                     ItemName = m.Item_Name,
//                     Price = m.Item_Price
//                 })
//                 .ToList();

//             return View(menuItems);
//         }
//         [HttpGet]
//         public IActionResult GetUserPopupInfo(int userId)
//         {
//         var viewModel = _context.GetUserPopupInfo(userId);
//         if (viewModel == null) return Json(null);
//         return Json(viewModel);  // ✅ no rewrite
//         }
//     }
// }
using Microsoft.AspNetCore.Mvc;
using Internship_Test.ViewModel;
using Internship_Test.Services;
namespace Internship_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMenuService _menuService;

        public HomeController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public IActionResult Index(string search)
        {
            var allItems = _menuService.GetMenu();

            if (!string.IsNullOrEmpty(search))
            {
                allItems = allItems.Where(m => m.Item_Name.ToLower().Contains(search.ToLower())).ToList();
            }

            var menuItems = allItems.Select(m => new MeniItemsViewModel
            {
                ItemName = m.Item_Name,
                Price = m.Item_Price
            }).ToList();

            return View(menuItems);
        }

        [HttpGet]
        public IActionResult GetUserPopupInfo(int userId)
        {
            var viewModel = _menuService.GetUserPopupInfo(userId);
            if (viewModel == null) return Json(null);
            return Json(viewModel);
        }
    }
}
