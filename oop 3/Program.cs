namespace oop_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region part1

            #region Q01:
            /*
            a) A University has Departments. If the university is closed, the departments no longer exist.  
            b) A Driver uses a Car. The driver does not own the car.
            c) A Dog is an Animal. 
            d) A Team has Players. If the team is deleted, the players still exist. 
            e) A method receives a Logger as a parameter and calls it inside the method only.

             */





            // a) Composition (has a  but strong )


            // b) Accociation  (use a )


            // c) Inheritance  (is a )


            // d) Aggregation (has a but weak )


            //e) Dependency  ( method depend on the logger)

            #endregion


            #region Q02:


            // a) yes he can access it the class , but not from outside the class with an object



            // b)  protected internal can access in the same assembly or in the child classes from other assembly
            //     private protected  access from the child classes in the same assembly only


            //c) sealed with class means that the class cannot be inherited
            //   and sealed with method means that the method cannot be overridde 


            // d) yes i can create object  the sealed restrict only the inheritance 


            #endregion


            #endregion




            #region Part2

            Cinema C1 = new Cinema("Nasr");

            C1.OpenCinema();

            StandardTicket t1 = new StandardTicket("ay r", 120m, "A-5");
            VIPTicket t2 = new VIPTicket("qw y", 200m, true);
            IMAXTicket t3 = new IMAXTicket("a dd", 180m, false);

            C1.AddTicket(t1);
            C1.AddTicket(t2);
            C1.AddTicket(t3);

            C1.PrintAllTickets();

            Console.WriteLine("\n========== Statistics ==========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}\n");


            Console.WriteLine("Booking Ref 1: BK-1");
            Console.WriteLine("Booking Ref 2: BK-2");

            C1.CloseCinema();


            #endregion



        }
    }
}
