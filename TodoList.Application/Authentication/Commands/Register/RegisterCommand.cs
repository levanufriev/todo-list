﻿using ErrorOr;
using MediatR;
using TodoList.Application.Authentication.Common;

namespace TodoList.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
