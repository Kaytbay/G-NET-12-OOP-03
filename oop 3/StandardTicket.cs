using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber):base(movieName, price)
        {
            SeatNumber = seatNumber;
        }


        public override string ToString()
        {
            return $"Ticket ID: {TicketId}, Movie Name: {MovieName}, Price After Tax: {PriceAfterTax}" +
                $" , Seat Numper : {SeatNumber}";
        }
    }
}
