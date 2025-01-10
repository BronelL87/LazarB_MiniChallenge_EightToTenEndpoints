using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LazarB_MiniChallenge_EightToTenEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazarB_MiniChallenge_EightToTenEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
      private readonly Magic8BallServices _magic8BallServices;

      public Magic8BallController(Magic8BallServices magic8BallServices){
        _magic8BallServices = magic8BallServices;
      }

      [HttpPost]
      [Route("GainWisdom/{userQuestion}")]

      public string WisdomPicker(string userQuestion){
        return _magic8BallServices.WiseBall(userQuestion);
      }
    }
}