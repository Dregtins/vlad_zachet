using Microsoft.AspNetCore.Mvc;
namespace ForOC.Controllers
{
    // Controllers/HealthCheckController.cs
   
       [ApiController]
       [Route("api/[controller]")]
       public class HealthCheckController : ControllerBase
       {
           [HttpGet]
           public IActionResult Get()
           {
               return Ok(new { Status = "Healthy" });
           }
        }
    

}
