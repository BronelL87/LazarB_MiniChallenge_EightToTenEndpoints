using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_MiniChallenge_EightToTenEndpoints.Services
{
    public class Magic8BallServices
    {
          string[] magicalResponse = {"Yes, of course!", "Nope!", "I can't answer that right now, try again later.", "certainly.", "my vision on that is not looking so good..", "It's possible!", "Signs point to yes, but I say no.", "If one day the sun sets in the east and rises in the west.. Then the answer is yes.", "You can rely on it.."};

        Random reply = new();

        public string WiseBall(string userQ){

            int randomRes = reply.Next(magicalResponse.Length);

            return magicalResponse[randomRes];
        }
    }
}