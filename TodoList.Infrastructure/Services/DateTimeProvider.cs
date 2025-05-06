using TodoList.Application.Common.Interfaces.Services;

namespace TodoList.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
