using Internship_Test.Models;
using Internship_Test.ViewModel;
using System.Collections.Generic;
namespace Internship_Test.Services
{
    public interface IMenuService
    {
    List<Menu_Items> GetMenu();
    UserPopupViewModel? GetUserPopupInfo(int userId);
    }
}