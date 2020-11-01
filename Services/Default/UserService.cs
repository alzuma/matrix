using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Matrix.Controllers.Exceptions;
using Matrix.Services.Models;
using Microsoft.Extensions.DependencyInjection;
using ServiceLocator;

namespace Matrix.Services.Default
{
    [Service(ServiceLifetime.Scoped)]
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>
        {
            new User {Id = Guid.NewGuid(), Token = "Turnip", Username = "baldrick", Password = "42"}
        };

        public async Task<User> Authenticate(string token)
        {
            var user = _users.FirstOrDefault(u => u.Token == token);
            return await Task.FromResult(user);
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                throw new UserOrPasswordException("Username or Password not correct");
            }
            return await Task.FromResult(user);
        }
    }
}