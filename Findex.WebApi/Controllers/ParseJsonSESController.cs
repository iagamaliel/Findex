using Findex.Utils;
using Findex.WebApi.Models.Responses.Base;
using Microsoft.AspNetCore.Mvc;
using Nelibur.ObjectMapper;

namespace Findex.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ParseJsonSESController : ControllerBase
    {
        public ParseJsonSESController() { }

        [HttpPost("parse")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(GenericResponse))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(GenericResponse))]
        public ActionResult<DataEmail> Post(JsonFormat request)
        {
            try
            {
                return Ok(TinyMapper.Map<DataEmail>(request));
            }
            catch (FormatException ex)
            {
                return BadRequest(new GenericResponse { Code = 0, Message = ex.Message });
            }
            catch (Exception)
            {
                string message = "An error has occurred while parse Json";
                return StatusCode(StatusCodes.Status500InternalServerError, new GenericResponse { Code = 0, Message = message });
            }
        }
    }
}
