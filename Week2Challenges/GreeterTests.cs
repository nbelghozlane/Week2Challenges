using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week2Challenges
{
    [TestClass]
    public class GreeterTests
    {
        [TestMethod]
        public void GreeterTestMethod()

        {   //Challenge 1:  Build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.

            Greeter greeter = new Greeter();

            string placeholder = greeter.HelloName("Hello", "Nadia");
            Console.WriteLine(placeholder);
         
        }

        [TestMethod]
        public void FarewellTestMethod()

        {   // Challenge 2: Build another method that outputs(writes to the Console) some sort of farewell to the name it is given as a parameter.

            Greeter greeterFarewell = new Greeter();

            string placeholder = greeterFarewell.GoodbyeName("Goodbye", "Nadia");
            Console.WriteLine(placeholder);

        }

        [TestMethod]
        public void GiveATimeOfDayTestMethod()

        {   //Challenge 3: Build a method that outputs(writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.

            Greeter greetingResponse = new Greeter();
            TimeSpan timeNow = DateTime.Now.TimeOfDay;
            int timeNowHrs = timeNow.Hours;
            Console.WriteLine(greetingResponse.GiveATimeOfDay(timeNowHrs));
        }

    }
}
