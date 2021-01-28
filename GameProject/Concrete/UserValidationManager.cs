using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "SEYIT" && gamer.LastName == "ULUDAĞ" && gamer.IdentityNumber == 12345678910 && gamer.BirthYear == 2001)
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
