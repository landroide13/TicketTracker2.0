using System;

namespace TicketTracker2._0
{

   class Password
  {
    private string staffId;
    private int ticketNumber;
    private string timestamp;
    public Password()
    {
      this.staffId = "";
      this.ticketNumber = 0;
      this.timestamp = "";
    }

    public Password(string staffId, int ticketNumber)
    {
      this.staffId = staffId;
      this.ticketNumber = ticketNumber;
      this.timestamp = DateTime.Now.ToString();
    }

    public string genNewPassword()
    {
      string pass1 = staffId.Substring(0,2);
      string pass2 = ticketNumber.ToString("X");

      string timeS1 = timestamp.Substring(0, 1) + timestamp[2];
      
      int numberT = Convert.ToInt32(timeS1);
      string pass3Hex = numberT.ToString("X");
      string newPass = pass1 + pass2 + pass3Hex;
      // Console.WriteLine("New Password: " + newPass);
      return newPass;
    }

  }


}