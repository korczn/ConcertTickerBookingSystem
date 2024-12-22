namespace ConcertTicketBooking
{
    public class BookingSystem
    {
        public List<IConcert> Concerts;

        public BookingSystem()
        {
            Concerts = new List<IConcert>();
        }

        public void AddConcert(IConcert concert)
        {
            Concerts.Add(concert);
        }

        public Ticket BookTicket(IConcert concert, int seatNumber)
        {
            Ticket ticket = new Ticket(concert, concert.TicketPrice, seatNumber);
            concert.ReserveSeat();
            return ticket;
        }

        public void DisplayConcertsSortedByDate()
        {
            Concerts.Sort((x, y) => x.Date.CompareTo(y.Date));

            foreach (var concert in Concerts)
            {
                Console.WriteLine($"{concert.Name} - {concert.Date.ToShortDateString()} - {concert.Location} - Price: {concert.TicketPrice}");
            }
        }

        public void DisplayConcertsByLocation(string location)
        {
            foreach (var concert in Concerts)
            {
                if (concert.Location.ToLower() == location.ToLower())
                {
                    Console.WriteLine($"{concert.Name} - {concert.Date.ToShortDateString()}");
                }
            }
        }
    }
}