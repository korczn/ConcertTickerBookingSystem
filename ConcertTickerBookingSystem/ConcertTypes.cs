namespace ConcertTicketBooking
{
    public interface IConcert
    {
        string Name { get; set; }
        DateTime Date { get; set; }
        string Location { get; set; }
        int AvailableSeats { get; set; }
        double TicketPrice { get; set; }

        void ReserveSeat();
    }

    // RegularConcert: standardowy koncert
    public class RegularConcert : IConcert
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int AvailableSeats { get; set; }
        public double TicketPrice { get; set; }

        public RegularConcert(string name, DateTime date, string location, int availableSeats, double ticketPrice)
        {
            Name = name;
            Date = date;
            Location = location;
            AvailableSeats = availableSeats;
            TicketPrice = ticketPrice;
        }

        public void ReserveSeat()
        {
            if (AvailableSeats > 0)
            {
                AvailableSeats--;
                Console.WriteLine($"Zarezerwowano miejsce na koncert {Name} w {Location}. Pozostało {AvailableSeats} miejsc.");
            }
            else
            {
                Console.WriteLine("Brak dostępnych miejsc na koncert.");
            }
        }
    }

    // VIPConcert: ekskluzywny koncert
    public class VIPConcert : IConcert
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int AvailableSeats { get; set; }
        public double TicketPrice { get; set; }
        public bool MeetAndGreet { get; set; } // Specjalne spotkanie z artystami

        public VIPConcert(string name, DateTime date, string location, int availableSeats, double ticketPrice, bool meetAndGreet)
        {
            Name = name;
            Date = date;
            Location = location;
            AvailableSeats = availableSeats;
            TicketPrice = ticketPrice;
            MeetAndGreet = meetAndGreet;
        }

        public void ReserveSeat()
        {
            if (AvailableSeats > 0)
            {
                AvailableSeats--;
                Console.WriteLine($"Zarezerwowano VIP miejsce na koncert {Name} z możliwością spotkania z artystą. Pozostało {AvailableSeats} miejsc.");
            }
            else
            {
                Console.WriteLine("Brak dostępnych VIP miejsc.");
            }
        }
    }

    // OnLineConcert: koncert online
    public class OnLineConcert : IConcert
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int AvailableSeats { get; set; }
        public double TicketPrice { get; set; }
        public string StreamingPlatform { get; set; } // Platforma streamingowa

        public OnLineConcert(string name, DateTime date, string streamingPlatform, double ticketPrice)
        {
            Name = name;
            Date = date;
            Location = "Online";
            AvailableSeats = int.MaxValue; // Brak fizycznych miejsc
            TicketPrice = ticketPrice;
            StreamingPlatform = streamingPlatform;
        }

        public void ReserveSeat()
        {
            Console.WriteLine($"Zarezerwowano bilet online na koncert {Name} na platformie {StreamingPlatform}.");
        }
    }

    // PrivateConcert: koncert dla zamkniętej grupy osób
    public class PrivateConcert : IConcert
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int AvailableSeats { get; set; }
        public double TicketPrice { get; set; }
        public string InvitationCode { get; set; } // Zaproszenie specyficzne dla uczestników

        public PrivateConcert(string name, DateTime date, string location, int availableSeats, double ticketPrice, string invitationCode)
        {
            Name = name;
            Date = date;
            Location = location;
            AvailableSeats = availableSeats;
            TicketPrice = ticketPrice;
            InvitationCode = invitationCode;
        }

        public void ReserveSeat()
        {
            if (AvailableSeats > 0)
            {
                AvailableSeats--;
                Console.WriteLine($"Zarezerwowano miejsce na prywatny koncert {Name}. Kod zaproszenia: {InvitationCode}. Pozostało {AvailableSeats} miejsc.");
            }
            else
            {
                Console.WriteLine("Brak dostępnych miejsc na prywatny koncert.");
            }
        }
    }
}
