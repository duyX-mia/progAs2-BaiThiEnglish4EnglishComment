using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi
{
    public class BookInfo
    {
        int id;
        string bookName;
        string author;
        string publishDate;
        string publishBy;
        string country;
        string topic;
        string category;
        string type;
        int pageCount;

        public int Id { get => id; set => id = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string Author { get => author; set => author = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string PublishBy { get => publishBy; set => publishBy = value; }
        public string Country { get => country; set => country = value; }
        public string Topic { get => topic; set => topic = value; }
        public string Category { get => category; set => category = value; }
        public string Type { get => type; set => type = value; }
        public int PageCount { get => pageCount; set => pageCount = value; }
    }
}
