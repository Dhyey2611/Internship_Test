using Internship_Test.Models;
using Internship_Test.ViewModel;
namespace Internship_Test.Repositories
{
    public interface IMenuRepository
    {
        public List<Menu_Items> GetMenu(); 
        UserPopupViewModel? GetUserPopupInfo(int userId);
    }
}