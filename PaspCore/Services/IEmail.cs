using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaspCore.Services
{ 
    public interface IEmail
    {
        /// <summary>
        /// 
        /// </summary>
        void SendEmail(Message message);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        Task SendEmailAsync(Message message);
    }
}
