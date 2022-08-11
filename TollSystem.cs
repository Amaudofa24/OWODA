using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class AccountOnboarding
    {
        public string CustomerName { get; set; }

        public void CreateAccount()
        {

        }

        public string SendMail()
        {
            return "Email Sent";
        }

        public void CommitCustomerCare()
        {

        }

    }

    internal class CustomerAudit
    {
        void SendQuestionnaires()
        {
            //codes
            //codes
            var comm = new Communications();
            comm.SendMail();
            //codes
        }
    }

   public class Communications
    {
        public string SendMail()
        {
            return "Email Sent";
        }

        public string SendSMS()
        {
            return "SMS Sent";
        }

    }
}
