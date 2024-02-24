using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.DTO.Models.Reservation;

namespace TeslaMall.Server.DTO.Models.UserReservation;

public record UserReservationDTO : BaseDTO
{

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }

    [Required]
    public string ReservationId { get; set; }

    [Required]
    public ReservationDTO RelatedReservation { get; set; }

    [Required]
    public int ReservationCode { get; set; }


    public UserReservationDTO(Guid id, string email, string reservationId, ReservationDTO relatedReservation, int reservationCode) : base(id)
    {
        Email = email;
        ReservationId = reservationId;
        RelatedReservation = relatedReservation;
        ReservationCode = reservationCode;
    }
}
