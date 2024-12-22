/*Kiedy mówimy, że pole w klasie może mieć typ Concert,
oznacza to, że to pole przechowuje referencję do obiektu typu Concert.*/


namespace ConcertTicketBooking
{
    public class Ticket
    {
        public IConcert Concert; 
        public double Price;
        public int SeatNumber;

        public Ticket(IConcert concert, double price, int seatNumber)
        {
            this.Concert = concert; 
            Price = price;
            SeatNumber = seatNumber;
        }

       
        public void ReserveSeat()
        {
            if (Concert.AvailableSeats > 0)
            {
                Concert.AvailableSeats--;
                Console.WriteLine($"Rezerwacja miejsc {SeatNumber} na {Concert.Name}");
            }
            else
            {
                Console.WriteLine("Brak wolnych miejsc");
            }
        }
    }
}