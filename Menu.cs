using System;
using Model;
using Controler;

namespace View
{
    public class Menu
    {
        // Container container = new Container();
        TicketControler tc;
        UserControler uc;
        User currentUser;

        public Menu()
        {
            tc = new TicketControler();
            uc = new UserControler();
            currentUser = new User();
            switch (loginSignup())
            {
                case 1:
                    login();
                    break;
                case 2:
                    signUp();
                    break;
            }
            Console.Clear();
           
            userOptions();

        }

        private void signUp()
        {
            Console.WriteLine("Enter a user name:");
            string name = Console.ReadLine();
            Console.WriteLine("Create a password: ");
            string pswd = Console.ReadLine();
            Console.WriteLine("Enter you email");
            string eml = Console.ReadLine();
            User newUser = new User(name, eml, pswd);
            uc.newUser(newUser);
            uc.saveUsers();
            uc.loadUsers();
            currentUser = newUser;
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
            List<User> users = new List<User>();
            users = uc.getUsers();
            Console.WriteLine("Enter your User Name: ");
            string name = Console.ReadLine();
            foreach (User u in users)
            {
                if (u.userName == name)
                {
                    bool pswdCheck = true;
                    while (pswdCheck)
                    {
                        Console.WriteLine("Enter your password: ");
                        string pswd = Console.ReadLine();
                        if (u.password == pswd)
                        {
                            currentUser = u;
                            pswdCheck = false;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Password. Try again.");
                        }
                    }
                }

            }
            if (currentUser == null)
            {
                Console.WriteLine("User Name not found. Please Sign up");
                signUp();
            }
        }

        private void userOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome " + currentUser.userName);
            Console.WriteLine();
            Console.WriteLine("Your Options Are:");
            Console.WriteLine("0) Exit the program");
            Console.WriteLine("1) View all Tickets");
            Console.WriteLine("2) Submit a new Ticket");
            if (currentUser.isManager)
            {
                Console.WriteLine("3) Approve or Deny Ticket");
                Console.WriteLine("4) Promote Employee to Manager");
            }

            int choice = 0;
            bool choosing = true;
            while (choosing)
            {
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please only type in the number of your choice");
                }

                if (currentUser.isManager)
                {
                    if (choice < 0 || choice > 4)//manager's choice
                    {
                        Console.WriteLine("That was an invalid selection");
                        continue;
                    }
                }
                else
                {
                    if (choice < 0 || choice > 2)//employee's choice
                    {
                        Console.WriteLine("That was an invalid selection");
                        continue;
                    }
                }

                choosing = false;
            }

            switch (choice)
            {
                case 0:
                Environment.Exit(0);
                break;
                case 1:
                    printAllTickets();
                    break;
                case 2:
                   submitNewTicket();
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }

        }

        private void printAllTickets()
        {
            List<Ticket> tl = new List<Ticket>();

            foreach (Ticket t in tl)
            {
                Console.WriteLine(t);
                Console.WriteLine();
            }

            userOptions();
        }

        private void submitNewTicket()
        {
            double amt = 0.0;
            string data="";
            bool generating = true;
            while (generating)
            {
                Console.WriteLine("Amount? :");
                if (!double.TryParse(Console.ReadLine(), out amt))
                {
                    Console.WriteLine("Please just enter the decimal value");
                    continue;
                }
                Console.WriteLine("What was the expnse for? :");
                data= Console.ReadLine();
                generating = false;
            }
            Ticket t = new Ticket(currentUser.userName, amt,data);
            tc.addNewTicket(t);
            tc.loadTickets();

            Console.Clear();
            Console.WriteLine("New Ticket successfully submitted");
            userOptions();
        }



    }

}


