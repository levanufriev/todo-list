using TodoList.Domain.Entities;

namespace TodoList.Application.Common.Interfaces.Persistance;

public interface IUserRepository
{
    Task<User?> GetUserByEmail(string email);
    Task Add(User user);
}
