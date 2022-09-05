using BankManagement.DTOs;
using BankManagement.Interface;

namespace BankManagement.Services
{
    public class AccountService : IAccountService
    {
        DBHelper dbHelper = new DBHelper();
        public void RegisterAccount(AccountRegisterDTO accountRegister)
        {
            dbHelper.AddData("sp_BankAccountRegister", ("@Balance", accountRegister.Balance),
                ("@Account_Number", accountRegister.Account_Number), ("@UserId", accountRegister.UserId));
        }
    }
}
