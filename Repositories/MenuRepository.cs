using Internship_Test.Data;
using Internship_Test.Models;
using Internship_Test.ViewModel;
using Microsoft.EntityFrameworkCore.Storage;

namespace Internship_Test.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        private readonly DatabaseContext _context;   
        public MenuRepository(DatabaseContext context)
        {
            _context = context;
        }

        public List<Menu_Items> GetMenu()
        {
          return _context.Menu_Items.ToList();
        }
        public UserPopupViewModel? GetUserPopupInfo(int userId)
        {
        var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
        if (user == null) return null;
        var viewModel = new UserPopupViewModel
        {
            Name = user.Name,
            FavouriteItem = user.FavouriteItem,
            PreviousOrder = user.PreviousOrder,
            Address = user.Address,
            RewardInfo = user.RewardInfo,
            RefundAmount = user.RefundAmount,
            WalletAmount = (int)user.WalletAmount,
            BenefitInfo = user.BenefitInfo,
            AppUpdateVersion = user.AppUpdateVersion
        };

        return viewModel;
        }
    }
}