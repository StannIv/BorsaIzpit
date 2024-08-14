using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace StokovaBorsa.Data
{
    public class Client:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress {  get; set; }
        //public string PhoneNumber {  get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
