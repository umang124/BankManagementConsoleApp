using BankManagement.DTOs;
using BankManagement.Models;
using BankManagement.Services;

namespace BankManagement
{
    public static class CaseHelper
    {

        static UserService _userService = new UserService();
        static AccountService _accountService = new AccountService();
        static TransactionService _transactionService = new TransactionService();

        public static void StartUpMessage()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("1. Register User");
            Console.WriteLine("2. Display User By Id");
            Console.WriteLine("3. Display Users By Role");
            Console.WriteLine("4. Display all Users");
            Console.WriteLine("5. Register Account");
            Console.WriteLine("6. Create Transaction for Vender");
            Console.WriteLine("7. Display all Transaction");
            Console.WriteLine("8. Display Transaction By Id");
            Console.WriteLine("9. Display Transaction By AccountNumber");
            Console.WriteLine("10. Approve Transaction (Only for Banker role)");
            Console.WriteLine("11. Create Transaction for Burrower");
            Console.WriteLine("x. for exit");
        }
        public static void RegisterUser()
        {
            Console.WriteLine("\n # Select Role - a. Vender b. Borrower c. Banker");
            string? addrole = Console.ReadLine();
            if (addrole != null)
            {
                if (addrole.Equals("a"))
                {
                    Console.WriteLine("UserName: ");
                    string? UserName = Console.ReadLine();

                    Console.WriteLine("UserPassword: ");
                    string? UserPassword = Console.ReadLine();

                    Console.WriteLine("PhoneNumber: ");
                    string? PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Address: ");
                    string? Address = Console.ReadLine();

                    Console.WriteLine("BirthDate: ");
                    DateTime BirthDate = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("IdentificationNumber: ");
                    string? IdentificationNumber = Console.ReadLine();

                    Console.WriteLine("IdentificationType: 1. Citizenship  2. Driving License  3. Passport");
                    int IdentificationType = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Gender: 1. Male  2. Female  3. Others");
                    int Gender = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Role: 1. Lender  2. Burrower  3. Others");
                    int UserType = Convert.ToInt32(Console.ReadLine());

                    UserDTO user = new UserDTO(UserName, UserPassword, UserType, PhoneNumber, Address, BirthDate, IdentificationNumber, IdentificationType, Gender);
                    _userService.AddUser(user);
                    Console.WriteLine("User Added");
                }

            }
        }
        public static void DisplayUserById()
        {
            Console.WriteLine("Enter your Id: ");
            int userId = Convert.ToInt32(Console.ReadLine());
            _userService.GetUser(userId);
        }
        public static void DisplayUserByRole()
        {
            Console.WriteLine("Display all by : a. Vender   b. Burrower  c. Banker");
            string? getInput = Console.ReadLine();

            if (getInput != null)
            {
                if (getInput.Equals("a"))
                {
                    _userService.GetAllUsersByRole(1);
                }
                else if (getInput.Equals("b"))
                {
                    _userService.GetAllUsersByRole(2);
                }
                else if (getInput.Equals("c"))
                {
                    _userService.GetAllUsersByRole(3);
                }
            }
        }
        public static void RegisterAccount()
        {
            try
            {
                Console.WriteLine("Enter User Id: ");
                int userIdregister = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Account Number: ");
                string? registerAccNumber = Console.ReadLine();

                Console.WriteLine("Enter Balance: ");
                decimal registerbalance = Convert.ToDecimal(Console.ReadLine());

                AccountRegisterDTO registerDTO = new AccountRegisterDTO(registerbalance, registerAccNumber, userIdregister);
                _accountService.RegisterAccount(registerDTO);
                Console.WriteLine("Account registered");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void CreateTransactionForVender()
        {
            try
            {
                Console.WriteLine("Welcome to the Transaction World...");

                Console.WriteLine("Enter Purpose: \n1. Bill Sharing  \n2. Personal Use  \n3. Loan");
                int Purpose = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter SenderAccountNumber: ");
                string? SenderAccountNumber = Console.ReadLine();

                Console.WriteLine("Enter ReceiverAccountNumber: ");
                string? ReceiverAccountNumber = Console.ReadLine();

                Console.WriteLine("Enter Amount: ");
                decimal Amount = Convert.ToDecimal(Console.ReadLine());

                TransactionDTO transaction = new TransactionDTO(Purpose, SenderAccountNumber, ReceiverAccountNumber, Amount);
                _transactionService.CreateTransaction(transaction);
                Console.WriteLine("You transaction is added, Please wait for your transaction approval by banker");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void DisplayTransactionById()
        {
            Console.WriteLine("Enter Transaction Id: ");
            int getId = Convert.ToInt32(Console.ReadLine());
            _transactionService.GetTransactionById(getId);
        }
        public static void DisplayTransactionByAccountNumber()
        {
            Console.WriteLine("Enter your Account Number: ");
            string? accountNumber = Console.ReadLine();
            if (accountNumber != null)
                _transactionService.GetTransactionByAccountNumber(accountNumber);
        }

        public static void ApproveTransaction()
        {
            Console.WriteLine("Enter Transaction Id: ");
            int transactionId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter you Id: ");
            int bankerId = Convert.ToInt32(Console.ReadLine());

            TransactionDTO approveTransaction = new TransactionDTO(1, transactionId, bankerId);
            _transactionService.ApproveTransaction(approveTransaction);

            Console.WriteLine("Transaction approve success");
        }

        public static void CreateTransactionForBurrower()
        {
            Console.WriteLine("Enter Transaction Id: ");
            int transactionID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Account Number: ");
            string? burrowerAccountNumber = Console.ReadLine();

            if (burrowerAccountNumber != null)
            {
                TransactionDTO reverseTransaction = new TransactionDTO(transactionID, burrowerAccountNumber);
                _transactionService.CreateReverseTransaction(reverseTransaction);
                Console.WriteLine("Reverse Transaction successed");
            }
        }

        public static void DisplayAllUsers()
        {
            _userService.GetAllUsers();
        }

        public static void DisplayAllTransactions()
        {
            _transactionService.GetAllTransactions();
        }

    }
}
