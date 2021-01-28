using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class NewEStateUserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "SEYIT" && gamer.LastName == "ULUDAG" && gamer.IdentityNumber == 12345678910 && gamer.BirthYear == 2001)
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
