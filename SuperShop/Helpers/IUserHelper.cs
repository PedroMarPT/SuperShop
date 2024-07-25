using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entities;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUseerByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
