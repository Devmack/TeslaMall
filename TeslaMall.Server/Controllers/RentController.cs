using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TeslaMall.Server.DAL.Repository.Contracts;
using TeslaMall.Server.DTO.Models.Reservation;
using TeslaMall.Server.Models;

namespace TeslaMall.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly IReservationRepository reservationRepository;
        private readonly IMapper mapper;

        public RentController(IReservationRepository reservationRepository, IMapper mapper)
        {
            this.reservationRepository = reservationRepository;
            this.mapper = mapper;
        }

        [HttpPost("/Reservation")]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(typeof(string), 503)]
        public async Task<ActionResult<ReservationDTO>> CreateReservation([FromBody] ReservationDTO createDTO)
        {   

            var mapped = mapper.Map<Reservation>(createDTO);
            await reservationRepository.AddAsync(mapped);

            return BadRequest();
        }

        [HttpPost("/Reservation/Confirmed")]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(typeof(string), 503)]
        public async Task<ActionResult<ReservationDTO>> AssignReservation([FromBody] UserReservation userReservationDTO)
        {

            var mapped = mapper.Map<UserReservation>(userReservationDTO);
            var reservation = await reservationRepository.GetSingleAsync(Guid.Parse(userReservationDTO.ReservationId));
            await reservationRepository.ConfirmReservationAsync(reservation, mapped);

            return Created();

        }
    }
}
