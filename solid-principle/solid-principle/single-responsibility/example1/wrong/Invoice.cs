using System;
using System.Net.Mail;

namespace solid_principle.single_responsibility.wrong
{
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        public void AddInvoice()
        {
            try
            {
                // Add invoice here

                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendInvoiceEmail(mailMessage);
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                // Delte invoice here
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        /// <summary>
        /// Violating SRP => Sending email is an extra responsibility
        /// </summary>
        /// <param name="mailMessage"></param>
        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Send email here
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString()); // 
            }
        }
    }
}
