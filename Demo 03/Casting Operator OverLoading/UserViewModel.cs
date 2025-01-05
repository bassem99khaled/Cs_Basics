using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03.Casting_Operator_OverLoading
{
    // ViewModel : Is A class that Represent the Data that will be Rendered in a view [HTML]

    internal class UserViewModel
    
    {
    
        public int Id { get; set; }
        public string? FName { get; set; }
        public string? LName { get; set; }
        public string? Email { get; set; }
        public string? PassWord { get; set; }

        public static explicit operator UserViewModel(User user)

        {
            string[]? Names = user.FullName?.Split("");
            return new UserViewModel()
            {
                Id = user?.Id ?? 0,
                FName = Names?.Length > 0? Names[0] : string.Empty,
                LName = Names?.Length > 1? Names[1] : string.Empty,
                Email = user?.Email ?? string.Empty,
                PassWord = user?.Password ?? string.Empty,
            };
        }
    
    }
}
