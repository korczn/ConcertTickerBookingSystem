namespace ConcertTicketBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Tworzenie obiektów koncertów
            RegularConcert concert1 = new RegularConcert("Sylwester", new DateTime(2024, 12, 31), "Zakopane", 2500, 120.50);
            VIPConcert concert2 = new VIPConcert("Coachella", new DateTime(2025, 4, 11), "Indio", 80000, 500.00, true);
            OnLineConcert concert3 = new OnLineConcert("Jazz & Chill", new DateTime(2025, 4, 20), "YouTube", 20.00);
            PrivateConcert concert4 = new PrivateConcert("Exclusive Event", new DateTime(2025, 5, 15), "Private Venue", 50, 1000.00, "XYZ123");

            // Tworzenie systemu rezerwacji
            BookingSystem bookingSystem = new BookingSystem();

            // Dodawanie koncertów do systemu
            bookingSystem.AddConcert(concert1);
            bookingSystem.AddConcert(concert2);
            bookingSystem.AddConcert(concert3);
            bookingSystem.AddConcert(concert4);

            // Wyświetlanie koncertów posortowanych po dacie
            Console.WriteLine("Koncerty sortowane po dacie:");
            bookingSystem.DisplayConcertsSortedByDate();
            Console.WriteLine();

            // Rezerwacja biletu
            Ticket ticket = bookingSystem.BookTicket(concert1, 10);
            Console.WriteLine($"Bilety na {concert1.Name} - miejsca: {ticket.SeatNumber}, cena: {ticket.Price}");

            // Wyświetlanie koncertów w określonej lokalizacji
            Console.WriteLine("\nKoncerty w danej lokalizacji:");
            bookingSystem.DisplayConcertsByLocation("Indio");
        }
    }
}