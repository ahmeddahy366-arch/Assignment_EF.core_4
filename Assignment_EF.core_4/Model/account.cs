using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment_EF.core_4.Model
{
    public class account
    {
        [Key]
        public int accountNumber { get; set; }
        public string accountType { get; set; }
        public decimal CurrentBalance { get; set; }
        public DateTime openingDate { get; set; }
        public int branchId { get; set; }

        public Branch branch { get; set; }
        public ICollection<transaction> transaction { get; set; }
        public ICollection<AccountCustomer> accountCustomer { get; set; }
    }
}
