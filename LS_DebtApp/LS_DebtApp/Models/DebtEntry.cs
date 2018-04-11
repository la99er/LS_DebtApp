using System;
using System.Collections.Generic;
using System.Text;

namespace LS_DebtApp.Models
{
    public class DebtEntry
    {
        /// <summary>
        /// The name of the debtor.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The reason, why the user owes or lent sb. the amount of money.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Represents the date, since when the user owes or lends someone the amount of money.
        /// </summary>
        public DateTime Date{ get; set; }

        /// <summary>
        /// The amount of money the user owes or lends someone.
        /// If the amount is negative, the user owes someone,
        /// else: the user lends someone
        /// </summary>
        public double Amount { get; set; }
    }
}
