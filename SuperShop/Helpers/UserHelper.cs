using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entities;
using System;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> _userManeger;

        public UserHelper(UserManager<User> userManeger)
        {
            _userManeger = userManeger;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _userManeger .FindByEmailAsync(email);
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await _userManeger.CreateAsync(user, password);
        }

        public async Task<User> GetUseerByEmailAsync(string email)
        {
            return await _userManeger.FindByEmailAsync(email);
        }
    }
}
