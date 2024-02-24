using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TeslaMall.Server.DAL.Repository.Contracts;
using TeslaMall.Server.DTO.Models.Reservation;
using TeslaMall.Server.DTO.Models.UserReservation;
using TeslaMall.Server.Models;
using TeslaMall.Server.Services.Contracts;

namespace TeslaMall.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly IReservationRepository reservationRepository;
        private readonly IMapper mapper;
        private readonly IRentCalculatorService calculatorService;

        public RentController(IReservationRepository reservationRepository, IMapper mapper, IRentCalculatorService calculatorService)
        {
            this.reservationRepository = reservationRepository;
            this.mapper = mapper;
            this.calculatorService = calculatorService;
        }

        [HttpPost("/Reservation")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 503)]
        public async Task<ActionResult<ReservationDTO>> CreateReservation([FromBody] ReservationDTO createDTO)
        {   

            var mapped = mapper.Map<Reservation>(createDTO);
            mapped.ReservationPeriod = mapper.Map<ReservationPeriod>(createDTO.ReservationPeriod);
            mapped.CalculateReservationCost(calculatorService);
            createDTO.ReservationCosts = mapped.ReservationCosts;
            await reservationRepository.AddAsync(mapped);


            return Ok(createDTO);
        }

        [HttpPost("/Rent/Confirmed")]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(typeof(string), 503)]
        public async Task<ActionResult<ReservationDTO>> AssignReservation([FromBody] UserReservationDTO userReservationDTO)
        {

            var mapped = mapper.Map<UserReservation>(userReservationDTO);
            var reservation = await reservationRepository.GetSingleAsync(Guid.Parse(userReservationDTO.ReservationId));
            await reservationRepository.ConfirmReservationAsync(reservation, mapped);

            return Created();

        }
    }
}
