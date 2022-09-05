namespace BankManagement.DTOs
{
    public class TransactionDTO
    {
        public TransactionDTO(int Purpose, string? SenderAccountNumber, string? ReceiverAccountNumber,
        decimal Amount)
        {
            this.Purpose = Purpose;
            this.SenderAccountNumber = SenderAccountNumber;
            this.ReceiverAccountNumber = ReceiverAccountNumber;
            this.Amount = Amount;
        }

        public TransactionDTO(int Status, int TransactionId, int BankerId)
        {
            this.Status = Status;
            this.TransactionId = TransactionId;
            this.BankerId = BankerId;
        }

        public TransactionDTO(int TransactionId, string SenderAccountNumber)
        {
            this.TransactionId = TransactionId;
            this.SenderAccountNumber = SenderAccountNumber;
        }

        public int Purpose { get; set; }
        public string? SenderAccountNumber { get; set; }
        public string? ReceiverAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public int TransactionId { get; set; }
        public int Status { get; set; } = 1;
        public int BankerId { get; set; }

    
    }
}
