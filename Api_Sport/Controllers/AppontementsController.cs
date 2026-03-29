using Microsoft.AspNetCore.Mvc;
using Api_Sport.DTOs;
using Api_Sport.Features.Appointments;
using MediatR;

namespace Api_Sport.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentController : ControllerBase
{
    private readonly IMediator _mediator;

    public AppointmentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("add/appointement")]
    public async Task<IActionResult> RegisterAppointement(AppointmentRequest request)
    {
        await _mediator.Send(new CreateAppointmentCommand(request.UserId, request.DateTime, request.Description));
        return Ok(new { message = "Rendez-vous créé avec succès." });
    }

    [HttpGet("retrieve/appointement")]
    public async Task<IActionResult> GetAppointments()
    {
        var appointments = await _mediator.Send(new GetAppointmentsQuery());
        return Ok(appointments);
    }
}
