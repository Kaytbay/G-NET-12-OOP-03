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



        }
    }
}
