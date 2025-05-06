using TodoList.Application.Common.Interfaces.Persistance;
using TodoList.Domain.Entities;

namespace TodoList.Infrastructure.Persistance;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = [];

    public Task Add(User user)
    {
        _users.Add(user);
        return Task.CompletedTask;
    }

    public Task<User?> GetUserByEmail(string email)
    {
        return Task.FromResult(_users.SingleOrDefault(user => user.Email == email));
    }
}
