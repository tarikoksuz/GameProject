using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1986 && gamer.FirstName == "Fernando" && gamer.LastName == "Muslera" && gamer.IdentityNumber == 123456789)
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
