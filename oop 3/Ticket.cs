using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace oop_3
{
    internal class Ticket
    {
        public string MovieName { get; set; }

		private decimal _price;

		public decimal Price
		{
			get { return _price; }
			set { _price = value > 0 ? value : 0; }

		}

		private static int _ticketId;

		public int TicketId  => _ticketId; 

		public Ticket(string movieName, decimal price)
		{
			MovieName = movieName;
			Price = price;
			_ticketId++;
        }

		public decimal PriceAfterTax => _price + (0.14m * _price);



        public override string ToString()
        {
			return $"Ticket ID: {TicketId}, Movie Name: {MovieName}, Price After Tax: {PriceAfterTax:C}";
        }


		public static int GetTotalTickets() => _ticketId;


    }
}
