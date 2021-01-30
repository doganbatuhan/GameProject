using GameProject.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Validation
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
