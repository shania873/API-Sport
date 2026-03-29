using Api_Sport.Data;
using Api_Sport.Models;
using MediatR;

namespace Api_Sport.Features.Appointments;

// Command — ce que le client envoie
public record CreateAppointmentCommand(int UserId, DateTime DateTime, string Description) : IRequest;

// Handler — la logique métier
public class CreateAppointmentHandler : IRequestHandler<CreateAppointmentCommand>
{
    private readonly Api_SportDbContext _context;

    public CreateAppointmentHandler(Api_SportDbContext context)
    {
        _context = context;
    }

    public async Task Handle(CreateAppointmentCommand command, CancellationToken cancellationToken)
    {
        var appointment = new Appointment
        {
            UserId = command.UserId,
            DateTime = command.DateTime,
            Description = command.Description
        };

        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
