using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.DTO.Models;
using TeslaMall.Server.DTO.Models.Reservation;
using TeslaMall.Server.Exceptions;

namespace TeslaMall.Server.DTO.Models.ReservationPeriod;

public record ReservationPeriodDTO : BaseDTO
{
    public Guid RelatedReservationId { get; init; }

    public ReservationDTO RelatedReservation { get; init; }

    [Required(ErrorMessage = "Reservation start date is required")]
    public DateTime ReservationStart { get; init; }

    [Required(ErrorMessage = "Reservation end date is required")]
    public DateTime ReservationEnd { get; init; }

    public int ReservationLength { get; init; }

    public ReservationPeriodDTO(Guid id, DateTime reservationStart, DateTime reservationEnd, int maxReservationPeriod = 30) : base(id)
    {
        if (reservationStart.CompareTo(reservationEnd) >= 0)
        {
            throw new DateException("Reservation start cannot be later than or equal to reservation end");
        }

        if ((reservationEnd - reservationStart).Days > maxReservationPeriod)
        {
            throw new DateException($"Your max reservation period cannot exceed {maxReservationPeriod} days");
        }

        ReservationStart = reservationStart;
        ReservationEnd = reservationEnd;
        ReservationLength = (reservationEnd - reservationStart).Days;
    }
}
