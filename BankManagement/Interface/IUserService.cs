using BankManagement.Models;

namespace BankManagement.Interface
{
    public interface IUserService
    {
        void AddUser(UserDTO user);
        void GetUser(int id);
        void GetAllUsers();
        void GetAllUsersByRole(int id);
    }
}
