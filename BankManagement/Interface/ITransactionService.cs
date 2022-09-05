using BankManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Interface
{
    public interface ITransactionService
    {
        void GetTransactionById(int id);
        void GetTransactionByAccountNumber(string accountNumber);
        void GetAllTransactions();
        void CreateTransaction(TransactionDTO transaction);
        void CreateReverseTransaction(TransactionDTO transaction);
        void ApproveTransaction(TransactionDTO transaction);
    }
}
