using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LazarB_MiniChallenge_EightToTenEndpoints.Services
{
    public class GuessItServices
    {
        int realNum;
        public string EasyMode(string userEasy){
            if(int.TryParse(userEasy, out realNum)){
                Random randomNum = new Random();
                int ezRange = randomNum.Next(1,11);
                
                if(realNum > 10 || realNum < 1){
                    return "Your input must be between 1 and 10";
                }else if(realNum < ezRange){
                    return "Thats too low! Try again.";
                }else if(realNum > ezRange){
                    return "That's too high! Try again.";
                }else{
                    return $"Good job! You guessed {ezRange} right!";
                }

            }else{
                return "Invalid Data Type. Input must be an integer.";
            }
        }

        public string MediumMode(string userMedium){           
            if(int.TryParse(userMedium, out realNum)){
                 Random randomNum = new Random();
                int medRange = randomNum.Next(1,51);

                if(realNum > 50 || realNum < 1){
                    return "Your input must be between 1 and 50";
                }else if(realNum < medRange){
                    return "That's too low! Try again.";
                }else if(realNum > medRange){
                    return "That's too high! Try again.";
                }else{
                    return $"Good job! You guessed {medRange} right!";
                }
            }else{
                return "Invalid Data Type. Input must be an Integer.";
            }
        }

        public string HardMode(string userHard){
            if(int.TryParse(userHard, out realNum)){
                Random randomNum = new Random();
                int harRange = randomNum.Next(1,101);
                
                  if(realNum > 100 || realNum < 1){
                    return "Your input must be between 1 and 100";
                }else if(realNum < harRange){
                    return "That's too low! Try again.";
                }else if(realNum > harRange){
                    return "That's too high! Try again.";
                }else{
                    return $"Good job! You guessed {harRange} right!";
                }
            }else{
                return "Invalid Data Type. Input must be an Integer.";
            }
        }
    }
}