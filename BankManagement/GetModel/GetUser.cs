using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.ViewModel
{
    public class GetUser
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public string? UserType { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? IdentificationType { get; set; }
        public string? Gender { get; set; }
        public decimal? Balance { get; set; }
        public string? Account_Number { get; set; }

    }
}
