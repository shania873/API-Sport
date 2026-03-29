using Api_Sport.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Api_Sport.Features.Appointments;

// Query — représente la demande de lecture
public record GetAppointmentsQuery : IRequest<List<AppointmentDto>>;

// DTO de réponse
public record AppointmentDto(int Id, int UserId, DateTime DateTime, string Description, DateTime CreatedAt);

// Handler — la logique de lecture
public class GetAppointmentsHandler : IRequestHandler<GetAppointmentsQuery, List<AppointmentDto>>
{
    private readonly Api_SportDbContext _context;

    public GetAppointmentsHandler(Api_SportDbContext context)
    {
        _context = context;
    }

    public async Task<List<AppointmentDto>> Handle(GetAppointmentsQuery query, CancellationToken cancellationToken)
    {
        return await _context.Appointments
            .Select(a => new AppointmentDto(a.Id, a.UserId, a.DateTime, a.Description, a.CreatedAt))
            .ToListAsync(cancellationToken);
    }
}
