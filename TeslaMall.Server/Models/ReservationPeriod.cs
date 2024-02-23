using TeslaMall.Server.Exceptions;

namespace TeslaMall.Server.Models;

public sealed class ReservationPeriod : BaseModel
{
    public Guid RelatedReservationId {  get; set; }
    public Reservation RelatedReservation { get; set; }
    public DateTime ReservationStart { get => ReservationStart; set { _ = value.CompareTo(ReservationEnd) < 0 ? value : throw new DateException("Reservation start cannot be later than reservation end ");  } }
    public DateTime ReservationEnd { get => ReservationEnd; set { _ = value.CompareTo(ReservationStart) > 0 ? value : throw new DateException("Reservation end cannot be earlier than reservation start "); } }
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
