﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account : BaseEntity // Inheriting from Base Entity class
    {
        // String that uniquely identifies the account
        public string AccountNumber { get; set; }

        //Title of the account
        public string AccountTitle { get; set; }

        //Available Balance of the account
        public decimal CurrentBalance { get; set; }

        //Account's status 
        public AccountStatus AccountStatus { get; set; }

        // Setting foreign key for 1 to 1 relationship
        [ForeignKey("UserId")]
        public string UserId { get; set; }
        // One Account might have 1 User (1:1 relationship) 
        public virtual User User { get; set; }

        // One Account might have 0 or more Transactions (1:Many relationship)
        public virtual ICollection<Transaction> Transactions { get; set; }
    }

    // Two posible statuses of an account
    public enum AccountStatus
    {
        Active = 1,     // When an account can perform transactions
        InActive = 0    // When an account cannot perform transaction
    }
}
