using BankManagement.DTOs;
using BankManagement.Models;
using BankManagement.Services;

namespace BankManagement
{
    public class Program
    {       
        static void Main(string[] args)
        {
            CaseHelper.StartUpMessage();

            UserService _userService = new UserService();
            TransactionService _transactionService = new TransactionService();           

            while (true)
            {
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CaseHelper.RegisterUser();
                        break;
                    case "2":
                        CaseHelper.DisplayUserById();
                        break;
                    case "3":
                        CaseHelper.DisplayUserByRole();
                        break;
                    case "4":
                        CaseHelper.DisplayAllUsers();
                        break;
                    case "5":
                        CaseHelper.RegisterAccount();
                        break;
                    case "6":
                        CaseHelper.CreateTransactionForVender();
                        break;
                    case "7":
                        CaseHelper.DisplayAllTransactions();
                        break;
                    case "8":
                        CaseHelper.DisplayTransactionById();
                        break;
                    case "9":
                        CaseHelper.DisplayTransactionByAccountNumber();
                        break;
                    case "10":
                        CaseHelper.ApproveTransaction();
                        break;
                    case "11":
                        CaseHelper.CreateTransactionForBurrower();
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Please select valid operation");
                        break;
                }
                CaseHelper.StartUpMessage();
            }
        }
    }
}
