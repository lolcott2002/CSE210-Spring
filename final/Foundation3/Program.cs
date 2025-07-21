public class Program
{
    //here I put an event of every type to test the code
    public static void Main(string[] args)
    {
        Console.WriteLine("Here are the events planned right now:\n");


        //example address
        Address lectureAddress = new Address("160 N 18th Ave", "Pocatello", "ID", "83201", "USA");
        //example event
        Lecture lectureEvent = new Lecture(
            "Why no one should eat bananas",
            "This class goes deep into the topic of bananas: how they cause gastrointestinal problems and why they need to be banned. seats are limited (7 people max).",
            "12/25/25",
            "10:00 AM",
            lectureAddress,
            "Dr. Chimp Bananabad",
            7
        );


        Address receptionAddress = new Address("Times Square, 123 New York Street", "New York", "NY", "90012", "USA");
        Reception receptionEvent = new Reception(
            "Ad Watching Party",
            "We finally can afford to put our companie's ad up at Times Square! We are mandating that all employees go celebrate at the watch party. the RSVP is not optional if you would like to remain employed.",
            "01/01/26",
            "12:00 AM",
            receptionAddress,
            "fortune500@gmail.com"
        );
        Address outdoorAddress = new Address("111 N 7 W", "Rexburg", "ID", "83440", "USA");
        OutdoorGathering outdoorEvent = new OutdoorGathering(
            "Watch the sun set",
            "Our scientists have predicted that the sun will be setting on the established date. We encourage everyone to come and experience this incredibel spectical.",
            "07/29/25",
            "9:00 PM",
            outdoorAddress,
            "partly cloudy with a chance of sunset"
        );


        Console.WriteLine("Lecture details (add them here):\n");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lectureEvent.GetLittleDescription());
        Console.WriteLine("\n");


        Console.WriteLine("Reception Details: (add them here):\n");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.GetLittleDescription());
        Console.WriteLine("\n");


        Console.WriteLine("Outdoor Event Details (add them here): \n");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorEvent.GetLittleDescription());
        Console.WriteLine("-\n");
//let the user exit
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
