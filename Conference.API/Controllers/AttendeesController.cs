using AutoMapper;
using Conference.BL.Services;
using Conference.DL.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly IAttendeeService AttendeeService;
        private readonly ITalkService talkService;

        public AttendeesController(IAttendeeService AttendeeService, ITalkService talkService)
        {
            this.AttendeeService = AttendeeService;
            this.talkService = talkService;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] Attendee attendee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                attendee = await AttendeeService.Insert(attendee);
                return Ok($"Attendee inserted with id: {attendee.id}");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("{idTalk}")]
        public async Task<IActionResult> Post(int idTalk, [FromBody] Attendee attendee)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                attendee.idTalk = idTalk;
                attendee.talk = await talkService.GetById(idTalk);
                attendee = await AttendeeService.Insert(attendee);
                return Ok($"Attendee inserted");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var attendees = await AttendeeService.GetAll();
                return Ok(attendees);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
