using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenges
{
    public class Greeter
    {
        //Challenge 1:  Build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.
        public string greeting { get; set; }
        public string givenName { get; set; }


        public string HelloName(string greeting, string givenName)
        {
            string concatenate = greeting + " " + givenName;
            return concatenate;
        }

        // Challenge 2: Build another method that outputs(writes to the Console) some sort of farewell to the name it is given as a parameter.
        public string farewell { get; set; }
        public string givenName2 { get; set; }

        public string GoodbyeName(string farewell, string givenName2)
        {
            string concatenate = farewell + " " + givenName2;
            return concatenate;
        }

        //Challenge 3: Build a method that outputs(writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.
        public int givenHourTime { get; set; }

        public string GiveATimeOfDay(int givenHourTime)
        {
            int checkedTime = givenHourTime;
            string greetingResponse = "";

            if (checkedTime < 12 && checkedTime >= 0)
            {
                greetingResponse = "Good Morning";
            }

            else if (checkedTime >= 12 && checkedTime < 17)
            {
                greetingResponse = "Good Afternoon";
            }

            else if (checkedTime >= 17 && checkedTime < 20)
            {
                greetingResponse = "Good Evening";
            }

            else if (checkedTime >= 20 && checkedTime <= 23)
            {
                greetingResponse = "Good Night";     
            }

                return greetingResponse;
        }
    }
}
