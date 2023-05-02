using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailfolderApplication
{
    public class Mail
    {
        private long _id;
        private string _to;
        private string _from;
        private string _subject;
        private string _content;
        private DateTime _receivedDate;
        private double _size;
        private long v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private DateTime dt;
        private double v6;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }

        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }

        }
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set
            {
                _receivedDate = value;
            }
        }
        public double Size
        {
            get { return _size; }
            set
            {
                _size = value;
            }
        }
        public Mail()
        {

        }
        public Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size, long id, string to, string from, string subject, string content, DateTime receivedDate, double size)
        {
            this.Id = _id;
            this.To = _to;
            this.From = _from;
            this.Subject = _subject;
           this. Content = _content;
           this.ReceivedDate = _receivedDate;
           this.Size = _size;

        }

        public Mail(long v1, string v2, string v3, string v4, string v5, DateTime dt, double v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.dt = dt;
            this.v6 = v6;
        }

        public override string ToString()
        {
            return ($"id:{_id}\nTo:{_to}\nFrom{_from}\nSubject:{_subject}\nContent:{_content}\nReceivedDate:{_receivedDate}\nSize:{_size}");
        }

        public static Mail CreateMail(string details)
        {
            string[] s = details.Split(',');
            DateTime dt = DateTime.ParseExact(s[5], "dd-mm-yyyy", null);
            Mail mailobj = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], dt, double.Parse(s[6]));
            return mailobj;
        }
        
    }
}
    

