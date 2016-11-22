using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amat_project.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
