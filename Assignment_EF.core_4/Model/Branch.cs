using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EF.core_4.Model
{
    public class Branch
    {
        public int code { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public int managerid { get; set; }
        public manager manager { get; set; }
        public ICollection<account> accounts { get; set; }
    }
}
