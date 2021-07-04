using System;
using System.Collections.Generic;

namespace TicketTracker2._0
{
    class Program
    {
        static void closing(string answer)
        {
          if(answer != "yes")
          {
            Console.WriteLine("Have a Good day !!");
          }
          else
          {
            Console.WriteLine("Lets Continue..");  
          }
        }

        static void displayStats(List<Ticket> li)
        {
            TicketStats cre = new TicketStats();
            TicketStats toSo = new TicketStats();
            TicketStats sol = new TicketStats();

            Console.WriteLine("#############################################################################################################");
            Console.WriteLine("Tickets Created: " + cre.getCreatedTi(li));
            Console.WriteLine("Tickets to Solve: " + toSo.getToSolve(li));
            Console.WriteLine("Solved Tickets: " + sol.getSolved(li));
            Console.WriteLine("##############################################################################################################");
        }

        static void options(List<Ticket> li)
        {
          Console.WriteLine("###############################################################################################################");
          Console.WriteLine("Would you like display all the tickest(option A) ,  Check the stats(option B), Generated a new Ticket(option C) ");
          Console.WriteLine("###############################################################################################################");
          string choice = Console.ReadLine();
          Console.WriteLine("###############################################################################################################");
          if(choice == "A")
          {
            Console.WriteLine("Printing Tickets: ");
            getList(li);    
          }
          else if(choice == "B")
          {
            Console.WriteLine("Displaying Tickets Stats: ");
            displayStats(li); 
          }else 
          {
            Console.WriteLine("Lets generate a Ticket: ");  
            ticketGenerator(li); 
          }
        }


        static void getList(List<Ticket> tiL) //Iterate the List.
        {
          foreach(Ticket tk in tiL)
            {
                int number = tk.getNumberTic();
                string stuffId = tk.getId();
                string name = tk.getName();
                string email = tk.getEmail();
                string description = tk.getDescription();
                string status = tk.getStatus();
                string response = tk.getResponse();
                Console.WriteLine("############################################################");
                Console.WriteLine("The ticket Number: " + number);
                Console.WriteLine("The Creator is: " + name);
                Console.WriteLine("The StuffId: " + stuffId);
                Console.WriteLine("The Email is: " + email);
                Console.WriteLine("The description of the problem is: " + description);
                Console.WriteLine("The Response: " + response);
                Console.WriteLine("The Ticket status is: " + status);
                Console.WriteLine("#############################################################");
            }

            Console.WriteLine("Would you like change the status of the tickets (yes/no) ??");
            string answer = Console.ReadLine();
            if(answer != "no")
            {
                Console.WriteLine("#############################################################");
                Console.WriteLine("Please enter the Ticket Number");
                Console.WriteLine("#############################################################");
                int number = Convert.ToInt32((Console.ReadLine()));
                targetTicket(tiL, number);
            }
        }

        static void ticketGenerator(List<Ticket> tiL)
        {
            Console.WriteLine("##############################################################");
            Console.WriteLine("Are you able to share your personal details(yes/no) ??");
            string details = Console.ReadLine();
            Console.WriteLine("##############################################################");
            Ticket newTicket;// New Ticket Created
            if(details == "yes")
            {
                Console.WriteLine("Please Enter your first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please Enter your surename");
                string surName = Console.ReadLine();    
                Console.WriteLine("Please Enter your email");
                string email = Console.ReadLine();
                Console.WriteLine("Please Describe your problem(This field is compolsory)");
                string desc = Console.ReadLine();

                newTicket = new Ticket(firstName, surName, email, desc);
            }
            else
            {
                Console.WriteLine("Please Describe your problem(This field is compolsory)");
                string desc = Console.ReadLine();

                newTicket = new Ticket(desc);
            }

            tiL.Add(newTicket);
            Console.WriteLine("Ticket Created !! ");
        }

        static void targetTicket(List<Ticket> tiL, int ticketNum)
        {
           foreach(Ticket tk in tiL)
            {
                int number = tk.getNumberTic();
                if(ticketNum == number)
                {
                    Console.WriteLine("#############################################################");
                    Console.WriteLine("The status is: ");
                    string status = tk.getStatus();
                    Console.WriteLine("Please enter the new Status: ");
                    string newStatus = Console.ReadLine();
                    tk.setStatus(newStatus);
                    Console.WriteLine("#############################################################");
                }
            } 
        }

        static void starter()
        {
            string answer = "";
            List<Ticket> ticketList = new List<Ticket>();// Creates a new List
            while(answer != "no")
            {
                // Options Functions
                options(ticketList);
                //Good Bye
                Console.WriteLine("Do you want to continue ??(yes/no)");
                answer = Console.ReadLine();
                closing(answer);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("############################################################");
            Console.WriteLine("############### Welcome Ticket Tracker #####################");
            Console.WriteLine("############################################################");
            starter();
        }
    }
}
