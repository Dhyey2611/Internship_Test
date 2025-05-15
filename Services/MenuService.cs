using Internship_Test.Models;
using Internship_Test.Repositories;
using Internship_Test.ViewModel;

using System.Collections.Generic;
namespace Internship_Test.Services
{
public class MenuService : IMenuService
{
    private readonly MenuRepository _menuItemRepository;

    public MenuService(MenuRepository menuItemRepository)
    {
        _menuItemRepository = menuItemRepository;
    }

    public List<Menu_Items> GetMenu()
    {
        return _menuItemRepository.GetMenu();
    }
     public UserPopupViewModel? GetUserPopupInfo(int userId)
    {
        return _menuItemRepository.GetUserPopupInfo(userId);
    }
}
}
