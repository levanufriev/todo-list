﻿using Microsoft.AspNetCore.Mvc;

namespace TodoList.Api.Controllers;

public class ErrorsController : ControllerBase
{
    //[Route("/error")]
    //public IActionResult Error()
    //{
    //    var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

    //    //var (statusCode, message) = exception switch
    //    //{
    //    //    IServiceException serviceException => ((int)serviceException.StatusCode, serviceException.ErrorMessage),
    //    //    _ => (StatusCodes.Status500InternalServerError, "An unexpected error occured")
    //    //};

    //    return Problem(/*statusCode: statusCode, title: message*/);
    //}
}
