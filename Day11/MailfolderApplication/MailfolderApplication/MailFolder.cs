using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailfolderApplication
{
    public class MailFolder
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private List<Mail> _maillist;
        public List<Mail> Maillist

        {
            get { return _maillist; }
            set { _maillist = value; }
        }
        public MailFolder()
        {

        }

        public MailFolder(string Name, List<Mail> mailList)
        {
            _name = Name;
            _maillist = mailList;
        }
        public  void  AddMailToFolder(Mail mail)
        {
            Maillist.Add(mail);

        }
        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (var item in Maillist)
            {
                if (item.Id == id)
                {

                    Maillist.Remove(item);
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayMails()
        {
            if (Maillist.Count > 0)
            {
                foreach (var item in Maillist)
                {
                    Console.WriteLine("mail{0}", Name);
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("No mails to show");
            }
        }
    }
}
