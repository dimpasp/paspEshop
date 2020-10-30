using PaspCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaspCore.Services
{
    public class NewsLetterServices : INewsLetterServices
    {
        public IList<string> GetEmails()
        {
            //var query = _session.Query<NewsLetter>();
            //var emails = query.Where(x => x.Email != null).Select(x => x.Email).ToList();
            //return emails;
            throw new NotImplementedException();
        }

        public string SaveNewClient(string fullName, string email)
        {
            var client = new NewsLetter
            {
                FullName = fullName,
                Email = email,                
                DateCreated = DateTime.Now

            };
            try
            {
                //MtDepResolver.Get<INewsLetter>().SaveOrUpdate(client);
                return "Welcome .";
            }
            catch (Exception e)
            {
                return "Available.";
            }
        }
    }
}
