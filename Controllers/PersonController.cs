using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUT23_Labb3_API.Models;
using SUT23_Labb3_API.Services;

namespace SUT23_Labb3_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private ILabb _labb;
        public PersonController(ILabb labb)
        {
            _labb = labb;
        }


        [HttpGet]
        public async Task<ActionResult<Person>> GetAllPerson()
        {
            try
            {
                return Ok(await _labb.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrive data from Database...");
            }
        }

        [HttpGet("Interest/{id:int}")]
        public async Task<ActionResult<Person>> GetPersonInterest(int id)
        {
            try
            {
                var result = await _labb.GetPersonInterest(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrive data from Database...");
            }
        }


        [HttpGet("Links/{id:int}")]
        public async Task<ActionResult<Person>> GetPersonLink(int id)
        {
            try
            {
                var result = await _labb.GetPersonLinks(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrive data from Database...");
            }
        }

            [HttpPost("AddInterest")]
            public async Task<IActionResult> AddInterest(int personId, int interest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                await _labb.AddPersonInterest(personId, interest);
                return Ok();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to post data to Database...");
            }
        }

        [HttpPost("AddLink")]
        public async Task<IActionResult> AddLinkToPerson(int personId, int interestId, string url)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                await _labb.AddPersonLink(personId, interestId, url);
                return Ok();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to post data to Database...");
            }
        }

    }
}
