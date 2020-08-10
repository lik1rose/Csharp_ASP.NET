using System;


namespace ControlFlow_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine( "Its Morning.");
            }

            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine( "Its afternoon.");
            }
            else
            {
                Console.WriteLine("Its evening.");
            }

            //bool isGoldCustomer = true;

            //isGoldCustomer = false;

            //float price;

            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its autumn.");
                    break;

                case Season.Summer:
                    Console.WriteLine("Its perfect to go to beach.");
                    break;

                default:
                    Console.WriteLine("IDK.");
                    break;
            }
        }
    }
}
