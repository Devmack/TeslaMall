using TeslaMall.Server.Exceptions;

namespace TeslaMall.Server.Models;

public sealed class ReservationPeriod : BaseModel
{
    public Guid RelatedReservationId {  get; set; }
    public Reservation RelatedReservation { get; set; }
    public DateTime ReservationStart { get; set; }
    public DateTime ReservationEnd { get; set; }
    public int ReservationLength { get => (ReservationEnd - ReservationStart).Days; }

    public ReservationPeriod()
    {
        
    }
    public ReservationPeriod(Guid Id, DateTime reservationStart, DateTime reservationEnd, int maxReservationPeriod = 30) : base(Id)
    {
        ReservationStart = reservationStart;
        ReservationEnd = reservationEnd;
        if (ReservationLength > maxReservationPeriod) throw new DateException($"Your max reservation period cannot exceed {maxReservationPeriod} days");
    }
}
