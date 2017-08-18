using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Account
    {
        public double Balance { get; set; }
        public string Titular { get; set; }
        public int Number { get; set; }
        
        public Account() { }

        public Account(string titular, int number, double balance)
        {
            this.Titular = titular;
            this.Number = number;
            this.Balance = balance;
        }

        public static List<Account> GetAccounts()
        {
            return new List<Account>()
            {
                new Account("João P", 1, 400),
                new Account("Maria C", 2, 800),
                new Account("Mark C", 3, 1500),
                new Account("Rose C", 4, 800),
                new Account("Kart C", 6, 800),
                new Account("Klint C", 7, 800),
                new Account("Jone C", 5, 800),
                new Account("Pabr C", 8, 800),
                new Account("Rynn C", 9, 800),
                new Account("Bones C", 10, 800),
                new Account("Track C", 11, 800),
            };
        }
    }
}
