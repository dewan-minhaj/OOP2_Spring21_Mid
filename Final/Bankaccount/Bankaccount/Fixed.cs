﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccount
{
    class Fixed : Account 
    {
        public int fixedYear { get; set; }
        public int openingYear { get; set; }
        public Fixed(string accName,string accNo,double balance,int openingYear,int fixedYear) : base(accName,accNo,balance)
        {
            this.openingYear = openingYear;
            this.fixedYear = fixedYear;
        }
        public override void Transfer (Account acc, double amount)
        {
            int today = DateTime.Now.Year;
            if(today-openingYear>fixedYear)
            {
                Balance -= amount;
                acc.Balance += amount;
            }
            else
            {
                Console.WriteLine("Account is not valid tor transfer!");
            }
        }
        public override void Withdraw(double amount)
        {
            int today = DateTime.Now.Year;
            if(today-openingYear>fixedYear)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Account is not valid for witdraw!");
            }
        }
    }
}
