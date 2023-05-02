using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailRequirement1
{
    public class mail
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
        public mail()
        {

        }
        public mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size, long id, string to, string from, string subject, string content, DateTime receivedDate, double size)
        {
            Id = _id;
            To = _to;
            From = _from;
            Subject = _subject;
            Content = _content;
            ReceivedDate = _receivedDate;
            Size = _size;

        }

        public mail(long v1, string v2, string v3, string v4, string v5, DateTime dt, double v6)
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
            return string.Format("Id:{0}\n To:{1}\n From:{2}\n Subject:{3}\n Content:{4}\n ReceivedDate:{5}\n Size:{6}\n");

        }
        public static mail CreateMail(string details)
        {
            string[] s = details.Split(',');
            DateTime dt = DateTime.ParseExact(s[5], "dd-mm-yyyy", null);
            mail mailobj = new mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], dt, double.Parse(s[6]));
            return mailobj;

        }

    }
}


    

