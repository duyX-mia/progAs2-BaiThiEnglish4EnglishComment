using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi
{
    class HireInfo
    {
        int id;
        string bookName;
        string hireBy;
        string hireDate;

        public int Id { get => id; set => id = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string HireDate { get => hireDate; set => hireDate = value; }
        public string HireBy { get => hireBy; set => hireBy = value; }
    }
}
