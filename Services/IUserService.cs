using System.Threading.Tasks;
using Matrix.Services.Models;

namespace Matrix.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string token);
        Task<User> Authenticate(string username, string password);
    }
}