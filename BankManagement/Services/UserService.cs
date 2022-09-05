using BankManagement.Interface;
using BankManagement.Models;
using BankManagement.ViewModel;

namespace BankManagement.Services
{
    public class UserService : IUserService
    {
        DBHelper dBHelper = new DBHelper();
        public void AddUser(UserDTO user)
        {
            dBHelper.AddData("sp_SignUpUserRegister", ("@UserName", user.UserName),
                    ("@UserPassword", user.UserPassword),
                    ("@UserType", user.UserType), ("@PhoneNumber", user.PhoneNumber), ("@Address", user.Address),
                    ("@BirthDate", user.BirthDate), ("@IdentificationNumber", user.IdentificationNumber),
                    ("@IdentificationType", user.IdentificationType), ("@Gender", user.Gender));
        }
        public void GetUser(int id)
        {
            List<GetUser> getUsers = dBHelper.ReadAllData<GetUser>("sp_viewUserById", ("@UserId", id));
            foreach (GetUser user in getUsers)
            {
                Console.WriteLine("\nId: " + user.Id + "\nUserName: " + user.UserName +
                                "\nUserPassword: " + user.UserPassword + "\nUserType: " + user.UserType +
                                "\nPhoneNumber: " + user.PhoneNumber + "\nAddress: " + user.Address +
                                "\nBirthDate: " + user.BirthDate + "\nIdentificationNumber: " + user.IdentificationNumber +
                                "\nIdentificationType: " + user.IdentificationType + "\nGender: " + user.Gender + "\nAccount Number: " + user.Account_Number + "\nBalance: " + user.Balance
                                + "\n");
                Console.WriteLine("=============================================");
            }

        }
        public void GetAllUsers()
        {
            List<GetUser> getUsers = dBHelper.ReadAllData<GetUser>("sp_viewAllUsers", null);
            if (getUsers != null)
                foreach (GetUser user in getUsers)
                {
                    Console.WriteLine("\nId: " + user.Id + "\nUserName: " + user.UserName +
                                    "\nUserPassword: " + user.UserPassword + "\nUserType: " + user.UserType +
                                    "\nPhoneNumber: " + user.PhoneNumber + "\nAddress: " + user.Address +
                                    "\nBirthDate: " + user.BirthDate + "\nIdentificationNumber: " + user.IdentificationNumber +
                                    "\nIdentificationType: " + user.IdentificationType + "\nGender: " + user.Gender + "\nAccount Number: " + user.Account_Number + "\nBalance: " + user.Balance
                                    + "\n");
                    Console.WriteLine("=============================================");
                }

        }
        public void GetAllUsersByRole(int id)
        {

            List<GetUser> getUsers = dBHelper.ReadAllData<GetUser>("sp_viewUsersByRole", ("@RoleId", id));
            if (getUsers != null)
                foreach (GetUser user in getUsers)
                {
                    Console.WriteLine("\nId: " + user.Id + "\nUserName: " + user.UserName +
                                    "\nUserPassword: " + user.UserPassword + "\nUserType: " + user.UserType +
                                    "\nPhoneNumber: " + user.PhoneNumber + "\nAddress: " + user.Address +
                                    "\nBirthDate: " + user.BirthDate + "\nIdentificationNumber: " + user.IdentificationNumber +
                                    "\nIdentificationType: " + user.IdentificationType + "\nGender: " + user.Gender + "\nAccount Number: " + user.Account_Number + "\nBalance: " + user.Balance
                                    + "\n");
                    Console.WriteLine("=============================================");
                }
        }
    }
}
