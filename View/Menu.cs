using System;
using Model;
//using Controler;

namespace View
{
    public class Menu
    {
       // Container container = new Container();
        public Menu()
        {
            switch (loginSignup())
            {
                case 1:
                    //login();
                    break;
                case 2:
                  
                  //login()
                    break;
            }

          //Console.WriteLine( container.printEmp());

        }

        private int loginSignup()
        {
            bool choosing = true;
            int choice = 0;
            while (choosing)
            {
                Console.WriteLine("1) Login");
                Console.WriteLine("2) Sign up");


                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
                {
                    Console.WriteLine("Please just enter 1 or 2");
                    continue;
                }
                choosing = false;
            }
            return choice;
        }

        private void login()
        {  
            

        }
       
    }


}