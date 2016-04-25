using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GsVacancy.BLL.Services
{
    public class MessageServices : IEmailSender, ISmsSender
    {
        #region Implementation of IEmailSender

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.FromResult(0);
        }

        #endregion

        #region Implementation of ISmsSender

        public Task SendSmsAsync(string number, string message)
        {
            return Task.FromResult(0);
        }

        #endregion
    }
}
