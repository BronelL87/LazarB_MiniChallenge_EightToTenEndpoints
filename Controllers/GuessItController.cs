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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices){
            _guessItServices = guessItServices;
        }

        [HttpPost]
        [Route("ModeEasy/{easyInpt}")]

        public string EasyGuess(string easyInpt){
            return _guessItServices.EasyMode(easyInpt);
        }

        [HttpPost]
        [Route("ModeMedium/{medInpt}")]

        public string MediumGuess(string medInpt){
            return _guessItServices.MediumMode(medInpt);
        }

        [HttpPost]
        [Route("ModeHard/{harInpt}")]

        public string HardGuess(string harInpt){
            return _guessItServices.HardMode(harInpt);
        }
    }
}