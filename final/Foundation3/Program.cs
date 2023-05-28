using System;

class Program
{
    static void Main(string[] args)
    {
        Address[] addresses =  new Address[3];
        addresses[0] = new Address("8280 N 34th Sts", "Omaha", "Nebraska", "68112", "United States");
        addresses[1] = new Address("3204 Euclid Way", "Mckinney", "Texas", "75071", "United States");
        addresses[2] = new Address("Champ de Mars", "Anatole", "Paris", "75007", "France");

        Event[] events =  new Event[3];
        events[0] = new LectureEvent("Introduction to Business","Learn the basics of running a small business","05/31/2023","9:00am",addresses[0],"James","50 People");
        events[1] = new ReceptionEvent("Caitlyn and Stephen's Wedding","Join us celebrating Caitlyn and Stephen's Wedding","09/16/2024","06:00pm",addresses[1],"s&c916@gmail.com");
        events[2] = new OutdoorGatheringEvent("Exploring Effiel Tower","Let's go visit the Effiel Tower and make some amazing memories!","12/31/2023","4:00pm",addresses[2],"Sunny");

        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Event No: {i + 1}");
            Console.WriteLine("\n-STANDARD DETAILS-");
            Console.WriteLine(events[i].StandardDetails());
            Console.WriteLine("-SHORT DETAILS- ");
            Console.WriteLine(events[i].ShortDetails());
            Console.WriteLine("-FULL DETAILS-");
            Console.WriteLine(events[i].FullDetails());
            
        }
    }
}