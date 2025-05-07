using TodoList.Domain.Entities;

namespace TodoList.Application.Authentication.Common;

public record AuthenticationResult(User User, string Token);
