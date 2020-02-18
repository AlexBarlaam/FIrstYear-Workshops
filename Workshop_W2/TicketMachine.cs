using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M
{
    //class TicketMachine models a simple ticket machine
    //It prints a ticket of a single price if there is enough money
    class TicketMachine
    {
        //fields and properties
        private float _ticketPrice;
        private float _balance;
        private float _total;

        public float ticketPrice {
            set { if(value >= 0){
                    _ticketPrice = value;
                }
                else
                {
                    Console.WriteLine("Error ticket price must be postive");
                }
            }
            get { return _ticketPrice; }
        }

        //methods
        //insertMoney - receive an amount of money from the customer
        //parameter: int
        //return: void
        public void insertMoney(int amount)
        {

        }

        //printTicket - simulate the output of a ticket
        //parameter: none
        //return: void
        public void printTicket()
        {

        }

        //status - returns the current total of money in this machine
        //parameter: none
        //return: void
        public void status()
        {

        }


    }
}
