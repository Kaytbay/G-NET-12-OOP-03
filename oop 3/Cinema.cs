using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    internal class Projector
    {
        public void Start()
        {
            Console.WriteLine("Projector Start.");
        }

        public void Stop()
        {
            Console.WriteLine("Projector stop.");
        }
    }
    internal class Cinema
    {
        public string CinemaName { get; set; }
        private Ticket[] _tickets;

        private Projector projector;

        private int counter;


        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            _tickets = new Ticket[20];
            counter = 0;
            projector = new Projector();
        }

        public void AddTicket(Ticket t)
        {
            if (counter < _tickets.Length)
            {
                _tickets[counter] = t;
                counter++;
            }
        }


        public void PrintAllTickets()
        {
            for (int i = 0; i < counter; i++)
            {
                System.Console.WriteLine(_tickets[i].ToString());
            }
        }

        public void OpenCinema()
        {
            projector.Start();
        }

        public void CloseCinema()
        {
            projector.Stop();
        }

        private static int i = 0;
        public static string GenerateReference()
        {
            i++;

            return $"BK-{i}";
        }

    }
}
