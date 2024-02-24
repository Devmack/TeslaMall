
namespace TeslaMall.Server.Models;

public sealed class UserReservation : BaseModel
{

    public string Email { get; set; }
    public string ReservationId { get; set;}
    public Reservation RelatedReservation { get; set; }
    public int ReservationCode { get; set; }

    public UserReservation()
    {
        
    }
    public UserReservation(string email, string reservationId, Reservation relatedReservation, int reservationCode)
    {
        Email = email;
        ReservationId = reservationId;
        RelatedReservation = relatedReservation;
        ReservationCode = reservationCode;
    }

    public override bool Equals(object? obj)
    {
        return obj is UserReservation reservation &&
               Id.Equals(reservation.Id) &&
               Email == reservation.Email &&
               ReservationId == reservation.ReservationId &&
               EqualityComparer<Reservation>.Default.Equals(RelatedReservation, reservation.RelatedReservation) &&
               ReservationCode == reservation.ReservationCode;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Email, ReservationId, RelatedReservation, ReservationCode);
    }
}
