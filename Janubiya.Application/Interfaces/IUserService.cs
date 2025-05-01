using Janubiya.Domain.Entities;

namespace Janubiya.Application.Interfaces
{
    public interface IUserService
    {
        Task<string> LoginAsync(string username, string password);
        Task<string> RegisterAsync(User user);

    }
}
