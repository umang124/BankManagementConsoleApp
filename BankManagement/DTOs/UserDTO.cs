using BankManagement.Interface;

namespace BankManagement.Models
{
    public class UserDTO 
    {
        public UserDTO(string? UserName, string? UserPassword,
            int UserType, string? PhoneNumber, string? Address, DateTime BirthDate,
            string? IdentificationNumber, int IdentificationType, int Gender)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.UserType = UserType;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.BirthDate = BirthDate;
            this.IdentificationNumber = IdentificationNumber;
            this.IdentificationType = IdentificationType;
            this.Gender = Gender;

        }
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public int UserType { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string? IdentificationNumber { get; set; }
        public int IdentificationType { get; set; }
        public int Gender { get; set; }

    }
}
