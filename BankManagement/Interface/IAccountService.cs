using BankManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Interface
{
    public interface IAccountService
    {
        void RegisterAccount(AccountRegisterDTO accountRegister);
    }
}
