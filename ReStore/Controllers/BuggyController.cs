using Microsoft.AspNetCore.Mvc;
using System;

namespace ReStore.Controllers
{
    public class BuggyController : BaseApiController
    {
        

        [HttpGet("not-found")]
        public ActionResult GetNotFound()
        {
            return NotFound();
        }
        [HttpGet("bad-request")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ProblemDetails { Title= "This is a bad request!" });
        }
        [HttpGet("unauthorized")]
        public ActionResult GetUnauthorized()
        {
            return Unauthorized();
        }
        [HttpGet("validation-error")]
        public ActionResult GetValidationError()
        {
            ModelState.AddModelError("Problem1", "This is a first error");
            ModelState.AddModelError("Problem2", "This is a second error");
            return ValidationProblem();
        }
        //[HttpGet("server")]
        //public ActionResult GetServerError()
        //{
        //    throw new Exception("This is a server error");
            
        //}
    }
}
