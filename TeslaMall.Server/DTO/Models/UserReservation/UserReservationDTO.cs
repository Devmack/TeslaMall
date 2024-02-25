using System.ComponentModel.DataAnnotations;
using TeslaMall.Server.DTO.Models.Reservation;

namespace TeslaMall.Server.DTO.Models.UserReservation;

public record UserReservationDTO : BaseDTO
{

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }

    [Required]
    public Guid ReservationId { get; set; }


    [Required]
    public int ReservationCode { get; set; }

    public UserReservationDTO()
    {
        
    }


    public UserReservationDTO(Guid id, string email, Guid reservationId, int reservationCode) : base(id)
    {
        Email = email;
        ReservationId = reservationId;
        ReservationCode = reservationCode;
    }
}
