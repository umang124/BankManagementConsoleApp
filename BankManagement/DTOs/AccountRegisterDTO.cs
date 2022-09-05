namespace BankManagement.DTOs
{
    public class AccountRegisterDTO
    {
        public AccountRegisterDTO(decimal Balance, string? Account_Number, int UserId)
        {
            this.Balance = Balance;
            this.Account_Number = Account_Number;
            this.UserId = UserId;
        }
        public decimal Balance { get; set; }
        public string? Account_Number { get; set; }
        public int UserId { get; set; }
        
    }
}
