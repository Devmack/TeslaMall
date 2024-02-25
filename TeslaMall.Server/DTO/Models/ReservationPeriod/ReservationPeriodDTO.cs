using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.Exceptions;

namespace TeslaMall.Server.DTO.Models.ReservationPeriod;

public record ReservationPeriodDTO : BaseDTO
{
    public Guid RelatedReservationId { get; init; }

    [Required(ErrorMessage = "Reservation start date is required")]
    public DateTime ReservationStart { get; set; }

    [Required(ErrorMessage = "Reservation end date is required")]
    public DateTime ReservationEnd { get; set; }

    [Range(1, 30, ErrorMessage ="Rental time cannot be longer than 30 days!")]
    public int ReservationLength { get; init; }

    public ReservationPeriodDTO()
    {
        
    }

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
