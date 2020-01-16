using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnyeijeIgboAcademy.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionsId { get; set; }
        public string PayerEmail { get; set; }
        public string PaymentName { get; set; }
        public string RefID { get; set; }
        public string PaymentStatus { get; set; }
        public float Amount { get; set; }
    }
}
