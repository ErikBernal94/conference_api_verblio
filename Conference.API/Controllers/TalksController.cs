using AutoMapper;
using Conference.BL.DTOs;
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
    public class TalksController : ControllerBase
    {
        private readonly ITalkService talkService;
        private readonly IMapper mapper;

        public TalksController(ITalkService talkService, IMapper mapper)
        {
            this.talkService = talkService;
            this.mapper = mapper;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] Talk talk)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                talk = await talkService.Insert(talk);
                return Ok($"Talk inserted with id: {talk.id}");
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
                var talks = await talkService.GetAll();
                var talksDto = talks.Select(t => mapper.Map<TalkDto>(t));
                return Ok(talksDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await talkService.Delete(id);
                return Ok($"Talk with id: {id}, deleted");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
