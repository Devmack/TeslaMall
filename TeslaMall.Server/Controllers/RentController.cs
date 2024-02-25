using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TeslaMall.Server.DAL.Repository.Contracts;
using TeslaMall.Server.DTO.Models;
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

        [HttpPost]
        [Route("/Confirmation")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 503)]
        public async Task<ActionResult<UserReservationDTO>> AssignReservation([FromBody] UserReservationDTO userReservationDTO)
        {
            var mapped = mapper.Map<UserReservation>(userReservationDTO);
            var reservation = await reservationRepository.GetSingleAsync(userReservationDTO.ReservationId);
            await reservationRepository.ConfirmReservationAsync(reservation, mapped);

            return Ok(userReservationDTO);

        }

        [HttpPost]
        [Route("/UserReservation")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 503)]
        public async Task<ActionResult<ReservationDTO>> GetUserReservation([FromBody] ReservationCredentialsDTO userReservationDTO)
        {
            var reservationFound = await reservationRepository.GetReservationOfByUserAssignedAsync(userReservationDTO.Email);
            if (userReservationDTO.Code != reservationFound.ReservationCode) throw new Exception("Invalid reservation code");
            var fetchedReservation = await reservationRepository.GetSingleAsync(Guid.Parse(reservationFound.ReservationId));
            var mapped = mapper.Map<ReservationDTO>(fetchedReservation);

            return Ok(mapped);

        }

        [HttpPost]
        [Route("/CancelReservation")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 503)]
        public async Task<ActionResult<bool>> CancelReservation([FromBody] ReservationCredentialsDTO userReservationDTO)
        {
            var reservationFound = await reservationRepository.GetReservationOfByUserAssignedAsync(userReservationDTO.Email);
            if (userReservationDTO.Code != reservationFound.ReservationCode) throw new Exception("Invalid reservation code");
            var fetchedReservation = await reservationRepository.GetSingleAsync(Guid.Parse(reservationFound.ReservationId));
            fetchedReservation.CancelReservation();
            await reservationRepository.UpdateAsync(fetchedReservation);
            await reservationRepository.RemoveAsync(fetchedReservation);
            await reservationRepository.RemoveUserReservation(reservationFound);

            return Ok(true);

        }

    }
}
