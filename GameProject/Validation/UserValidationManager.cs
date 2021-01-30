using GameProject.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Validation
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName.ToUpper() == "BATUHAN"
                && gamer.LastName.ToUpper() == "DOĞAN" && gamer.NationalityId == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
