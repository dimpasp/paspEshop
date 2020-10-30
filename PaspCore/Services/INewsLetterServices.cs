using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Services
{
    public interface INewsLetterServices
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        string SaveNewClient(string fullName, string email);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<String> GetEmails();
    }

}
