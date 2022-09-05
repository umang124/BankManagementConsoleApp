using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.GetModel
{
    public class GetTransaction
    {
        public int TransactionId { get; set; }
        public string? SenderAccountNumber { get; set; }
        public string? ReceiverAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string? TransactionDoneBy { get; set; }
        public int TransactionSuccessed { get; set; }
        public DateTime ProceededAt { get; set; }
    }
}
