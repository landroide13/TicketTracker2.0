using System;
using System.Collections.Generic;

namespace TicketTracker2._0
{

  class TicketStats
  {
    // private List<Ticket> ticketList;
    private int ticketsOpen;
    private int ticketsClosed;
    private int ticketReop;
    static int numberOpen = 0;
    static int numberClosed = 0;
    static int numberReop = 0;

    public TicketStats(){}

    public int getSolved(List<Ticket> list)
    {
      int solved = 0;
      foreach(Ticket tk in list)
      {
        if(tk.getStatus() == "Close")
        {
          solved++;
        }
      }
      return solved;
    }

    public int getToSolve(List<Ticket> list)
    {
      int solve = 0;
      foreach(Ticket tk in list)
      {
        if(tk.getStatus() == "Open")
        {
          solve++;
        }
      }
      return solve;
    }

    public int getCreatedTi(List<Ticket> list)
    {
      return list.Count;
    }



    



  }


}

