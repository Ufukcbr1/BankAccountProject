using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsProject1
{
   public  class Account
    {

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Location { get; set; }
        public decimal Balance { get; set; }
        public int PhoneNumber { get; set; }

        public string AccountType { get; set; }



    }
}
