using TodoList.Domain.Entities;

namespace TodoList.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
