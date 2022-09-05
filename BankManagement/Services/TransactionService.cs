using BankManagement.DTOs;
using BankManagement.GetModel;
using BankManagement.Interface;
using System.Transactions;

namespace BankManagement.Services
{
    public class TransactionService : ITransactionService
    {
        DBHelper dBHelper = new DBHelper();


        public void GetTransactionById(int id)
        {
            List<GetTransaction> transactions = dBHelper.ReadAllData<GetTransaction>("", ("@Id", id));

            foreach (GetTransaction transaction in transactions)
            {
                string transactionOutput = "";
                if (transaction.TransactionSuccessed == 1)
                {
                    transactionOutput = "Transaction Successed";
                }
                if (transaction.TransactionSuccessed == 0)
                {
                    transactionOutput = "Transaction Pending";
                }
                Console.WriteLine("=================================================================");
                Console.WriteLine("\nTransactionId: " + transaction.TransactionId +
                    "\nSenderAccountNumber: " + transaction.SenderAccountNumber +
                    "\nReceiverAccountNumber: " + transaction.ReceiverAccountNumber +
                    "\nAmount: " + transaction.Amount +
                    "\nTransactionDoneBy: " + transaction.TransactionDoneBy +
                    "\nTransactionSuccessed: " + transactionOutput + "\nProceededAt: " + transaction.ProceededAt);

            }
            Console.WriteLine("======================================================================");
        }
        public void GetTransactionByAccountNumber(string accountNumber)
        {
            List<GetTransaction> transactions = dBHelper.ReadAllData<GetTransaction>("getTransactionByAccountNumber", ("@Account_Number", accountNumber));
            foreach (GetTransaction transaction in transactions)
            {
                string transactionOutput = "";
                if (transaction.TransactionSuccessed == 1)
                {
                    transactionOutput = "Transaction Successed";
                }
                if (transaction.TransactionSuccessed == 0)
                {
                    transactionOutput = "Transaction Pending";
                }
                Console.WriteLine("=================================================================");
                Console.WriteLine("\nTransactionId: " + transaction.TransactionId +
                    "\nSenderAccountNumber: " + transaction.SenderAccountNumber +
                    "\nReceiverAccountNumber: " + transaction.ReceiverAccountNumber +
                    "\nAmount: " + transaction.Amount +
                    "\nTransactionDoneBy: " + transaction.TransactionDoneBy +
                    "\nTransactionSuccessed: " + transactionOutput + "\nProceededAt: " + transaction.ProceededAt);

            }
            Console.WriteLine("======================================================================");
        }

        public void GetAllTransactions()
        {
            List<GetTransaction> transactions = dBHelper.ReadAllData<GetTransaction>("getAllTransaction");

            foreach (GetTransaction transaction in transactions)
            {
                string transactionOutput = "";
                if (transaction.TransactionSuccessed == 1)
                {
                    transactionOutput = "Transaction Successed";
                }
                if (transaction.TransactionSuccessed == 0)
                {
                    transactionOutput = "Transaction Pending";
                }
                Console.WriteLine("=================================================================");
                Console.WriteLine("\nTransactionId: " + transaction.TransactionId +
                    "\nSenderAccountNumber: " + transaction.SenderAccountNumber +
                    "\nReceiverAccountNumber: " + transaction.ReceiverAccountNumber +
                    "\nAmount: " + transaction.Amount +
                    "\nTransactionDoneBy: " + transaction.TransactionDoneBy +
                    "\nTransactionSuccessed: " + transactionOutput + "\nProceededAt: " + transaction.ProceededAt);

            }
            Console.WriteLine("======================================================================");
        }

        public void CreateTransaction(TransactionDTO transaction)
        {
            dBHelper.AddData("sp_UserTransaction", ("@Purpose", transaction.Purpose),
                    ("@SenderAccountNumber", transaction.SenderAccountNumber), ("@ReceiverAccountNumber", transaction.ReceiverAccountNumber),
                    ("@Amount", transaction.Amount));
        }

        public void CreateReverseTransaction(TransactionDTO transaction)
        {
            dBHelper.AddData("sp_ReverseTransaction", ("@TransactionId", transaction.TransactionId),
                ("@SenderAccountNumber", transaction.SenderAccountNumber));
        }

        public void ApproveTransaction(TransactionDTO transaction)
        {
            dBHelper.AddData("sp_Banker", ("@Status", transaction.Status), ("@TransactionId", transaction.TransactionId),
                ("@BankerId", transaction.BankerId));
        }

    }
}
